//Bài 1: Xây dựng chương trình tính tổng các phân số
//Gợi ý:
//-Tạo một lớp “PhanSo” có các thuộc tính là tử số và mẫu số
//- Viết phương thức nhập phân số
//- Viết hàm thực hiện cộng 2 phân số
//- Tạo List chỉ chứa các phân số. Tính tổng các phân số trong List
using Lab1._5;

Console.OutputEncoding = System.Text.Encoding.UTF8;

List<PhanSo> danhSach = new List<PhanSo>();

Console.Write("Nhập số lượng phân số: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
        Console.WriteLine($"\nPhân số thứ {i + 1}:");
        PhanSo ps = new PhanSo();
        ps.Nhap();
        danhSach.Add(ps);
}

PhanSo tong = new PhanSo(0, 1);
foreach (var ps in danhSach)
{
       tong = tong.Cong(ps);
}

Console.WriteLine($"\nTổng các phân số là: {tong}");

