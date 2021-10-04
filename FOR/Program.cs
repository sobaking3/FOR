﻿using System;

namespace FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,]mas= { { { 1, 2 }, { 3, 4 } } ,
                          { { 4, 5 }, { 6, 7 } } ,
                          { { 7, 8 }, { 9, 10 } } ,
                          { { 10, 11 }, { 12, 13 } }
                
            };
            int x = mas.GetUpperBound(0); // 3
            int y = mas.GetUpperBound(1); // 1
            int z = mas.GetUpperBound(2); // 1

            Console.Write("{");
            for (int i = 0; i <= x; i++)
            {
                Console.Write("{");
                for (int j = 0; j <= y; j++)
                {
                    Console.Write("{");
                    for (int k = 0; k <= z; k++)
                    {
                        Console.Write(mas[i, j, k]);
                        if (k < z)
                            Console.Write(" , ");
                    }

                    Console.Write("}");
                    if (j < y)
                        Console.Write(" , ");
                }
                Console.Write("}");

                if (i < x)
                    Console.Write(" , ");
            }
            Console.Write("}");
            Console.ReadLine();
        }
    }
}
