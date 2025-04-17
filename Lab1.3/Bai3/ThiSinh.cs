 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    abstract class ThiSinh
    {
        public string SoBaoDanh { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string UuTien { get; set; }

        public ThiSinh(string soBaoDanh, string hoTen, string diaChi, string uuTien)
        {
            SoBaoDanh = soBaoDanh;
            HoTen = hoTen;
            DiaChi = diaChi;
            UuTien = uuTien;
        }

        public abstract double TinhTongDiem();
        public abstract string LayKhoi();

        public virtual void HienThiThongTin()
        {
            Console.WriteLine($"SBD: {SoBaoDanh}, Ho Ten: {HoTen}, Dia Chi: {DiaChi}, Uu Tien: {UuTien}, Khoi: {LayKhoi()}, Tong Diem: {TinhTongDiem()}");
        }
    }

    class ThiSinhKhoiA : ThiSinh
    {
        public double Toan, Ly, Hoa;

        public ThiSinhKhoiA(string sbd, string hoTen, string diaChi, string uuTien, double toan, double ly, double hoa)
            : base(sbd, hoTen, diaChi, uuTien)
        {
            Toan = toan;
            Ly = ly;
            Hoa = hoa;
        }

        public override double TinhTongDiem()
        {
            return Toan + Ly + Hoa;
        }

        public override string LayKhoi()
        {
            return "A";
        }
    }

    class ThiSinhKhoiB : ThiSinh
    {
        public double Toan, Hoa, Sinh;

        public ThiSinhKhoiB(string sbd, string hoTen, string diaChi, string uuTien, double toan, double hoa, double sinh)
            : base(sbd, hoTen, diaChi, uuTien)
        {
            Toan = toan;
            Hoa = hoa;
            Sinh = sinh;
        }

        public override double TinhTongDiem()
        {
            return Toan + Hoa + Sinh;
        }

        public override string LayKhoi()
        {
            return "B";
        }
    }

    class ThiSinhKhoiC : ThiSinh
    {
        public double Van, Su, Dia;

        public ThiSinhKhoiC(string sbd, string hoTen, string diaChi, string uuTien, double van, double su, double dia)
            : base(sbd, hoTen, diaChi, uuTien)
        {
            Van = van;
            Su = su;
            Dia = dia;
        }

        public override double TinhTongDiem()
        {
            return Van + Su + Dia;
        }

        public override string LayKhoi()
        {
            return "C";
        }
    }
}
