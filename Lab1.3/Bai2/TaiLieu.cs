using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    abstract class TaiLieu
    {
        public string maTaiLieu;
        public string tenNhaXuatBan;
        public int soBanPhatHanh;

        public abstract void nhapThongTin();
        public abstract void hienThiThongTin();
    }

    class Sach : TaiLieu
    {
        public string tenTacGia;
        public int soTrang;

        public override void nhapThongTin()
        {
            Console.Write("Nhap ma tai lieu: ");
            maTaiLieu = Console.ReadLine();
            Console.Write("Nhap ten nha xuat ban: ");
            tenNhaXuatBan = Console.ReadLine();
            Console.Write("Nhap so ban phat hanh: ");
            soBanPhatHanh = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten tac gia: ");
            tenTacGia = Console.ReadLine();
            Console.Write("Nhap so trang: ");
            soTrang = int.Parse(Console.ReadLine());
        }

        public override void hienThiThongTin()
        {
            Console.WriteLine($"[SACH] Ma: {maTaiLieu}, NXB: {tenNhaXuatBan}, So ban: {soBanPhatHanh}, Tac gia: {tenTacGia}, So trang: {soTrang}");
        }
    }

    class TapChi : TaiLieu
    {
        public int soPhatHanh;
        public int thangPhatHanh;

        public override void nhapThongTin()
        {
            Console.Write("Nhap ma tai lieu: ");
            maTaiLieu = Console.ReadLine();
            Console.Write("Nhap ten nha xuat ban: ");
            tenNhaXuatBan = Console.ReadLine();
            Console.Write("Nhap so ban phat hanh: ");
            soBanPhatHanh = int.Parse(Console.ReadLine());
            Console.Write("Nhap so phat hanh: ");
            soPhatHanh = int.Parse(Console.ReadLine());
            Console.Write("Nhap thang phat hanh: ");
            thangPhatHanh = int.Parse(Console.ReadLine());
        }

        public override void hienThiThongTin()
        {
            Console.WriteLine($"[TAP CHI] Ma: {maTaiLieu}, NXB: {tenNhaXuatBan}, So ban: {soBanPhatHanh}, So phat hanh: {soPhatHanh}, Thang: {thangPhatHanh}");
        }
    }

    class Bao : TaiLieu
    {
        public DateTime ngayPhatHanh;

        public override void nhapThongTin()
        {
            Console.Write("Nhap ma tai lieu: ");
            maTaiLieu = Console.ReadLine();
            Console.Write("Nhap ten nha xuat ban: ");
            tenNhaXuatBan = Console.ReadLine();
            Console.Write("Nhap so ban phat hanh: ");
            soBanPhatHanh = int.Parse(Console.ReadLine());
            Console.Write("Nhap ngay phat hanh (dd/MM/yyyy): ");
            ngayPhatHanh = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        }

        public override void hienThiThongTin()
        {
            Console.WriteLine($"[BAO] Ma: {maTaiLieu}, NXB: {tenNhaXuatBan}, So ban: {soBanPhatHanh}, Ngay PH: {ngayPhatHanh.ToString("dd/MM/yyyy")}");
        }
    }
}
