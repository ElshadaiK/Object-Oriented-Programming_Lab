﻿using System;

namespace QuestionNum17
{
    class Program
    {

        public static void Main()
        {
            int i, j, spc, rows, k;

            Console.Write("\n\n");
            Console.Write("Display the pattern like pyramid with repeating a number in same row:\n");
            Console.Write("-----------------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            spc = rows + 4 - 1;
            for (i = 1; i <= rows; i++)
            {
                for (k = spc; k >= 1; k--)
                {
                    Console.Write(" ");
                }

                for (j = 1; j <= i; j++)
                    Console.Write("{0} ", i);
                Console.Write("\n");
                spc--;
            }
        }
    }
}
