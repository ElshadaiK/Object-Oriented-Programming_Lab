﻿using System;

namespace QuestionNum30
{
    class Program
    {

        public static void Main()
        {
            int[,] arr1 = new int[50, 50];
            int[,] brr1 = new int[50, 50];
            int i, j, r1, c1, r2, c2, flag = 1;

            Console.Write("\n\nAccept two matrices and check whether they are equal :\n ");
            Console.Write("-----------------------------------------------------------\n");

            Console.Write("Input the number of rows in the 1st matrix : ");
            r1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the number of columns in  the 1st matrix : ");
            c1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the number of rows in the 2nd matrix : ");
            r2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the number of columns in  the 2nd matrix : ");
            c2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input elements in the first matrix :\n");
            for (i = 0; i < r1; i++)
            {
                for (j = 0; j < c1; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("Input elements in the second matrix :\n");
            for (i = 0; i < r2; i++)
            {
                for (j = 0; j < c2; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    brr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("The first matrix is :\n");
            for (i = 0; i < r1; i++)
            {
                for (j = 0; j < c1; j++)
                    Console.Write("{0}  ", arr1[i, j]);
                Console.Write("\n");
            }
            Console.Write("The second matrix is :\n");
            for (i = 0; i < r2; i++)
            {
                for (j = 0; j < c2; j++)
                    Console.Write("{0}  ", brr1[i, j]);
                Console.Write("\n");
            }

            /* Comparing two matrices for equality */

            if (r1 != r2 && c1 != c2)
            {
                Console.Write("The Matrices Cannot be compared :\n");
            }
            else
            {
                Console.Write("The Matrices can be compared : \n");
                for (i = 0; i < r1; i++)
                {
                    for (j = 0; j < c2; j++)
                    {
                        if (arr1[i, j] != brr1[i, j])
                        {
                            flag = 0;
                            break;
                        }
                    }
                }
                if (flag == 1)
                    Console.Write("Two matrices are equal.\n\n");
                else
                    Console.Write("But,two matrices are not equal\n\n");
            }
        }
    }
}
