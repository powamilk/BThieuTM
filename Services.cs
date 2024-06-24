using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HieuTM
{
    public class Services
    {
        private List<SinhVien> danhSachSinhVien = new List<SinhVien>();

        // Nhập danh sách sinh viên
        public void NhapDanhSachSinhVien()
        {
            bool tiepTuc = true;
            while (tiepTuc)
            {
                SinhVien sv = new SinhVien();
                Console.Write("Nhap MaSV: ");
                sv.MaSV = Console.ReadLine();
                Console.Write("Nhap Ten: ");
                sv.Ten = Console.ReadLine();
                Console.Write("Nhap Nam Sinh: ");
                sv.NamSinh = int.Parse(Console.ReadLine());
                Console.Write("Nhap Diem: ");
                sv.Diem = double.Parse(Console.ReadLine());

                danhSachSinhVien.Add(sv);

                Console.Write("Ban co muon nhap tiep (y/n)? ");
                string answer = Console.ReadLine();
                tiepTuc = answer.ToLower() == "y";
            }
        }

        // Xuất danh sách sinh viên
        public void XuatDanhSachSinhVien()
        {
            foreach (var sv in danhSachSinhVien)
            {
                sv.InThongTin();
            }
        }

        // Xuất danh sách sinh viên được tặng vé
        public void XuatSinhVienDuocTangVe()
        {
            foreach (var sv in danhSachSinhVien)
            {
                if (sv.Diem >= 8)
                {
                    sv.InThongTin();
                }
            }
        }

        // Xóa sinh viên không được tham gia
        public void XoaSinhVienKhongDuocThamGia()
        {
            danhSachSinhVien.RemoveAll(sv => DateTime.Now.Year - sv.NamSinh > 25);
        }
    }

}
