namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;

            Console.Write(" Enter number: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Enter number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            for (int j = number1; j < number2; j++)
            {

                int value = 0;

                for (int i = 1; i < j; i++)
                {
                    if (j % i == 0)
                    {
                        value += i;
                    }

                }

                if (value == j)
                {
                    Console.WriteLine($" {j} - is a perfect number.");
                } 
                else
                {
                    Console.WriteLine($"{j} - is not a perfect number.");
                }    

            }
        }
    }
}