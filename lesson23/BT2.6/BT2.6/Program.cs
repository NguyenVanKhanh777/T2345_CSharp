using System;

class Program
{
    static void Main()
    {
        // Số hàng của tam giác
        int height = 6;  // Bạn có thể thay đổi chiều cao của tam giác tùy ý

        for (int i = 1; i <= height; i++)
        {
            // In các dấu cách trước các ký tự sao (để tạo hình tam giác cân)
            for (int j = 1; j <= height - i; j++)
            {
                Console.Write(" ");
            }

            // In các ký tự sao
            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write("*");
            }

            // Xuống dòng sau mỗi hàng
            Console.WriteLine();
        }
    }
}