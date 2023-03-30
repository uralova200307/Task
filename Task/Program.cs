namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            string count = "";

            Console.Write(" Enter number: ");
            number = Convert.ToInt32(Console.ReadLine());

            while (number >= 1)
            {
                count = (number % 2) + count;
                number = number / 2;
            }

            Console.WriteLine(count);
            Console.WriteLine();

            Main(args);
        }
    }
}