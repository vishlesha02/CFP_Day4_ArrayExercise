using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseArray
{
    internal class StoreAndPrintInReverse
    {
        public void Rev()
        {
            Console.Write("Enter the number of values : ");
            int a = int.Parse(Console.ReadLine());

            int[] numbers = new int[a];

            for (int i = 0; i < a; i++)
            {
                Console.Write("Enter a value: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Values in reverse order:");
            for (int i = a - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }

        }

    }
}
