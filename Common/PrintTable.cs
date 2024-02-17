using System;
using static System.Console;
using GradePointCalculator.Model;

namespace GradePointCalculator.Common
{
    public class PrintTable
    {
        public static void Print(Student student, double gpa)
        {
            Dash("-");
            WriteLine();
            WriteLine(format: "{0, -15} | {1, -13} | {2, -7} | {3, -12} | {4, -12} | {5, -15}",
                "COURSE & CODE", "COURSE UNIT", "GRADE", "GRADE-UNIT", "WEIGHT Pt.", "REMARK");
            Dash("-");
            WriteLine();

            foreach (Course course in student.Courses)
            {
                WriteLine(format: "{0, -15} | {1, -13} | {2, -7} | {3, -12} | {4, -12} | {5, -15}",
                    course.CourseCode, course.CourseUnit, course.StudentGrade,
                    (int)course.StudentGrade, course.WeightPoint, course.GradeRemark);
            }

            Dash("-");

            WriteLine();
            WriteLine($"Total Course Unit Registered is {student.TotalCourseUnits}\nTotal Unit Passed is " +
                $"{student.TotalCourseUnitsPassed}\nTotal Weight Point is {student.TotalWeightPoints}");

            WriteLine(format: "Your GPA is = {0:N2} to 2 decimal places.", gpa);
        }

        private static void Dash(string dash)
        {
            for (int i = 0; i < 83; i++)
            {
                Write(dash);
            }
        }
    }
}

