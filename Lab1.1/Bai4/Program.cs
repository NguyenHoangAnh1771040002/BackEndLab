using System.Text;
Console.OutputEncoding = Encoding.UTF8;
//Bài 4: Viết chương trình nhập vào một số nguyên và kiểm tra xem số đó có phải là số chẵn
//hay không.
Console.Write("Nhập vào 1 số nguyên bất kì: ");
int number = int.Parse(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine($"{number} là số chẵn");
}
else
{
    Console.WriteLine($"{number} là số lẻ");
}
