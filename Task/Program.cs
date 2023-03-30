namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int FirstNumber;
            int SecondNumber;

            // Displays the first number 
            Console.Write(" Enter first number: ");
            string Input = Console.ReadLine();
            FirstNumber = Convert.ToInt32(Input);

            //Displays the second number
            Console.Write(" Enter second number: ");
            string Output = Console.ReadLine();
            SecondNumber = Convert.ToInt32(Output);

            //A program to calculate the sum of two given integer values.
            //If both values are the same, triple their sum.
            if (FirstNumber == SecondNumber)
            {
                Console.WriteLine($" Result: {(FirstNumber + SecondNumber) * 3} ");
            }
            else
            {
                Console.WriteLine($" Result: {FirstNumber + SecondNumber}");

            }

            Main(args);

        }
    }
}