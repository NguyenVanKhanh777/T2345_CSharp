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
                if(i % j == 0) // neu i chia het cho j thi
                {
                    check_i = false; // ket luan 0 la so nguyen to
                    break; // thoat khoi vong lap
                }
            }
            if (check_i) // neu gia sư van dung -> i la so nguyen to
                Console.Write("{0}, i");
        }
    }
}
