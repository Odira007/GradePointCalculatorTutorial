using System;
using GradePointCalculator.Model;

namespace GradePointCalculator.Core
{
	public class StudentService
	{
		public int Id { get; set; } = 0;

		public void CreateCourse(string courseDetails, Student student)
        {
            string[] details = courseDetails.Split(" ");

            Course course = new(++Id, details[0], Convert.ToInt32(details[1]), Convert.ToInt32(details[2]));

            student.Courses.Add(course);
        }

        public static void Evaluate(Student student)
        {
            foreach (Course c in student.Courses)
            {
                student.TotalCourseUnits += c.CourseUnit;
                student.TotalWeightPoints += c.WeightPoint;
                student.TotalCourseUnitsPassed += c.StudentGradeUnit;
            }
        }
    }
}

