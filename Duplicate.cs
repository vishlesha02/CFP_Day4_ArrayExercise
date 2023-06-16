using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseArray
{
    internal class Duplicate
    {
        int count=0;
        public void NumberD()
        {
            Console.WriteLine("Enter Length of array");
            int n=int.Parse(Console.ReadLine());

            int[] array=new int[n];

            Console.WriteLine("Enter the Elements to Array");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine()); 
            
            }

            Console.WriteLine("Array List : ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"Total count of Duplicate Elements is {count}");

        }

    }
}
