using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseArray
{
    internal class SumOfElementsInArray
    {
        public void Program3()
        {
            Console.Write("Enter the number of values : ");
            int a = int.Parse(Console.ReadLine());

            int[] numbers = new int[a];

            Console.Write("Enter a value: ");
            for (int i = 0; i < a; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine($"The sum of all elemnts in array is : {sum}");


        }
    }
}
