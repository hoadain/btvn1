// Họ và tên: nguyễn đình hòa
// Bắt đầu làm bài toán: tính lãi xuất tiền gửi 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btvn1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            Console.Write("Nhập số tiền gửi (VNĐ): ");
            double soTienGui = Convert.ToDouble(Console.ReadLine());
           
            Console.Write("Nhập lãi suất (%): ");
            double laiSuat = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Nhập số năm gửi: ");
            double soNamGui = Convert.ToDouble(Console.ReadLine());

            double laiSuatTienGui = soTienGui * (laiSuat / 100) * soNamGui;
            Console.WriteLine("Số tiền lãi nhận được sau {0} năm là: {1} VNĐ", soNamGui, laiSuatTienGui);
            Console.ReadKey();
        }
    }
}
