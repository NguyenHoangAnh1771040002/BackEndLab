using System.Text;
Console.OutputEncoding = Encoding.UTF8;
//Bài 8: Viết chương trình in ra bảng cửu chương từ 1 đến 10.
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Bảng cửu chương {i}:");
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}
