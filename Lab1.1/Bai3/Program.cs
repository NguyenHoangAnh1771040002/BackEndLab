using System.Text;
Console.OutputEncoding = Encoding.UTF8;
//Bài 3: Viết chương trình chuyển đổi nhiệt độ từ độ C sang độ F
//Công thức: F = (C * 9 / 5) + 32
Console.Write("Nhập vào giá trị độ C: ");
double C = double.Parse(Console.ReadLine());
double F = (C * 9 / 5) + 32;
Console.WriteLine($"{C}C = {F}F");
