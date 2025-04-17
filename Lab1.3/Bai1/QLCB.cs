using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class QLCB
    {
        private List<CanBo> danhSachCanBo = new List<CanBo>();

        public void NhapThongTinMoi()
        {
            Console.WriteLine("Chon loai can bo can them:");
            Console.WriteLine("1. Cong nhan");
            Console.WriteLine("2. Ky su");
            Console.WriteLine("3. Nhan vien");
            Console.Write("Lua chon cua ban: ");
            int chon = int.Parse(Console.ReadLine());

            CanBo cb;
            switch (chon)
            {
                case 1:
                    cb = new CongNhan();
                    break;
                case 2:
                    cb = new KySu();
                    break;
                case 3:
                    cb = new NhanVien();
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    return;
            }

            cb.Nhap();
            danhSachCanBo.Add(cb);
            Console.WriteLine("Da them can bo thanh cong.\n");
        }

        public void TimKiemTheoHoTen()
        {
            Console.Write("Nhap ho ten can tim: ");
            string hoTen = Console.ReadLine();

            bool found = false;
            foreach (var cb in danhSachCanBo)
            {
                if (cb.HoTen.Equals(hoTen, StringComparison.OrdinalIgnoreCase))
                {
                    cb.HienThi();
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Khong tim thay can bo nao voi ten do.\n");
            }
        }

        public void HienThiDanhSach()
        {
            Console.WriteLine("\n--- Danh sach can bo ---");
            foreach (var cb in danhSachCanBo)
            {
                cb.HienThi();
                Console.WriteLine("----------------------");
            }
        }
    }
}
