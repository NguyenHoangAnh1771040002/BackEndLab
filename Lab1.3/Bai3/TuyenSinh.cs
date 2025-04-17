using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class TuyenSinh
    {
        private List<ThiSinh> danhSachThiSinh = new List<ThiSinh>();

        public void NhapThiSinh()
        {
            Console.WriteLine("Nhap so luong thi sinh: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap thong tin thi sinh thu {i + 1}:");
                Console.Write("Nhap khoi (A/B/C): ");
                string khoi = Console.ReadLine().ToUpper();

                Console.Write("So bao danh: ");
                string sbd = Console.ReadLine();
                Console.Write("Ho ten: ");
                string hoTen = Console.ReadLine();
                Console.Write("Dia chi: ");
                string diaChi = Console.ReadLine();
                Console.Write("Uu tien: ");
                string uuTien = Console.ReadLine();

                switch (khoi)
                {
                    case "A":
                        Console.Write("Toan: ");
                        double toanA = double.Parse(Console.ReadLine());
                        Console.Write("Ly: ");
                        double ly = double.Parse(Console.ReadLine());
                        Console.Write("Hoa: ");
                        double hoaA = double.Parse(Console.ReadLine());
                        danhSachThiSinh.Add(new ThiSinhKhoiA(sbd, hoTen, diaChi, uuTien, toanA, ly, hoaA));
                        break;

                    case "B":
                        Console.Write("Toan: ");
                        double toanB = double.Parse(Console.ReadLine());
                        Console.Write("Hoa: ");
                        double hoaB = double.Parse(Console.ReadLine());
                        Console.Write("Sinh: ");
                        double sinh = double.Parse(Console.ReadLine());
                        danhSachThiSinh.Add(new ThiSinhKhoiB(sbd, hoTen, diaChi, uuTien, toanB, hoaB, sinh));
                        break;

                    case "C":
                        Console.Write("Van: ");
                        double van = double.Parse(Console.ReadLine());
                        Console.Write("Su: ");
                        double su = double.Parse(Console.ReadLine());
                        Console.Write("Dia: ");
                        double dia = double.Parse(Console.ReadLine());
                        danhSachThiSinh.Add(new ThiSinhKhoiC(sbd, hoTen, diaChi, uuTien, van, su, dia));
                        break;

                    default:
                        Console.WriteLine("Khoi khong hop le!");
                        break;
                }
            }
        }

        public void HienThiThiSinhTrungTuyen()
        {
            Console.WriteLine("Danh sach thi sinh trung tuyen:");

            foreach (var ts in danhSachThiSinh)
            {
                bool trungTuyen = false;
                double diem = ts.TinhTongDiem();

                if (ts.LayKhoi() == "A" && diem >= 15) trungTuyen = true;
                else if (ts.LayKhoi() == "B" && diem >= 16) trungTuyen = true;
                else if (ts.LayKhoi() == "C" && diem >= 13.5) trungTuyen = true;

                if (trungTuyen)
                    ts.HienThiThongTin();
            }
        }

        public void TimTheoSoBaoDanh()
        {
            Console.Write("Nhap so bao danh can tim: ");
            string sbd = Console.ReadLine();

            var ketQua = danhSachThiSinh.Find(ts => ts.SoBaoDanh == sbd);

            if (ketQua != null)
            {
                Console.WriteLine("Thong tin thi sinh:");
                ketQua.HienThiThongTin();
            }
            else
            {
                Console.WriteLine("Khong tim thay thi sinh co SBD nay.");
            }
        }
    }
}
