namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write(" Enter number: ");
            number = Convert.ToInt32(Console.ReadLine());

            int cout = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    cout++;
                }
            }

            if (cout <= 2)
            {
                Console.WriteLine($"{number} - a prime number");
            }
            else
            {
                Console.WriteLine($" {number} - not a prime number");
            }
        }
    }
}