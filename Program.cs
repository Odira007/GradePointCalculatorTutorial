using GradePointCalculator.UI;

namespace GradePointCalculator;
class Program
{
    static void Main(string[] args)
    {
        UserInterface.Start();


        //string detailss = "lucy is here";

        //string[] split = detailss.Split(" ");


        //for (int i=0; i<split.Length; i++)
        //{
        //    Console.WriteLine("Array at index " + i + " : " + split[i]);
        //}













        //OneToHundred(100);

        //int sum = Sum(4, 5);     // method arguments
        //Console.WriteLine(sum);

        //int sum2 = Sum(7, 8); // method call / method invocation
        //int sum3 = Sum(100, 200);

        //Console.WriteLine(sum2);
        //Console.WriteLine(sum3);

        //string[] chars = { "ybfuer", "hefbnuherj", "hbfuehjr" };
        //for (int i = 0; i < chars.Length; i++)
        //{
        //    Console.WriteLine(chars[i]);
        //}

        // for loops
        // loop through this chars

        // int i = 0; : initialization
        // i < chars.Length : condition
        // i++ / i = i + 1 : incrementer





        //string[] chars2 = new string[3];

        //chars2[0] = "ybfuer";
        //chars2[1] = "hefbnuherj";
        //chars2[2] = "hbfuehjr";

        //for (int i = 0; i < chars2.Length; i++)
        //{
        //    Console.WriteLine(chars2[i]);
        //}

        // arrays have a fixed size.
        // arrays have zero-based index.


        // do something


    }


    // method definition
    // method help your code to be reusable
    public static int Sum(int a, int b) // method parameters
    {
        return a + b; // raw data / hard-cording
    }


    public static void ListExample()
    {
        List<string> list = new List<string> { "ybfuer", "hefbnuherj", "hbfuehjr" };
        List<int> list2 = new List<int> { };
    }

    public static void OneToHundred(int num)
    {
        // created an empty list
        List<int> list = new List<int>();

        for (int i = 2; i<=num; i++)
        {
            list.Add(i);
        }

        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i] + " ");
        }
    }
}

