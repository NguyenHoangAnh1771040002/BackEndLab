using System.Text;
Console.OutputEncoding = Encoding.UTF8;
//Bài 6: Viết hàm sắp xếp mảng số thực n phần tử nhập từ bàn phím theo chiều tăng dần.
static void SapXepTangDan(double[] mang)
{
    int n = mang.Length;
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (mang[j] > mang[j + 1])
            {
                double temp = mang[j];
                mang[j] = mang[j + 1];
                mang[j + 1] = temp;
            }
        }
    }
}
Console.Write("Nhập số lượng phần tử n: ");
int n = int.Parse(Console.ReadLine());
double[] mang = new double[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Nhập phần tử thứ {i+1}: ");
    mang[i] = double.Parse(Console.ReadLine());
}

SapXepTangDan(mang);

Console.WriteLine("\nMảng sau khi sắp xếp tăng dần:");
foreach (double so in mang)
{
    Console.Write(so + " ");
}
