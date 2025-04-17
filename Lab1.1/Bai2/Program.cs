using System.Text;
Console.OutputEncoding = Encoding.UTF8;
//----------------------------------------------------------------------------------------
//Bài 2: Viết chương trình tính diện tích của hình chữ nhật khi người dùng nhập chiều dài và
//chiều rộng.
Console.Write("Nhập chiều dài: ");
double cd = double.Parse(Console.ReadLine());
Console.Write("Nhập chiều rộng: ");
double cr = double.Parse(Console.ReadLine());
Console.WriteLine($"Diện tích của hình chữ nhật là: {cd * cr}");
