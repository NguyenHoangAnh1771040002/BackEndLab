using System.Text;
Console.OutputEncoding = Encoding.UTF8;
//Bài 5: Viết hàm hoán vị 2 số nguyên a và b nhập từ bàn phím.
static void HoanVi(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}
Console.Write("Nhập số nguyên a: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Nhập số nguyên b: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine($"\nTrước khi hoán vị: a = {a}, b = {b}");

HoanVi(ref a, ref b);

Console.WriteLine($"Sau khi hoán vị: a = {a}, b = {b}");

