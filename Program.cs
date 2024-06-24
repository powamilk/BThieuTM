using HieuTM;

class Program
{
    static void Main(string[] args)
    {
        Services services = new Services();
        bool thoat = false;

        while (!thoat)
        {
            Console.WriteLine("Quan ly sinh vien tham gia HappyBee");
            Console.WriteLine("1. Nhap danh sach sinh vien");
            Console.WriteLine("2. Xuat danh sach sinh vien");
            Console.WriteLine("3. Xuat danh sach sinh vien duoc tang ve");
            Console.WriteLine("4. Xoa sinh vien khong duoc tham gia");
            Console.WriteLine("5. Thoat");
            Console.Write("Chon chuc nang: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    services.NhapDanhSachSinhVien();
                    break;
                case 2:
                    services.XuatDanhSachSinhVien();
                    break;
                case 3:
                    services.XuatSinhVienDuocTangVe();
                    break;
                case 4:
                    services.XoaSinhVienKhongDuocThamGia();
                    break;
                case 5:
                    thoat = true;
                    break;
                default:
                    Console.WriteLine("Chon sai chuc nang, vui long chon lai!");
                    break;
            }
        }
    }
}

