using System;
using GradePointCalculator.Model;
using System.Text.RegularExpressions;

namespace GradePointCalculator.Common
{
	public class Validation
	{
        public static bool Validate(String data)
        {
            var validateCourse = new Regex(@"^\w{1,3}\d{1,3}\s{1}[1-5]{1}\s{1}([0-9]|[1-9][0-9]|100)$");
            return validateCourse.IsMatch(data);
        }
    }
}

