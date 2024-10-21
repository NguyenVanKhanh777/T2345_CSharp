namespace Exercise05_1
{
    /// <summary>
    /// Tạo ứng dụng C# và thực hiện các công việc sau:
    /// - khởi tạo một mảng 1 chiều số nguyên gồm 10 phần tử.
    /// - Tìm phần tử nhỏ nhất của mảng.
    /// - Đảo ngược mảng.
    /// - Sắp xếp mảng tăng hoặc giảm.
    /// - Tìm phần tử là số nguyên tố.
    /// - In ra các số dương liên tiếp nhiều nhất.
    /// - Tính trung bình cộng các phần tử dương.
    /// - Kiểm tra xem mảng có phải chứa các phần tử âm dương, đan xen nhau không ? 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Thực hiện các công việc sau:");
            int[] array = { 1, 3, 5, 7, 11, 13, 12, 24, 26, 54 };

            int chon = 0;
            do
            {
                Menu();
                Console.WriteLine("Mời bạn chọn:");
                chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1:
                        Console.WriteLine("Phần tử nhỏ nhất của mảng là: " + MinArray(array));
                        break;
                    case 2:
                        ReverseArray(array);
                        break;
                    case 3:
                        SortArray(array);
                        break;
                    case 4:
                        FindPrimeNumbers(array);
                        break;
                    case 5:
                        Console.WriteLine("Số lượng các số dương liên tiếp nhiều nhất: " + MaxConsecutivePositive(array));
                        break;
                    case 6:
                        Console.WriteLine("Trung bình cộng các phần tử dương: " + AveragePositive(array));
                        break;
                    case 7:
                        Console.WriteLine("Mảng có chứa các phần tử âm dương đan xen nhau: " + CheckAlternatingSign(array));
                        break;
                    case 8:
                        Console.WriteLine("Kết thúc.");
                        break;
                    default:
                        Console.WriteLine("Bạn chọn sai chức năng!");
                        break;
                }

            } while (chon != 8);
        }

        static void Menu()
        {
            Console.WriteLine("================= MENU ================");
            Console.WriteLine("1. Tìm phần tử nhỏ nhất của mảng");
            Console.WriteLine("2. Đảo ngược mảng");
            Console.WriteLine("3. Sắp xếp mảng tăng dần hoặc giảm dần");
            Console.WriteLine("4. Tìm các phần tử là số nguyên tố");
            Console.WriteLine("5. In ra số lượng các số dương liên tiếp nhiều nhất");
            Console.WriteLine("6. Tính trung bình cộng các phần tử dương");
            Console.WriteLine("7. Kiểm tra xem mảng có chứa các phần tử âm dương đan xen nhau không");
            Console.WriteLine("8. Kết thúc");
        }

        static int MinArray(int[] arr)
        {
            return arr.Min();
        }

        static void ReverseArray(int[] arr)
        {
            Array.Reverse(arr);
            Console.WriteLine("Mảng sau khi đảo ngược: " + string.Join(", ", arr));
        }

        static void SortArray(int[] arr)
        {
            Array.Sort(arr);
            Console.WriteLine("Mảng sau khi sắp xếp tăng dần: " + string.Join(", ", arr));
            Array.Reverse(arr);
            Console.WriteLine("Mảng sau khi sắp xếp giảm dần: " + string.Join(", ", arr));
        }

        static bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        static void FindPrimeNumbers(int[] arr)
        {
            var primes = arr.Where(IsPrime).ToArray();
            Console.WriteLine("Các phần tử là số nguyên tố: " + (primes.Length > 0 ? string.Join(", ", primes) : "Không có số nguyên tố"));
        }

        static int MaxConsecutivePositive(int[] arr)
        {
            int maxCount = 0, currentCount = 0;

            foreach (int num in arr)
            {
                if (num > 0)
                {
                    currentCount++;
                    if (currentCount > maxCount)
                        maxCount = currentCount;
                }
                else
                {
                    currentCount = 0;
                }
            }
            return maxCount;
        }

        static double AveragePositive(int[] arr)
        {
            var positives = arr.Where(n => n > 0).ToArray();
            if (positives.Length == 0) return 0;
            return positives.Average();
        }

        static bool CheckAlternatingSign(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] * arr[i - 1] >= 0) // Kiểm tra nếu hai số liên tiếp không khác dấu
                {
                    return false;
                }
            }
            return true;
        }
    }
}
       

