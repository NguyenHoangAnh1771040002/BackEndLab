using System.Text;
Console.OutputEncoding = Encoding.UTF8;
//----------------------------------------------------------------------------------------
//Bài 1: Viết chương trình nhập vào tên và tuổi, sau đó in ra màn hình thông báo "Xin chào
//[tên], bạn[tuổi] tuổi!".
Console.Write("Nhập tên: ");
string name = Console.ReadLine();
Console.Write("Nhập tuổi: ");
int age = int.Parse(Console.ReadLine());
Console.WriteLine($"Xin chào {name}, bạn {age} tuổi");
