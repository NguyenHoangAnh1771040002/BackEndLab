using System.Text;
Console.OutputEncoding = Encoding.UTF8;
//Bài 9: Viết chương trình tính giai thừa của một số nguyên dương n.
Console.Write("Nhập một số nguyên dương n: ");
int n = int.Parse(Console.ReadLine());
long giaiThua = 1;
for (int i = 1; i <= n; i++)
{
    giaiThua *= i;
}
Console.WriteLine($"Giai thừa của {n} là: {giaiThua}");
