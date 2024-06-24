using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HieuTM
{
    public class SinhVien
    {
       
        private string maSV;
        private string ten;
        private int namSinh;
        private double diem;

        public string MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        public int NamSinh
        {
            get { return namSinh; }
            set { namSinh = value; }
        }

        public double Diem
        {
            get { return diem; }
            set { diem = value; }
        }

        
        public SinhVien() { }

        public SinhVien(string maSV, string ten, int namSinh, double diem)
        {
            this.maSV = maSV;
            this.ten = ten;
            this.namSinh = namSinh;
            this.diem = diem;
        }

        // Phương thức in thông tin
        public void InThongTin()
        {
            Console.WriteLine($"MaSV: {maSV}, Ten: {ten}, NamSinh: {namSinh}, Diem: {diem}");
        }
    }

}
