using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ExerciseArray
{
    internal class DeleteDuplicate
    {
        int unique = 0;
        bool duplicatearray = false;

        public void Delete()
        {
            Console.WriteLine("Enter length");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Elements in list");
            int[] array = new int[a];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int[] updatedArray = new int[a];

            for (int i = 0; i < array.Length; i++)
            {
                duplicatearray = false;

                for (int j = 0; j < unique; j++)
                {
                    if (array[i] == updatedArray[j])
                    {
                        duplicatearray = true;
                        break;
                    }
                }

                if (!duplicatearray)
                {
                    updatedArray[unique] = array[i];
                    unique++;
                }
            }

            Console.WriteLine("Updated Array:");

            for (int i = 0; i < unique; i++)
            {
                Console.WriteLine(updatedArray[i]);
            }
        }
    }
}
