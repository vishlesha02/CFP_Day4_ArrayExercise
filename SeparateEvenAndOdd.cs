using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseArray
{
    internal class SeparateEvenAndOdd
    {
        int j, k;
        public void EvenOdd()
        {
            Console.WriteLine("Enter Length of array");
            int a=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter elements in array");
            int[] array=new int[a];
            int[] array2 = new int[a];
            int[] array3 = new int[a];



            for (int i = 0; i < array.Length; i++)
            {
                array[i]=int.Parse(Console.ReadLine());
            }

            for (int i = 0;i < array.Length; i++) 
            {
                if (array[i] % 2 == 0)
                {
                    array2[j] = array[i];
                    j++;
                }
                else 
                {
                    array3[k] = array[i];
                    k++;
                
                }
            }
            Console.WriteLine("Even Numbers are :");
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine(array2[i]);
            }

            Console.WriteLine("Even Numbers are :");
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(array3[i]);
            }

        }
    }
}
