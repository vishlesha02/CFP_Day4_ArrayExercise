using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseArray
{
    internal class Program
    {
        static void Main(String[] args)
        {/*
             Console.WriteLine("Store elements in an array and print them");
             StoreAndPrint p1 = new StoreAndPrint();
             p1.StoreArray();*/

            Console.WriteLine("Read n values in an array and display them in reverse order");
            StoreAndPrintInReverse p2 = new StoreAndPrintInReverse();
            p2.Rev();

        }
   
    }

}