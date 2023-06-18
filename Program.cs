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
        {
             Console.WriteLine("Store elements in an array and print them");
             StoreAndPrint p1 = new StoreAndPrint();
             p1.StoreArray();

            Console.WriteLine("Read n values in an array and display them in reverse order");
            StoreAndPrintInReverse p2 = new StoreAndPrintInReverse();
            p2.Rev();

            Console.WriteLine("Sum of all array elements");
            SumOfElementsInArray p3 = new SumOfElementsInArray();
            p3.Program3();

            Console.WriteLine("Copy the elements of one array into another Array.");
            CopyArrayToAnotherArray p4=new CopyArrayToAnotherArray();
            p4.Program();


            Console.WriteLine("Count duplicate elements in an array");
            Duplicate p5= new Duplicate();
            p5.NumberD();

            Console.WriteLine("Print all unique elements in an array");
            Unique p6 = new Unique();
            p6.Num();

            Console.WriteLine("Merge two arrays of the same size sorted in ascending order");
            MergeTwoArray p7=new MergeTwoArray();
            p7.Two();

            Console.WriteLine("Sort elements of an array in ascending order");
            AscendingOrder p8= new AscendingOrder();
            p8.ArrayOrder();

            Console.WriteLine("Sort array elements in descending order.");
            Descending p9=new Descending();
            p9.Des();

            Console.WriteLine("Find second Largest element");
            SecondLargest p10=new SecondLargest();
            p10.Element();


            Console.WriteLine("Find second Smallest element");
            SecondSmallest p11 = new SecondSmallest();
            p11.Small();

            Console.WriteLine("Get only odd values from a given integer array.");
            OddValues p12 = new OddValues();
            p12.OddNumbers();

            Console.WriteLine("Removes all duplicate elements from a given array and returns an updated array.");
            DeleteDuplicate p13 = new DeleteDuplicate();
            p13.Delete();

            Console.WriteLine("Count frequency of each Element");
            CountFrequency p14=new CountFrequency();
            p14.Numbers();

            Console.WriteLine("Find Max and Min Number");
            MaxAndMin p15=new MaxAndMin();
            p15.MaM();


            Console.WriteLine("Print Even and odd numbers in seperate list");
            SeparateEvenAndOdd p16=new SeparateEvenAndOdd();
            p16.EvenOdd();
        }
   
    }

}