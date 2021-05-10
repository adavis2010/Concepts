using System;

namespace Concepts
{
    class Program
    {
        static void Main(string[] args)
        {
       

            /*int i = 0; 

            /*while (i < 10) // WHILE LOOP
            {
                Console.WriteLine("i = {0}", i);

                i++; // increment
            }
            */

          // int i = 0, j = 1;

            //while (i < 2) //Nested WHILE loop
            //{
                //Console.WriteLine("i = {0}", i);
               // i++;

                //while (j < 2)
               // {
                    //Console.WriteLine("j = {0}", j);
                    //j++;
                //}
            //}
            
            int i = 0;

            do      // DO & WHILE
            {
                Console.WriteLine("Value of i: {0}", i);
                int j = i;

                i++;

                do
                {
                    Console.WriteLine("Value of j: {0}", j);
                    j++;
                } while (j < 2);

            } while (i < 2);

        
    
} } }
