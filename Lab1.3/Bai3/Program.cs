//Bài 3: Các thí sinh dự thi đại học bao gồm các thí sinh thi khối A, thí sinh thi khối B, thí sinh
//thi khối C
//+ Các thí sinh cần quản lý các thuộc tính: Số báo danh, họ tên, địa chỉ, ưu tiên.
//+ Thí sinh thi khối A thi các môn: Toán, lý, hoá
//+ Thí sinh thi khối B thi các môn: Toán, Hoá, Sinh
//+ Thí sinh thi khối C thi các môn: Văn, Sử, Địa
//1. Xây dựng các lớp để quản lý các thí sinh sao cho sử dụng lại được nhiều nhất.
//2. Xây dựng lớp TuyenSinh cài đặt các phương thức thực hiện các nhiệm vụ sau:
//-Nhập thông tin về các thí sinh dự thi
//- Hiển thị thông tin về các thí sinh đã trúng tuyển (Giả sử điểm chuẩn cho khối A: 15,
//điểm chuẩn khối B: 16, điểm chuẩn khối C: 13,5).
//-Tìm kiếm các thí sinh theo số báo danh
//- Kết thúc chương trình.
using Bai3;

TuyenSinh tuyenSinh = new TuyenSinh();
bool chay = true;

while (chay)
{
    Console.WriteLine("\nCHUONG TRINH TUYEN SINH");
    Console.WriteLine("1. Nhap thi sinh");
    Console.WriteLine("2. Hien thi thi sinh trung tuyen");
    Console.WriteLine("3. Tim theo so bao danh");
    Console.WriteLine("4. Thoat");
    Console.Write("Chon chuc nang: ");

    int luaChon = int.Parse(Console.ReadLine());

    switch (luaChon)
    {
        case 1:
            tuyenSinh.NhapThiSinh();
            break;
        case 2:
            tuyenSinh.HienThiThiSinhTrungTuyen();
            break;
        case 3:
            tuyenSinh.TimTheoSoBaoDanh();
            break;
        case 4:
            chay = false;
            Console.WriteLine("Ket thuc chuong trinh.");
            break;
        default:
            Console.WriteLine("Lua chon khong hop le.");
            break;
    }
}
