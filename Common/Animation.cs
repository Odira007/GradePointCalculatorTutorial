using static System.Console;

namespace GradePointCalculator.Common
{
	public class Animation
	{
		public static void Create()
		{
            do
            {
                for (int i = 0; i < 3; i++)
                {
                    Write(".");
                    Thread.Sleep(1000);
                }
            }
            while (DateTime.Now.Millisecond < 6);
        }
	}
}

