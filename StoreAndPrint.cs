using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseArray
{
    class StoreAndPrint
    {
        public void StoreArray()
        {
            int[] a= new int[5];

            Console.WriteLine("Enter 5 elements of the Array: ");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The Elements of the array are : ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            
            }
        }
    }
}
