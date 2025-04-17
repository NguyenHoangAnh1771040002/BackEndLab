using System.Text;
Console.OutputEncoding = Encoding.UTF8;
//Bài 3: Viết một hàm để đếm số lượng số âm và số dương trong một mảng gồm n phần tử nhập
//từ bàn phím.
static void DemSoAmVaSoDuong(int[] mang, out int soAm, out int soDuong, out int so0)
{
    soAm = 0;
    soDuong = 0;
    so0 = 0;

    foreach (int so in mang)
    {
        if (so < 0)
            soAm++;
        else if (so > 0)
            soDuong++;
        else
            so0++;
    }
}

Console.Write("Nhập số lượng phần tử n: ");
int n = int.Parse(Console.ReadLine());
int[] mang = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Nhập phần tử thứ {i+1}: ");
    mang[i] = int.Parse(Console.ReadLine());
}

DemSoAmVaSoDuong(mang, out int soAm, out int soDuong, out int so0);

Console.WriteLine($"\nSố lượng số âm: {soAm}");
Console.WriteLine($"Số lượng số dương: {soDuong}");
Console.WriteLine($"Số lượng số 0: {so0}");
