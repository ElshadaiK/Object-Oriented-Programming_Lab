﻿using System;

namespace QuestionNum77
{
    class Program
    {

        public static void Main()
        {
            int row, column;

            Console.Write("\n\n");
            Console.Write("Display the pattern like 'T' with an asterisk:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (column == 3 || (row == 0 && column > 0 && column < 6))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
}
