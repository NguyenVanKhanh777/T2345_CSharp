﻿namespace Lab02_3
{
    public static void Main(string[] args)
    {
        //khai bao cac bien
        double a, b, c, delta, x1, x2;
        //nhap a,b,c
        Console.Write("a = ");
        // a phai !=0 
        do
        {
            a = Convert.ToInt32(Console.ReadLine());
        }
        while (a == 0);
        Console.Write("b =");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("c =");
        c = Convert.ToInt32(Console.ReadLine());
        // tinh delta
        delta = b * b - 4 * a * c;
        // binh luan
        if (delta < 0)
            Console.Write("phuong trinh vo nghiem");
        else if (delta == 0)
            Console.WriteLine("Phuong trinh co nghiem");
            Console.WriteLine("x1=x2={0}", -b / (2 * a));
        //bien luan
        if (delta < 0)
            Console.Write("Pt vo nghiem");
        else if (delta == 0)
        {
            Console.WriteLine("Phuong trinh co nghiem kep");
            Console.WriteLine("x1=x2={0}", -b / (2 * a));
        }
        else
        {
            Console.WriteLine("Pt co 2 nghiem");
            x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("x1={0}", x1);
            x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("x2={0}", x2);
        }

    }
}