using System;
using GradePointCalculator.Model;
using static System.Console;
using GradePointCalculator.Core;
using GradePointCalculator.Common;

namespace GradePointCalculator.UI
{
    public class UserInterface
    {
        public static void Start()
        {
            WriteLine($"Welcome to MatrixGPA. Our app provides a user-friendly " +
                $"interface for you to{Environment.NewLine}calculate your GPA");

            WriteLine("Enter your course code, course unit and course score in the " +
                "following format: BLA101 5 50");
            WriteLine();

            Student student = new Student();
            StudentService studentService = new();

            string? input;
            string? calculate;

        start:
            do
            {
                Write("Course code, course unit and course score: ");
                input = ReadLine()?.ToUpper();

                if (!Validation.Validate(input ?? ""))
                {
                    WriteLine("Your input was in the wrong format, try again :)");
                    WriteLine();
                    goto start;
                }
                else
                {
                    studentService.CreateCourse(input ?? "", student);
                    WriteLine(student.Courses.Count);

                }

                Write("Calculate? (Y/N): ");
                calculate = ReadLine()?.ToUpper();
            }
            while (calculate != "Y");

            StudentService.Evaluate(student);

            Write("Please wait while we calculate your GPA ");
            Animation.Create();

            WriteLine();
            GradeService.CalculateGpa(student);
        }
    }
}

