using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    internal class Fibonacci
    {
        public void Calculate()
        {
            Console.Write("Please type Fibonacci line max number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int perv = 1;
            int vtor = 1;
            int sum = 0;
            Console.ForegroundColor = ConsoleColor.Green;
            while (number >= sum)
            {
                sum = perv + vtor;
                Console.Write("{0} ", sum);
                perv = vtor;
                vtor = sum;
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
        }
    }

