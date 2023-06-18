using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseArray
{
    internal class CountFrequency
    {
        public void Numbers()
        {
            Console.WriteLine("Enter the Length of Array");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Elements");
            int[] array = new int[a];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                int count = 1;

               
                if (array[i] != -1)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] == array[j])
                        {
                            count++;
                            array[j] = -1;
                        }
                    }

                    Console.WriteLine($"The count frequency of {array[i]}: {count}");
                }
            }
        }
    }
}