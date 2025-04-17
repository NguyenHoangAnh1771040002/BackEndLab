using System.Text;
Console.OutputEncoding = Encoding.UTF8;
//Bài 1: Viết một hàm để tính tổng của tất cả các số chẵn trong một mảng.
static int TinhTongSoChan(int[] mang)
{
    int tong = 0;
    foreach (int so in mang)
    {
        if (so % 2 == 0)
        {
            tong += so;
        }
    }
    return tong;
}
int[] mangSo = { 1, 2, 3, 4, 5, 6 };
int tongChan = TinhTongSoChan(mangSo);
Console.WriteLine("Tổng các số chẵn trong mảng là: " + tongChan);
