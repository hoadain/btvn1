using System;
using System.Collections.Generic;
using System.Text;

namespace tinhlai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tienGoc, laiSuatNam, soNam, tienLai, tongTien;

            // Nhập số tiền gửi ban đầu
            Console.Write("Nhập số tiền gửi ban đầu (VND): ");
            tienGoc = double.Parse(Console.ReadLine());

            // Nhập lãi suất năm
            Console.Write("Nhập lãi suất năm (%): ");
            laiSuatNam = double.Parse(Console.ReadLine()) / 100;

            // Nhập số năm gửi
            Console.Write("Nhập số năm gửi: ");
            soNam = double.Parse(Console.ReadLine());

            // Tính tiền lãi và tổng số tiền sau thời gian gửi
            tienLai = tienGoc * laiSuatNam * soNam;
            tongTien = tienGoc + tienLai;

            // Hiển thị kết quả
            Console.WriteLine("\nSố tiền lãi sau {0} năm: {1:N0} VND", soNam, tienLai);
            Console.WriteLine("Tổng số tiền sau {0} năm: {1:N0} VND", soNam, tongTien);
        }
    }
}
