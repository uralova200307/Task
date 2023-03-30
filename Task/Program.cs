namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("Enter number:");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 100; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine($" Divisor: {i}");
                }
            }

        }
    }
}