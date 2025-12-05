using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mezrab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter one number");
            int n = int.Parse(Console.ReadLine());
            //چون باید کوچک تر از عدد دریافتی باشد
            PMO3(n - 1);
            Console.ReadKey();
        }
        static void PMO3(int n)
        {
            //شرط پایان بازگشت
            if (n<=0)
            return;
            //اگر مضرب 3 بود چاپ کن 
            if (n%3==0)
            Console.WriteLine(n);
            // بازگشت به عدد قبلی
            PMO3(n - 1);
        }
    }
}
