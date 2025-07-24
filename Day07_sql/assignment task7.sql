CREATE PROCEDURE GetStudentCountPerDepartment
with encryption
AS
BEGIN
    SELECT 
        d.Dept_Id,
        d.Dept_Name,
        COUNT(s.St_Id) AS StudentCount
    FROM Department d
    LEFT JOIN Student s ON d.Dept_Id = s.Dept_Id
    GROUP BY d.Dept_Id, d.Dept_Name
END

exec GetStudentCountPerDepartment
----------------------------------------
CREATE PROCEDURE CheckEmployeesInProject
    @ProjectName NVARCHAR(100)
AS
BEGIN
    DECLARE @EmployeeCount INT;
    SELECT @EmployeeCount = COUNT(DISTINCT wf.ESSn)
    FROM Works_for wf
    JOIN Project p ON wf.Pno = p.Pnumber
    WHERE p.Pname = @ProjectName;

    IF @EmployeeCount >= 3
    BEGIN
        SELECT 'The number of employees in the project ' + @ProjectName + ' is 3 or more' AS Message;
    END
    ELSE
    BEGIN
        SELECT 'The following employees work for the project ' + @ProjectName AS Message;

        SELECT e.Fname, e.Lname
        FROM Works_for wf
        JOIN Project p ON wf.Pno = p.Pnumber
        JOIN Employee e ON wf.ESSn = e.SSN
        WHERE p.Pname = @ProjectName;
    END
END


CheckEmployeesInProject 'AL Solimaniah'
-------------------------------------------------------------------------
CREATE PROCEDURE ReplaceEmployeeInProject @OldEmpSSN INT, @NewEmpSSN INT,@ProjectNo INT
AS
BEGIN
    DECLARE @Hours FLOAT;
    SELECT @Hours = Hours
    FROM Works_for
    WHERE ESSn = @OldEmpSSN AND Pno = @ProjectNo;

    IF @Hours IS NOT NULL
    BEGIN
        DELETE FROM Works_for
        WHERE ESSn = @OldEmpSSN AND Pno = @ProjectNo;

        INSERT INTO Works_for (ESSn, Pno, Hours)
        VALUES (@NewEmpSSN, @ProjectNo, @Hours);

        PRINT 'Employee replaced successfully.';
    END
    ELSE
    BEGIN
        PRINT 'The old employee is not assigned to this project.';
    END
END;
ReplaceEmployeeInProject  968574,512463,700
-----------------------------------