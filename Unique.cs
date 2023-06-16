using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseArray
{
    internal class Unique
    {
        int temp=0;
        public void Num()
        {
            Console.WriteLine("Enter Length of Array");
            int a=int.Parse(Console.ReadLine());

            int[] array= new int[a];

            Console.WriteLine("Enter the Elements");
            for(int i=0;i<array.Length;i++)
            {
                array[i]=int.Parse(Console.ReadLine());
            }

            Console.WriteLine("List of Array is: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
                
                for (int j = i + 1; j < array.Length-1; j++)
                {
                    if (array[i] != array[j])
                    {
                         temp = array[i];
                        

                    }
                }
               
            }
                Console.WriteLine($"The Unique number in Array :{temp}");
            
        }
    }
}
