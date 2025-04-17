using System.Text;
Console.OutputEncoding = Encoding.UTF8;
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

// Lớp Công nhân kế thừa từ CanBo
class CongNhan : Bai1
{
    public int Bac { get; set; }

    public override void NhapThongTin()
    {
        base.NhapThongTin();
        Console.Write("Nhập bậc công nhân (1-7): ");
        Bac = int.Parse(Console.ReadLine());
    }

    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine($"Bậc: {Bac}");
    }
}

// Lớp Kỹ sư kế thừa từ CanBo
class KySu : CanBo
{
    public string NganhDaoTao { get; set; }

    public override void NhapThongTin()
    {
        base.NhapThongTin();
        Console.Write("Nhập ngành đào tạo: ");
        NganhDaoTao = Console.ReadLine();
    }

    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine($"Ngành đào tạo: {NganhDaoTao}");
    }
}

// Lớp Nhân viên kế thừa từ CanBo
class NhanVien : CanBo
{
    public string CongViec { get; set; }

    public override void NhapThongTin()
    {
        base.NhapThongTin();
        Console.Write("Nhập công việc: ");
        CongViec = Console.ReadLine();
    }

    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine($"Công việc: {CongViec}");
    }
}

// Lớp quản lý cán bộ
class QLCB
{
    private List<CanBo> danhSachCanBo = new List<CanBo>();

    // Thêm cán bộ mới
    public void ThemCanBo()
    {
        Console.WriteLine("Chọn loại cán bộ để thêm: ");
        Console.WriteLine("1. Công nhân");
        Console.WriteLine("2. Kỹ sư");
        Console.WriteLine("3. Nhân viên");
        Console.Write("Nhập lựa chọn: ");
        int chon = int.Parse(Console.ReadLine());

        CanBo canBoMoi = null;

        switch (chon)
        {
            case 1:
                canBoMoi = new CongNhan();
                break;
            case 2:
                canBoMoi = new KySu();
                break;
            case 3:
                canBoMoi = new NhanVien();
                break;
            default:
                Console.WriteLine("Lựa chọn không hợp lệ!");
                return;
        }

        canBoMoi.NhapThongTin();
        danhSachCanBo.Add(canBoMoi);
        Console.WriteLine("Thêm cán bộ thành công!");
    }

    // Tìm kiếm cán bộ theo họ tên
    public void TimKiemCanBo()
    {
        Console.Write("Nhập họ tên cần tìm: ");
        string hoTen = Console.ReadLine();
        bool found = false;

        foreach (var canBo in danhSachCanBo)
        {
            if (canBo.HoTen.ToLower().Contains(hoTen.ToLower()))
            {
                canBo.HienThiThongTin();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Không tìm thấy cán bộ nào.");
        }
    }

    // Hiển thị danh sách cán bộ
    public void HienThiDanhSach()
    {
        if (danhSachCanBo.Count == 0)
        {
            Console.WriteLine("Danh sách trống.");
            return;
        }

        Console.WriteLine("\nDanh sách cán bộ:");
        foreach (var canBo in danhSachCanBo)
        {
            canBo.HienThiThongTin();
            Console.WriteLine("--------------------");
        }
    }
}

// Lớp Program để chạy chương trình
class Program
{
    static void Main()
    {
        QLCB quanLyCanBo = new QLCB();
        while (true)
        {
            Console.WriteLine("\n==== QUẢN LÝ CÁN BỘ ====");
            Console.WriteLine("1. Thêm cán bộ");
            Console.WriteLine("2. Tìm kiếm cán bộ");
            Console.WriteLine("3. Hiển thị danh sách cán bộ");
            Console.WriteLine("4. Thoát");
            Console.Write("Nhập lựa chọn: ");
            int luaChon = int.Parse(Console.ReadLine());

            switch (luaChon)
            {
                case 1:
                    quanLyCanBo.ThemCanBo();
                    break;
                case 2:
                    quanLyCanBo.TimKiemCanBo();
                    break;
                case 3:
                    quanLyCanBo.HienThiDanhSach();
                    break;
                case 4:
                    Console.WriteLine("Thoát chương trình.");
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    break;
            }
        }
    }
}

//Bài 2: Một thư viện cần quản lý các tài liệu bao gồm, Sách, Tạp chí, Báo
//+ Mỗi tài liệu có các thuộc tính: Mã tài liệu, Tên nhà xuất bản, Số bản phát hành.
//+ Các loại sách cần quản lý: Tên tác giả, số trang
//+ Các tạp chí cần quản lý: Số phát hành, tháng phát hành
//+ Các báo cần quản lý: ngày phát hành.
//1. Xây dựng các lớp để quản lý các loại tài liệu trên sao cho việc sử dụng lại được nhiều nhất.
//2. Xây dựng lớp QuanLyTailieu cài đặt các phương thức thực hiện các công việc sau:
//-Nhập thông tin về các tài liệu (Hỏi người dùng muốn nhập thông tin cho loại tài liệu
//nào: Sách, Tạp chí hay Báo và nhập đúng thông tin cho loại tài liệu đó).
//- Hiển thị thông tin về các tài liệu
//- Tìm kiếm tài liệu theo loại
//- Thoát khỏi chương trình
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
//Bài 4: Để quản lý các hộ dân trong một khu phố, người ta quản lý các thông tin như sau:
//-Với mỗi hộ dân, có các thuộc tính:
//+Số thành viên trong hộ (số người)
//+ Số nhà của hộ dân đó (số nhà được gắn cho mỗi hộ dân)
//+ Thông tin về mỗi cá nhân trong hộ gia đình.
//- Với mỗi cá nhân, người ta quản lý các thông tin như: số chứng minh nhân dân, họ và
//tên, tuổi, năm sinh, nghề nghiệp.
//1. Hãy xây dựng lớp Nguoi để quản lý thông tin về mỗi cá nhân.
//2. Xây dựng lớp KhuPho để quản lý thông tin về các hộ gia đình.
//3. Viết các phương thức nhập, hiển thị thông tin cho mỗi hộ gia đình.
//4. Cài đặt chương trình thực hiện các công việc sau:
//-Nhập vào một dãy gồm n hộ dân (n - nhập từ bàn phím).
//- Tìm kiếm thông tin về hộ dân theo họ tên hoặc theo số nhà
//- Hiển thị thông tin cho toàn bộ các hộ dân trong khu phố.
//- Thoát khỏi chương trình.
//Bài 5: Để quản lý khách hàng đến thuê phòng của một khách sạn, người ta cần quản lý những
//thông tin sau:
//-Số ngày trọ, loại phòng trọ, giá phòng, và các thông tin cá nhân về mỗi khách trọ.
//- Với mỗi cá nhân, người ta cần quản lý các thông tin : Họ và tên, năm sinh, số chứng
//minh thư nhân dân.
//1. Hãy xây dựng lớp Nguoi để quản lý thông tin cá nhân về mỗi cá nhân.
//2. Xây dựng lớp KhachSan để quản lý các thông tin về khách thuê phòng.
//3. Viết các phương thức : nhập, hiển thị các thông tin về mỗi khách thuê phòng.
//4. Cài đặt chương trình thực hiện các công việc sau:
//-Nhập vào một dãy gồm n khách trọ ( n - nhập từ bàn phím)
//- Hiển thị ra màn hình thông tin về các cá nhân hiện đang trọ ở khách sạn đó.
//- Tìm kiếm thông tin về những khách thuê phòng theo họ và tên.
//- Tính tiền cho khách hàng khi thanh toán trả phòng
//- Thoát khỏi chương trình.

