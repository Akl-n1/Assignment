using ExaminationSystem;
using Microsoft.EntityFrameworkCore;
using Project_CSharp.Models;
using Project_CSharp.Repositories;
using Project_CSharp.Services;

class Program
{
    static void Main(string[] args)
    {
        var db = new AppDbContext();

        var userRepo = new UserRepository(db);
        var examRepo = new ExamRepository(db);
        var logger = new FileLogger();
        var authService = new AuthService(userRepo);
        var examService = new ExamService(examRepo, logger);
        var approvalService = new FinalExamResultApprovalService();

        Console.WriteLine("=== Welcome to Examination System ===");

        while (true)
        {
            Console.WriteLine("\n1. Register\n2. Login\n3. Exit");
            Console.Write("Choose an option: ");
            var choice = Console.ReadLine() ?? "";

            if (choice == "3") break;

            Console.Write("Role (Student/Instructor/Admin): ");
            var roleInput = Console.ReadLine() ?? "";
            Console.Write("Username: "); var username = Console.ReadLine() ?? "";
            Console.Write("Password: "); var password = Console.ReadLine() ?? "";
            Console.Write("Full Name: "); var fullName = Console.ReadLine() ?? "";

            User currentUser = null;

            // محاولة التسجيل أولاً
            try
            {
                currentUser = roleInput.ToLower() switch
                {
                    "student" => authService.RegisterStudent(username, password, fullName),
                    "instructor" => authService.RegisterInstructor(username, password, fullName),
                    "admin" => authService.RegisterAdmin(username, password, fullName),
                    _ => throw new InvalidOperationException("Invalid role")
                };
                Console.WriteLine($"Registered new {currentUser.Role}: {currentUser.FullName}");
            }
            catch
            {
                // إذا الاسم موجود بالفعل، محاولة تسجيل الدخول
                currentUser = authService.Login(username, password);

                if (currentUser == null)
                {
                    Console.WriteLine("Login failed! Username or password incorrect for any role.");
                    continue; // العودة لاختيار العملية
                }
                else
                {
                    Console.WriteLine($"Logged in as {currentUser.Role}: {currentUser.FullName}");
                }
            }

            // ===================== Instructor =====================
            if (currentUser is Instructor instructor)
            {
                Console.Write("Enter subject for exam: ");
                var subjectName = Console.ReadLine() ?? "Math";

                Console.Write("Exam type (Final/Practice): ");
                var examType = Console.ReadLine() ?? "Final";

                Exam exam = examType.ToLower() == "practice" ? (Exam)new PracticeExam() : new FinalExam();
                exam.Title = $"{subjectName} {examType} Exam";
                exam.Subject = new Subject { Name = subjectName };
                exam.TimeLimit = TimeSpan.FromMinutes(30);

                // Load questions from JSON
                exam.Questions.AddRange(QuestionBank.GenerateSampleQuestions(subjectName));

                examService.AddExam(exam);
                instructor.CreatedExams.Add(exam.Id);
                db.SaveChanges();

                Console.WriteLine($"Exam '{exam.Title}' created with {exam.Questions.Count} questions!");
            }
            // ===================== Student =====================
            else if (currentUser is Student student)
            {
                var exams = examService.GetExams();
                var availableExams = exams.Where(e => student.SubscribedExamIds.Contains(e.Id) || !student.SubscribedExamIds.Contains(e.Id)).ToList();

                if (!availableExams.Any())
                {
                    Console.WriteLine("No exams available for you yet.");
                    continue;
                }

                Console.WriteLine("Available Exams:");
                for (int i = 0; i < availableExams.Count; i++)
                    Console.WriteLine($"{i + 1}. {availableExams[i].Title} ({availableExams[i].GetType().Name})");

                Console.Write("Select exam number: ");
                if (!int.TryParse(Console.ReadLine(), out int selectedIndex) || selectedIndex < 1 || selectedIndex > availableExams.Count)
                    continue;

                var selectedExam = availableExams[selectedIndex - 1];
                selectedExam.Mode = ExamMode.Starting;
                selectedExam.ShowExam();

                // Collect student answers
                var studentResponses = new Dictionary<Guid, List<Guid>>();
                foreach (var q in selectedExam.Questions)
                {
                    studentResponses[q.Id] = new List<Guid>();
                    foreach (var a in q.Answers)
                    {
                        Console.WriteLine($"Mark '{a.Text}' as correct? (y/n): ");
                        var input = Console.ReadLine();
                        if (input?.ToLower() == "y") studentResponses[q.Id].Add(a.Id);
                    }
                }

                var score = selectedExam.Evaluate(studentResponses);
                Console.WriteLine($"You scored: {score}/{selectedExam.Questions.Sum(q => q.Marks)}");

                if (selectedExam is FinalExam)
                {
                    approvalService.SubmitResult(student, selectedExam, score);

                    var instructors = userRepo.GetAll().Where(u => u.Role == UserRole.Instructor).Cast<Instructor>().ToList();
                    if (instructors.Any())
                    {
                        var instr = instructors.First();
                        approvalService.ApproveResult(instr, selectedExam);

                        var approvedResults = approvalService.GetApprovedResults(student, selectedExam);
                        foreach (var res in approvedResults)
                        {
                            Console.WriteLine($"[Student View] Final Exam '{selectedExam.Title}' Score: {res.Score}/{selectedExam.Questions.Sum(q => q.Marks)}");
                        }
                    }
                }
            }
        }
    }
}
