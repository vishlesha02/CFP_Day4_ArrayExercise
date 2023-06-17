using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExerciseArray
{
        internal class SecondLargest
        {
            int temp = 0;
            public void Element()
            {
                Console.WriteLine("Enter the length of array");
                int a = int.Parse(Console.ReadLine());

                int[] array = new int[a];
                Console.WriteLine("Enter the elements");
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < array.Length; i++)
                {
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

                Console.WriteLine("The sorted array is : ");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }

                Console.WriteLine($"The second largest element is {array[array.Length - 2]}");

            }
        }
}

