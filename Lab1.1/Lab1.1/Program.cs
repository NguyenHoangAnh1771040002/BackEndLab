﻿using System.Text;
Console.OutputEncoding = Encoding.UTF8;
//Bài 10: Viết chương trình kiểm tra xem một số có phải là số nguyên tố hay không.
Console.Write("Nhập một số nguyên: ");
int n = int.Parse(Console.ReadLine());
bool laSoNguyenTo = true;
if (n < 2)
{
    laSoNguyenTo = false;
}
else
{
    for (int i = 2; i <= Math.Sqrt(n); i++)
    {
        if (n % i == 0)
        {
            laSoNguyenTo = false;
            break;
        }
    }
}
if (laSoNguyenTo)
    Console.WriteLine($"{n} là số nguyên tố.");
else
    Console.WriteLine($"{n} không phải là số nguyên tố.");

