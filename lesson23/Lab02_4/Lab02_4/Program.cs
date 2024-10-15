namespace Lab02_4
{
    public static void Main( string[] args)
    {
        //khai bao
        bool check_i;
        Console.Write("Danh sach cac so nguyen tu 2-100: ");
        //duyet 2-100
        for ( int i = 2; i <= 100; i++)
        {
            check_i = true; //gia su i la so nguyen to
            for (int j = 2; j <= i; j++) // 
            {
                if(i % j == 0)
                {
                    check_i = false;
                    break;
                }
            }
            if (check_i)
                Console.Write("{0}, i");
        }
    }
}
