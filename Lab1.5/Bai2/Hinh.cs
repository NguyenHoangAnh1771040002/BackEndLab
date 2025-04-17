using System;

namespace HinhHoc
{
    abstract class Hinh
    {
        public abstract double TinhChuVi();
        public abstract double TinhDienTich();
        public abstract void HienThi();
    }
    class HinhTron : Hinh
    {
        public double BanKinh { get; set; }

        public HinhTron(double banKinh)
        {
            BanKinh = banKinh;
        }

        public override double TinhChuVi()
        {
            return 2 * Math.PI * BanKinh;
        }

        public override double TinhDienTich()
        {
            return Math.PI * BanKinh * BanKinh;
        }

        public override void HienThi()
        {
            Console.WriteLine($"Hình tròn - Bán kính: {BanKinh}, Chu vi: {TinhChuVi():F2}, Diện tích: {TinhDienTich():F2}");
        }
    }

    class HinhVuong : Hinh
    {
        public double Canh { get; set; }

        public HinhVuong(double canh)
        {
            Canh = canh;
        }

        public override double TinhChuVi()
        {
            return 4 * Canh;
        }

        public override double TinhDienTich()
        {
            return Canh * Canh;
        }

        public override void HienThi()
        {
            Console.WriteLine($"Hình Vuông - Cạnh: {Canh}, Chu vi: {TinhChuVi():F2}, Diện tích: {TinhDienTich():F2}");
        }
    }

    class HinhChuNhat : Hinh
    {
        public double ChieuDai { get; set; }
        public double ChieuRong { get; set; }

        public HinhChuNhat(double dai, double rong)
        {
            ChieuDai = dai;
            ChieuRong = rong;
        }

        public override double TinhChuVi()
        {
            return 2 * (ChieuDai + ChieuRong);
        }

        public override double TinhDienTich()
        {
            return ChieuDai * ChieuRong;
        }

        public override void HienThi()
        {
            Console.WriteLine($"Hình chữ nhật - Dài: {ChieuDai}, Rộng: {ChieuRong}, Chu vi: {TinhChuVi():F2}, Diện tích: {TinhDienTich():F2}");
        }
    }

    class HinhTamGiac : Hinh
    {
        public double A, B, C;

        public HinhTamGiac(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double TinhChuVi()
        {
            return A + B + C;
        }

        public override double TinhDienTich()
        {
            double p = TinhChuVi() / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public override void HienThi()
        {
            Console.WriteLine($"Hình tam giác - Cạnh a: {A}, b: {B}, c: {C}, Chu vi: {TinhChuVi():F2}, Diện tích: {TinhDienTich():F2}");
        }
    }

}
