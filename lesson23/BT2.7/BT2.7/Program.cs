using System;

class Program
{
    static void Main()
    {
        int soDong = 10; // thay doi so dong neu muon
        for (int i = 1; i < soDong; i++)
        {
            Console.Write(new string(' ',(soDong-i)));
            int num = i;
            // so dong tang dan
            for(int j = 1; j <= i; j++)
            {
                Console.Write(num % 10);
                num++;
            }
            num -=  2;
            // in so giam dan
            for (int j = 1; j < i; j++)
            {
                Console.Write(num % 10);
                num--;
            }
            Console.WriteLine(); //xuong dong
        }
        
    }
}