using System.Text;
Console.OutputEncoding = Encoding.UTF8;
//Bài 7: Viết chương trình kiểm tra xem một năm nhập vào có phải là năm nhuận hay không.
//(Năm nhuận là năm chia hết cho 4, trừ các năm chia hết cho 100 nhưng không chia hết cho
//400).
Console.Write("Nhập vào 1 năm: ");
int year = int.Parse(Console.ReadLine());
if (year % 100 == 0 & year % 400 != 0)
{
    Console.WriteLine($"Năm {year} không là năm nhuận");
}
else if (year % 4 != 0)
{
    Console.WriteLine($"Năm {year} không là năm nhuận");
}
else
{
    Console.WriteLine($"Năm {year} là năm nhuận");
}
