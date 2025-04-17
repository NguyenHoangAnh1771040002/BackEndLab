using System.Text;
Console.OutputEncoding = Encoding.UTF8;
//Bài 6: Viết chương trình kiểm tra xem một số nhập vào có phải là số dương, số âm hay số
//không.
Console.Write("Nhập vào số bất kì: ");
double number = double.Parse(Console.ReadLine());
if (number < 0)
{
    Console.WriteLine($"{number} là số âm");
}
else if (number > 0)
{
    Console.WriteLine($"{number} là số dương");
}
else
{
    Console.WriteLine($"{number} là số 0");
}
