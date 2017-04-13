using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[5];
            double average = 0;
            //int[,] numArray2 = new int[5, 5];
            double average2 = 0;
            int total = 0;
            int[] total2 = new int[5];
            //Console.WriteLine("Integer input and average. Enter 5 numbers.");
            //for (int i = 0; i < numArray.Length; i++)
            //{
            //    Console.Write("Please enter a number: ");
            //    numArray[i] = Convert.ToInt32(Console.ReadLine());

            //}
            //Console.WriteLine("The average of these numbers is: " + numArray.Average());
            //for (int j = 0; j<numArray.Length; j++)
            //{
            //    average += (double)numArray[j];
            //}



            //Console.WriteLine("Integer input and average. Enter 5x5 numbers.");
            //for (int i = 0; i < numArray2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < numArray2.GetLength(1);j++)
            //    {
            //        Console.Write("Please enter a number: ");
            //        numArray2[i, j] = Convert.ToInt32(Console.ReadLine());
            //        //average2 += numArray2[i, j]/(numArray2.GetLength(0)* numArray2.GetLength(1));
            //        total += numArray2[i, j];
            //    }
            //}
            ////Console.WriteLine("The average of these numbers is: " + average2);
            //Console.WriteLine("The average of these numbers is: " + (double)total/ (numArray2.GetLength(0) * numArray2.GetLength(1)));
            int[,] numArray2 = new int[5,5] { { 1,2,3,4,5},{ 1,2,3,4,6},{ 2,3,4,5,6},{ 3,4,5,6,7},{ 4,5,6,7,8} };
            Console.WriteLine("Integer input and average. Enter 5x5 numbers.");
            for (int i = 0; i < numArray2.GetLength(0); i++)
            {
                total = 0;
                for (int j = 0; j < numArray2.GetLength(1); j++)
                {
                    total += numArray2[i, j];
                }
                Console.WriteLine("The sum of row "+i+" is "+total);
            }
            for (int i = 0; i < numArray2.GetLength(0); i++)
            {
                total = 0;
                for (int j = 0; j < numArray2.GetLength(1); j++)
                {
                    total += numArray2[j, i];
                }
                total2[i] = total;
                Console.WriteLine("The sum of column " + i + " is " + total);
            }
            Console.WriteLine("The sum of all columns is " + total2.Sum());
        }
    }
}
