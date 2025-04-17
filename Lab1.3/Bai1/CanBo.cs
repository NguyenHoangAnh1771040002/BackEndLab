using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class CanBo
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }

        public virtual void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap gioi tinh: ");
            GioiTinh = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            DiaChi = Console.ReadLine();
        }

        public virtual void HienThi()
        {
            Console.WriteLine($"Ho ten: {HoTen}, Nam sinh: {NamSinh}, Gioi tinh: {GioiTinh}, Dia chi: {DiaChi}");
        }
    }

    class CongNhan : CanBo
    {
        public string Bac { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap bac (VD: 3/7): ");
            Bac = Console.ReadLine();
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Bac cong nhan: {Bac}");
        }
    }

    class KySu : CanBo
    {
        public string NganhDaoTao { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap nganh dao tao: ");
            NganhDaoTao = Console.ReadLine();
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Nganh dao tao: {NganhDaoTao}");
        }
    }

    class NhanVien : CanBo
    {
        public string CongViec { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap cong viec: ");
            CongViec = Console.ReadLine();
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Cong viec: {CongViec}");
        }
    }
}
