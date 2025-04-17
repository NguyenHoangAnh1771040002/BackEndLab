//Bài 1: Một đơn vị sản xuất gồm có các cán bộ là công nhân, kỹ sư, nhân viên.
//+ Mỗi cán bộ cần quản lý các thuộc tính: Họ tên, năm sinh, giới tính, địa chỉ
//+ Các công nhân cần quản lý: Bậc(công nhân bậc 3 / 7, bậc 4 / 7...)
//+ Các kỹ sư cần quản lý: Ngành đào tạo
//+ Các nhân viên phục vụ cần quản lý thông tin: công việc
//1. Xây dựng các lớp NhanVien, CongNhan, KySu kế thừa từ lớp CanBo
//2. Xây dựng các phương thức nhập, hiển thị thông tin và kiểm tra về các thuộc tính của các
//lớp.
//3. Xây dựng lớp QLCB cài đặt các phương thức thực hiện các chức sau:
//-Nhập thông tin mới cho cán bộ (Hỏi người dùng muốn nhập cho: công nhân, kỹ sư
//hay nhân viên và nhập đúng thông tin cho đối tượng đó).
//- Tìm kiếm theo họ tên
//- Hiển thị thông tin về danh sách các cán bộ
//- Thoát khỏi chương trình.
using Bai1;

QLCB qlcb = new QLCB();
int chon;

do
{
    Console.WriteLine("\n========== MENU ==========");
    Console.WriteLine("1. Them can bo moi");
    Console.WriteLine("2. Tim kiem theo ho ten");
    Console.WriteLine("3. Hien thi danh sach can bo");
    Console.WriteLine("4. Thoat");
    Console.Write("Chon chuc nang: ");
    chon = int.Parse(Console.ReadLine());

    switch (chon)
    {
        case 1:
            qlcb.NhapThongTinMoi();
            break;
        case 2:
            qlcb.TimKiemTheoHoTen();
            break;
        case 3:
            qlcb.HienThiDanhSach();
            break;
        case 4:
            Console.WriteLine("Thoat chuong trinh.");
            break;
        default:
            Console.WriteLine("Chon sai, vui long thu lai.");
            break;
    }
} while (chon != 4);
