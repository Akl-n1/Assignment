using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Project_CSharp.Models;

public class QuestionBank
{
    private readonly Dictionary<string, List<Question>> _questionsBySubject = new();

    public QuestionBank(string filePath)
    {
        if (!File.Exists(filePath))
            throw new FileNotFoundException("Questions file not found", filePath);

        var json = File.ReadAllText(filePath);
        var raw = JsonSerializer.Deserialize<Dictionary<string, List<RawQuestion>>>(json);

        foreach (var subject in raw!)
        {
            _questionsBySubject[subject.Key] = new List<Question>();
            foreach (var r in subject.Value)
            {
                Question q = r.Type switch
                {
                    "ChooseOneQuestion" => new ChooseOneQuestion(r.QuestionText, r.Marks),
                    "TrueFalseQuestion" => new TrueFalseQuestion(r.QuestionText, r.Marks),
                    _ => throw new Exception("Unknown question type")
                };
                q.Answers.AddRange(r.Answers);
                _questionsBySubject[subject.Key].Add(q);
            }
        }
    }

    public List<Question> GetRandomQuestions(string subject, int count)
    {
        if (!_questionsBySubject.ContainsKey(subject))
            throw new Exception($"No questions for subject {subject}");

        var list = _questionsBySubject[subject];
        var rnd = new Random();
        var selected = new List<Question>();

        for (int i = 0; i < Math.Min(count, list.Count); i++)
        {
            int index = rnd.Next(list.Count);
            selected.Add(list[index]);
            list.RemoveAt(index);
        }

        return selected;
    }

    public static List<Question> GenerateSampleQuestions(string subject)
    {
        var bank = new QuestionBank(Path.Combine("Data", "Questions.json"));
        return bank.GetRandomQuestions(subject, 10);
    }

    private class RawQuestion
    {
        public string Type { get; set; } = "";
        public string QuestionText { get; set; } = "";
        public double Marks { get; set; }
        public List<Answer> Answers { get; set; } = new();
    }
}
