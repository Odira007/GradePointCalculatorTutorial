using System;
using GradePointCalculator.Model.Enums;
using GradePointCalculator.Core;

namespace GradePointCalculator.Model
{
	public class Course
	{
		public Course(int id, string courseCode, int courseUnit, int courseScore)
		{           
            Id = id;
            CourseCode = courseCode;
            CourseUnit = courseUnit;
            CourseScore = courseScore;
            GradeService.ComputeGrades(CourseScore, this);
            WeightPoint = (courseUnit*StudentGradeUnit);
        }

        public int Id { get; set; }
        public string CourseCode { get; set; }
        public int CourseUnit { get; set; }
        public int CourseScore { get; set; }
        public Grades StudentGrade { get; set; }
        public int StudentGradeUnit { get; set; }
        public int WeightPoint { get; set; }
        public string? GradeRemark { get; set; }
    }
}

