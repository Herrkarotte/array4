using System;

namespace array4
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            Console.WriteLine("Enter the number of rows:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of seats:");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] Arr = new int[n, m];
            for (int i = 0; i != n; i++)
            {
                for (int j = 0; j != m; j++)
                {
                    Arr[i, j] = rnd.Next(0, 2);
                    Console.Write(Arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            int count = 0;
            Console.WriteLine("\nEnter the required number of consecutive places:");
            int k = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i != n; i++)
            {
                for (int j = 0; j != m; j++)
                {
                    if (Arr[i, j] == 0)
                    {
                        count++;
                        if (count == k)
                        {
                            Console.WriteLine("The desired row: " + (i + 1));
                            return;
                        }
                    }
                    else count = 0;

                }
                count = 0;
            }
            Console.WriteLine("The request was not completed: " + 0);
            return;
        }
    }
}
