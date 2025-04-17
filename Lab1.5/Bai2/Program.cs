//Bài 2: Xây dựng chương trình tính chu vi và diện tích hình tròn, vuông, tam giác, chữ nhật
//Gợi ý:
//-Tạo một lớp “Hinh” có phương thức ảo tính chu vi, diện tích
//- Tạo các lớp: “HinhTron”, “HinhVuong”, “HinhTamGiac”, “HinhChuNhat” kế thừa
//từ class “Hinh” và định nghĩa các hàm tính chu vi, diện tích
//- Tạo List chỉ các Hinh. Tính tổng chu vi và tổng diện tích các hình trong List
using HinhHoc;
Console.OutputEncoding = System.Text.Encoding.UTF8;
List<Hinh> danhSachHinh = new List<Hinh>();

// Them mot so hinh minh hoa
danhSachHinh.Add(new HinhTron(5));
danhSachHinh.Add(new HinhVuong(4));
danhSachHinh.Add(new HinhChuNhat(3, 7));
danhSachHinh.Add(new HinhTamGiac(3, 4, 5));

double tongChuVi = 0;
double tongDienTich = 0;

Console.WriteLine("DANH SÁCH CÁC HÌNH:");
foreach (var hinh in danhSachHinh)
{
    hinh.HienThi();
    tongChuVi += hinh.TinhChuVi();
    tongDienTich += hinh.TinhDienTich();
}

Console.WriteLine($"\nTổng chu vi các hình: {tongChuVi:F2}");
Console.WriteLine($"Tổng diện tích các hình: {tongDienTich:F2}");
