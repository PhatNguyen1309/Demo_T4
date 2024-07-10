using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001210345_NguyenTanPhat
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;

            string[] names = { "Nguyen", "Tan", "Phat"};

            foreach (string name in names)
            {
                int length = name.Length;
                total += length;

                Console.WriteLine("Tên: " + name + ", Độ dài: " + length);

            }

            Console.WriteLine("Tổng: " + total);

            Console.ReadLine();
        }
    }
}
