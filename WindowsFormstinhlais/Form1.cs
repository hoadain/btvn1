using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormstinhlais
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double tienGoc = double.Parse(textBox1.Text);      
                double laiSuatNam = double.Parse(textBox2.Text);   
                double soNam = double.Parse(textBox3.Text);        

                Calculator calculator = new Calculator();

                double tienLai = calculator.TinhTienLai(tienGoc, laiSuatNam, soNam);
                double tongTien = calculator.TinhTongTien(tienGoc, tienLai);
                lblTienLai.Text = $"Số tiền lãi sau {soNam} năm: {tienLai:N0} VND";
                lblTongTien.Text = $"Tổng số tiền sau {soNam} năm: {tongTien:N0} VND";
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi khi nhập sai
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    // Lớp Calculator để tính toán   
    public class Calculator
    {
        // Phương thức tính tiền lãi
        public double TinhTienLai(double tienGoc, double laiSuatNam, double soNam)
        {
            return tienGoc * laiSuatNam / 100 * soNam;
        }

        // Phương thức tính tổng tiền sau khi có lãi
        public double TinhTongTien(double tienGoc, double tienLai)
        {
            return tienGoc + tienLai;
        }
    }
}
    
