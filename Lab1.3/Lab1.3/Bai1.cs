using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._3
{
    internal class Bai1
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }

        public virtual void NhapThongTin()
        {
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhập năm sinh: ");
            NamSinh = int.Parse(Console.ReadLine());

            Console.Write("Nhập giới tính: ");
            GioiTinh = Console.ReadLine();

            Console.Write("Nhập địa chỉ: ");
            DiaChi = Console.ReadLine();
        }

        public virtual void HienThiThongTin()
        {
            Console.WriteLine($"Họ tên: {HoTen}, Năm sinh: {NamSinh}, Giới tính: {GioiTinh}, Địa chỉ: {DiaChi}");
        }
    }
}
