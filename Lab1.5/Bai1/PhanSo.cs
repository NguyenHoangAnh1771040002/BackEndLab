using System;

namespace Lab1._5
{
    public class PhanSo
    {
        public int Tu { get; set; }
        public int Mau { get; set; }

        public PhanSo()
        {
            Tu = 0;
            Mau = 1;
        }

        public PhanSo(int tu, int mau)
        {
            Tu = tu;
            Mau = mau != 0 ? mau : 1;
        }

        public void Nhap()
        {
            Console.Write("Nhập tử số: ");
            Tu = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("Nhập mẫu số (khác 0): ");
                Mau = int.Parse(Console.ReadLine());
            } while (Mau == 0);
        }

        public PhanSo Cong(PhanSo b)
        {
            int tuMoi = this.Tu * b.Mau + b.Tu * this.Mau;
            int mauMoi = this.Mau * b.Mau;
            return RutGon(new PhanSo(tuMoi, mauMoi));
        }

        public static PhanSo RutGon(PhanSo ps)
        {
            int ucln = UCLN(Math.Abs(ps.Tu), Math.Abs(ps.Mau));
            ps.Tu /= ucln;
            ps.Mau /= ucln;
            if (ps.Mau < 0)
            {
                ps.Tu *= -1;
                ps.Mau *= -1;
            }
            return ps;
        }

        private static int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        public override string ToString()
        {
            return $"{Tu}/{Mau}";
        }
    }
}
