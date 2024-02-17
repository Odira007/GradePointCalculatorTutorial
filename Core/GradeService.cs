using System;
using GradePointCalculator.Model;
using GradePointCalculator.Model.Enums;
using GradePointCalculator.Common;

namespace GradePointCalculator.Core
{
	public class GradeService
	{
		public static void ComputeGrades(int courseScore, Course course)
		{
            if (courseScore >= 70 && courseScore <= 100)
            {
                course.GradeRemark = "Excellent";
                course.StudentGrade = Grades.A;
                course.StudentGradeUnit = (int)Grades.A;
            }
            else if (courseScore >= 60 && courseScore <= 69)
            {
                course.GradeRemark = "Very Good";
                course.StudentGrade = Grades.B;
                course.StudentGradeUnit = (int)Grades.B;
            }
            else if (courseScore >= 50 && courseScore <= 59)
            {
                course.GradeRemark = "Good";
                course.StudentGrade = Grades.C;
                course.StudentGradeUnit = (int)Grades.C;
            }
            else if (courseScore >= 45 && courseScore <= 49)
            {
                course.GradeRemark = "Fair";
                course.StudentGrade = Grades.D;
                course.StudentGradeUnit = (int)Grades.D;
            }
            else if (courseScore >= 40 && courseScore <= 44)
            {
                course.GradeRemark = "Pass";
                course.StudentGrade = Grades.E;
                course.StudentGradeUnit = (int)Grades.E;
            }
            else
            {
                course.GradeRemark = "Fail";
                course.StudentGrade = Grades.F;
                course.StudentGradeUnit = (int)Grades.F;
            }
        }

        public static void CalculateGpa(Student student)
        {
            double gpa = (double)student.TotalWeightPoints / (double)student.TotalCourseUnitsPassed;
            PrintTable.Print(student, gpa);
        }
    }
}

