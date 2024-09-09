using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using btvn;

namespace btvn
{//
    public class Class1

    {
        public int SoTienGui { get; set; }
        public double LaiSuat { get; set; } // Phần trăm
        public int SoNamGui { get; set; }
        public double LaiSuatTienGui { get; private set; }
        //tinh taon
        public void TinhLaiSuat()
        {
            LaiSuatTienGui = SoTienGui * (LaiSuat / 100) * SoNamGui;
        }

        public void InKetQua()
        {
            Console.WriteLine("Số tiền lãi nhận được sau {0} năm là: {1} VNĐ", SoNamGui, LaiSuatTienGui);
        }
    }
}
