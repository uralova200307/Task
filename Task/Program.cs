using System.ComponentModel.Design;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Random random = new Random();
            CreateArray();
           
        }

        public static void CreateArray()
        {
            Random random = new Random();
            int[][] array = new int[5][];
            int sum;
            int maxSum = 0;
            int currentSum;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new int[6];
                currentSum = 0;
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = random.Next(2,10);
                    Console.Write(array[i][j]);
                    currentSum += array[i][j];
                }

                maxSum = currentSum > maxSum ? currentSum : maxSum;

                Console.Write($"   {1+i}-qatordagi summa: {currentSum} {maxSum}");
                Console.WriteLine();

            }

        }
    }
}
