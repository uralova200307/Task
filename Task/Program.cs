using System.ComponentModel.Design;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstnumber, secondnumber, thirdnumber, fourthnumber, max, min;


            Console.Write(" Enter first number: ");
            firstnumber = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Enter second number: ");
            secondnumber = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Enter third number: ");
            thirdnumber = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Enter fourth number: ");
            fourthnumber = Convert.ToInt32(Console.ReadLine());


            max = Math.Max(fourthnumber,Math.Max(thirdnumber,Math.Max(firstnumber, secondnumber)));
            min = Math.Min(fourthnumber,Math.Min(thirdnumber,Math.Min(firstnumber, secondnumber)));


            Console.WriteLine($" Min number: {max}");
            Console.WriteLine($" Min number: {min}");

            Main(args);
        }
    }
}
