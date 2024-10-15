namespace Lab02_5
{
    public static void Main( string[] args)
    {
        // khai bao

        int sum = 0;
        // duyet
        for(int i = 1; i <100; i++)
        {
            if(i % 2 == 0 && i % 3 != 0)
            {
                sum += 1;
            }
        }
        //in kq
        Console.WriteLine("Tong cac so chan chia het cho 3 tu 1-100 la {0}",sum)
    }
}
