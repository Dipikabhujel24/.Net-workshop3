using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class LoopExamples
    {
        public void ShowLoops()
        {
            // For loop
            Console.Write("Enter a number N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum from 1 to " + N + " is " + sum);

            // While loop
            Console.WriteLine("\nNumbers from 1 to 20 (skip multiples of 4, stop at 15):");
            int number = 1;
            while (number <= 20)
            {
                if (number == 15)
                {
                    Console.WriteLine("Reached 15. Breaking loop.");
                    break;
                }

                if (number % 4 == 0)
                {
                    number++;
                    continue;
                }

                Console.WriteLine(number);
                number++;
            }

            // Foreach loop
            Console.WriteLine("\nEnter 5 numbers:");
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Number " + (i + 1) + ": ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int total = 0;
            foreach (int val in arr)
            {
                total += val;
            }

            Console.WriteLine("Sum of all numbers = " + total);
        }
    }
}
    
