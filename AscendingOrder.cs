using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseArray
{
    
    internal class AscendingOrder
    {
        int temp = 0;
        public void ArrayOrder()
        {
            Console.WriteLine("Enter Length");
            int a=int.Parse(Console.ReadLine());
            int[] array=new int[a];

            Console.WriteLine("Enter Elements in array");
            for (int i = 0; i < array.Length; i++)
            {
                array[i]=int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The List of Array : ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]}");

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;    
                    
                    }
                }
            }
            Console.WriteLine("Array in ascending order is :");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);

            }

        }
    }
}
