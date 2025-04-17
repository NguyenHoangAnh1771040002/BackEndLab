using System.Text;
Console.OutputEncoding = Encoding.UTF8;
//Bài 5: Viết chương trình tính tổng và tích của hai số nhập từ bàn phím.
Console.Write("Nhập số a: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Nhập số b: ");
double b = double.Parse(Console.ReadLine());
Console.WriteLine($"{a}+{b}={a + b}");
Console.WriteLine($"{a}*{b}={a * b}");
