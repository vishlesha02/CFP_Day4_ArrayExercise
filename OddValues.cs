using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseArray
{
    internal class OddValues
    {
        public void OddNumbers()
        {
            int[] array = { 2, 5, 6, 3, 4, 8 };
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    Console.WriteLine(array[i]);
                    
                }
            
            }
        }
    }
}
