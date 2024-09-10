using System;
using System.Collections.Generic;
using System.Text;
using lib_toan1;


namespace ConsoleApp1
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
            laiSuatNam = double.Parse(Console.ReadLine());

            // Nhập số năm gửi
            Console.Write("Nhập số năm gửi: ");
            soNam = double.Parse(Console.ReadLine());

            // Sử dụng lớp từ DLL
            Class1 calculator = new Class1();

            // Tính tiền lãi và tổng số tiền sau thời gian gửi
            tienLai = calculator.TinhTienLai(tienGoc, laiSuatNam, soNam);
            tongTien = calculator.TinhTongTien(tienGoc, tienLai);

            // Hiển thị kết quả
            Console.WriteLine("\nSố tiền lãi sau {0} năm: {1:N0} VND", soNam, tienLai);
            Console.WriteLine("Tổng số tiền sau {0} năm: {1:N0} VND", soNam, tongTien);
        }
    }
}
