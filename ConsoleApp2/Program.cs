using System;
using System.Collections.Generic;
using System.Text;
using lib_toan;

namespace ConsoleApp2
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

            // Sử dụng lớp LaiSuatTienGui từ DLL
            LaiSuatTienGui laiSuatTienGui = new LaiSuatTienGui();
            double soTienLai = laiSuatTienGui.TinhLaiSuat(soTienGui, laiSuat, soNamGui);

            Console.WriteLine("Số tiền lãi nhận được sau {0} năm là: {1} VNĐ", soNamGui, soTienLai);
            Console.ReadKey();
        }
    }
}
