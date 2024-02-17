using System;
namespace GradePointCalculator.Model
{
	public class Student
	{
        public int TotalCourseUnits { get; set; } = 0;
        public int TotalCourseUnitsPassed { get; set; } = 0;
        public int TotalWeightPoints { get; set; } = 0;
        public List<Course> Courses { get; set; } = new();
    }
}

