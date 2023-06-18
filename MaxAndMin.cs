using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseArray
{
    internal class MaxAndMin
    {
        int max, min;
        public void MaM()
        {
            Console.WriteLine("Enter Length of array");
            int a=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Elements in array");
            int[] array= new int[a];

            for (int i = 0; i < array.Length; i++)
            {
                array[i]=int.Parse(Console.ReadLine());
            
            }

            int max = array[0];
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] > max)
                {
                    max = array[i];
                }

                if (array[i] < min)
                {
                    min = array[i];
                }

            }
            Console.WriteLine($"Maximum element is {max}");
            Console.WriteLine($"Minimum element is {min}");
        }
    }
}
