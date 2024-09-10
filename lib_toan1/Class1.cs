using System;
using System.Collections.Generic;
using System.Text;

namespace lib_toan1
{
    public class Class1
    {
        public double TinhTienLai(double tienGoc, double laiSuatNam, double soNam)
        {
            double laiSuatThucTe = laiSuatNam / 100;
            return tienGoc * laiSuatThucTe * soNam;
        }
        public double TinhTongTien(double tienGoc, double tienLai)
        {
            return tienGoc + tienLai;
        }
    }
}
