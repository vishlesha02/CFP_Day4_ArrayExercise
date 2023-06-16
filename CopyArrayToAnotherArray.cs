using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseArray
{
    internal class CopyArrayToAnotherArray
    {
      
        public void Program()
        {
            Console.WriteLine("Enter the Length of array");
            int a = int.Parse(Console.ReadLine());

            int[] array = new int[a];
            int[] array2 = new int[a];

            Console.WriteLine("Enter the Elements to array");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine($"The list of Array : ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]}");
            }

            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i];
            }

            Console.WriteLine($"The Copied list of Array :");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array2[i]}");

            }
        }
    }
}
