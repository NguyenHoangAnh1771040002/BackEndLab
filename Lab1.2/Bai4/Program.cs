using System.Text;
Console.OutputEncoding = Encoding.UTF8;
//Bài 4: Viết hàm để tìm số lớn thứ hai trong một mảng các số nguyên.
static int TimSoLonThuHai(int[] mang)
{
    if (mang.Length < 2)
    {
        throw new ArgumentException("Mảng phải có ít nhất 2 phần tử.");
    }

    int max1 = int.MinValue;
    int max2 = int.MinValue;

    foreach (int so in mang)
    {
        if (so > max1)
        {
            max2 = max1;
            max1 = so;
        }
        else if (so > max2 && so != max1)
        {
            max2 = so;
        }
    }

    if (max2 == int.MinValue)
    {
        throw new Exception("Không tồn tại số lớn thứ hai (có thể tất cả phần tử bằng nhau).");
    }

    return max2;
}
int[] mang = { 10, 5, 7, 20, 20, 3 };

try
{
    int soLonThuHai = TimSoLonThuHai(mang);
    Console.WriteLine("Số lớn thứ hai trong mảng là: " + soLonThuHai);
}
catch (Exception ex)
{
    Console.WriteLine("Lỗi: " + ex.Message);
}
