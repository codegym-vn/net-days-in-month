using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysInMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            //Khai báo các biến sử dụng trong chương trình
            int month;
            string daysInMonth;

            //Nhập vào tháng 
            Console.Write("Enter a month:");
            month = Int32.Parse(Console.ReadLine());

            //Kiểm tra và hiển thị số ngày trong tháng
            switch (month)
            {
                case 2:
                    daysInMonth = "28 or 29";
                    break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    daysInMonth = "31";
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    daysInMonth = "30";
                    break;
                default:
                    daysInMonth = "";
                    break;
            }

            if (daysInMonth != "")
                Console.WriteLine("The month {0} has {1} days!", month, daysInMonth);
            else
                Console.WriteLine("Invalid input!");

            Console.ReadLine();
        }
    }
}
