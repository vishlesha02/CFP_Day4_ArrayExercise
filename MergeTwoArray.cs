using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseArray
{
    internal class MergeTwoArray
    {
        int i, j, k;
        int a, a2, a3;
        int temp;
        public void Two()
        {
            Console.WriteLine("Enter the Length of Array");
            int a=int.Parse(Console.ReadLine());

            int[] array= new int[a];

            Console.WriteLine("Enter the Elements");
            for ( i = 0; i < array.Length; i++)
            {
                array[i]=int.Parse(Console.ReadLine());

            }

            Console.WriteLine("List of Array");

            for ( i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }




            Console.WriteLine("Enter the Length of Array");
             a2 = int.Parse(Console.ReadLine());

            int[] array2 = new int[a2];
            Console.WriteLine("Enter the Elements");
            for ( i = 0; i < array2.Length; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("List of Array");
            for ( i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);

            }
            int a3;
            a3 = a + a2;

            int[] array3 = new int[a3];

            for ( i = 0; i < array.Length; i++)
            {
                array3[i] = array[i];
            }
            for ( j = 0; j < a2; j++)
            {
                array3[i] = array2[j];
                i++;
            }

            for (i = 0; i < array3.Length; i++)
            {
                for (k = 0; k < array3.Length - 1; k++)
                {
                    if (array3[i] < array3[k])
                    { 
                        temp= array3[i];
                        array3[i] = array3[k];
                        array3[k] = temp; 
                    }
                
                }
            }
            Console.WriteLine("The merged array in ascending order is :");
            for(i=0; i<array3.Length; i++)
            {
                Console.WriteLine(array3[i]);

            }

        }
    }
}
