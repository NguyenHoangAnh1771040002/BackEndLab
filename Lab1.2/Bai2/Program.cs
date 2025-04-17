using System.Text;
Console.OutputEncoding = Encoding.UTF8;
//Bài 2: Viết chương trình nhập vào mảng gồm n phần tử nhập từ bàn phím. Viết hàm để kiểm
//tra xem một số có phải là số nguyên tố hay không, hiển thị chỉ số và giá trị của những phần tử
//là số nguyên tố trong mảng.
static bool LaSoNguyenTo(int n)
{
    if (n < 2)
        return false;

    for (int i = 2; i <= Math.Sqrt(n); i++)
    {
        if (n % i == 0)
            return false;
    }
    return true;
}
Console.Write("Nhập số lượng phần tử n: ");
int n = int.Parse(Console.ReadLine());
int[] mang = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Nhập phần tử thứ {i+1}: ");
    mang[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("\nCác phần tử là số nguyên tố trong mảng:");
for (int i = 0; i < n; i++)
{
    if (LaSoNguyenTo(mang[i]))
    {
        Console.WriteLine($"Chỉ số: {i+1}, Giá trị: {mang[i]}");
    }
}
