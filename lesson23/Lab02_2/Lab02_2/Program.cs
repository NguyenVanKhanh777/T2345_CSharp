﻿using System;

namespace Lab02_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Nhap vao ky tu");
            ch = (char)Console.Read();
            switch (ch)
            {
                case 'a':
                case 'o':
                case 'e':
                case 'u':
                case 'i':
                    Console.WriteLine("{0} la nguyen am.", ch);
                    break;
                default:
                    Console.WriteLine("{0} la phu am", ch);
                    break;
            }
        }
    }
}