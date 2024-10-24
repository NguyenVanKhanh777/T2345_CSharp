namespace Lab07_4
{
    public class InvalidInputNumber : Exception
    {
        //public InvalidInputNumber()
        //{
        //    : base("Hay nhap 1 day so > 0") { }
        //}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int intCnt;
            int intNum = 0;
            Console.Write("Nhap 1 so: ");
            // nhap va tung ngoai le
            try
            {
                intNum = Convert.ToInt32(Console.ReadLine());
                if (intNum <= 0)
                {
                    throw new InvalidInputNumber();
                }
            }
            catch (InvalidInputNumber objInvalidInput)
            {
                Console.WriteLine(objInvalidInput.Message);
            }
            catch (System.Exception objFormatException)
            {
                Console.WriteLine(objFormatException.Message);

            }
            finally
            {
                if (intNum > 0)
                {
                    // in ra day so *100
                    for (intCnt = 1; intCnt <= 100; intCnt++) ;
                    Console.WriteLine(intCnt * intNum);
                }
            }
        }
    }
}