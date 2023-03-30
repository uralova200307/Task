namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int factorial = 1;

            Console.Write(" Enter number: ");
            int.TryParse(Console.ReadLine(), out number);

            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine($" {factorial} - result ");
            Console.WriteLine();

            Main(args);
        }
    }
}