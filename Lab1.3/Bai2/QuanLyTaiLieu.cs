using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class QuanLyTaiLieu
    {
        private List<TaiLieu> danhSachTaiLieu = new List<TaiLieu>();

        public void nhapTaiLieu()
        {
            Console.WriteLine("Chon loai tai lieu:");
            Console.WriteLine("1. Sach");
            Console.WriteLine("2. Tap chi");
            Console.WriteLine("3. Bao");

            Console.Write("Lua chon cua ban: ");
            int luaChon = int.Parse(Console.ReadLine());
            TaiLieu taiLieu = null;

            switch (luaChon)
            {
                case 1:
                    taiLieu = new Sach();
                    break;
                case 2:
                    taiLieu = new TapChi();
                    break;
                case 3:
                    taiLieu = new Bao();
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le.");
                    return;
            }

            taiLieu.nhapThongTin();
            danhSachTaiLieu.Add(taiLieu);
        }

        public void hienThiTatCa()
        {
            Console.WriteLine("\n--- DANH SACH TAI LIEU ---");
            foreach (var tl in danhSachTaiLieu)
            {
                tl.hienThiThongTin();
            }
            Console.WriteLine();
        }

        public void timTheoLoai()
        {
            Console.WriteLine("Chon loai can tim:");
            Console.WriteLine("1. Sach");
            Console.WriteLine("2. Tap chi");
            Console.WriteLine("3. Bao");
            Console.Write("Lua chon cua ban: ");
            int loai = int.Parse(Console.ReadLine());

            foreach (var tl in danhSachTaiLieu)
            {
                if ((loai == 1 && tl is Sach) ||
                    (loai == 2 && tl is TapChi) ||
                    (loai == 3 && tl is Bao))
                {
                    tl.hienThiThongTin();
                }
            }
        }

        public void menu()
        {
            while (true)
            {
                Console.WriteLine("\n====== QUAN LY TAI LIEU ======");
                Console.WriteLine("1. Nhap tai lieu");
                Console.WriteLine("2. Hien thi tai lieu");
                Console.WriteLine("3. Tim kiem tai lieu theo loai");
                Console.WriteLine("4. Thoat");
                Console.Write("Chon chuc nang: ");

                int chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        nhapTaiLieu();
                        break;
                    case 2:
                        hienThiTatCa();
                        break;
                    case 3:
                        timTheoLoai();
                        break;
                    case 4:
                        Console.WriteLine("Thoat chuong trinh.");
                        return;
                    default:
                        Console.WriteLine("Lua chon khong hop le.");
                        break;
                }
            }
        }
    }
}
