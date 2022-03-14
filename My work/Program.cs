using System;

namespace My_work
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1

            //int n = Convert.ToInt32(Console.ReadLine());
            //int temp = 0;
            //if (n==0||n==1)
            //{
            //    Console.WriteLine("Eded ne sadedir ne murekkeb");
            //    return;
            //}
            //for (int i = 2; i < n / 2; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        temp++;
            //    }
            //}
            //if (temp == 0)
            //{
            //    Console.WriteLine("n is prime");
            //}
            //else
            //{
            //    Console.WriteLine("n is not prime");
            //}
            #endregion

            #region Task 2

            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int x;
            if (n == 0)
            {
                Console.WriteLine(1);
                return;
            }
            while (n > 0 || n < 0)
            {
                x = n % 10;
                count++;
                n = n / 10;
            }
            Console.WriteLine(count);
            #endregion

            #region Task 3

            //int n = Convert.ToInt32(Console.ReadLine());
            //int reverse = 0;
            //int m = n;
            //while (n>0)
            //{
            //    reverse = reverse * 10 + n%10;
            //    n = n / 10;
            //}
            //if (m==reverse)
            //{
            //    Console.WriteLine("eded polindromdur");
            //}
            //else
            //{
            //    Console.WriteLine("eded polindrom deyil");
            //}
            #endregion
        }
    }
}
