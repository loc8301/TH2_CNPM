using System;

class Program
{
    static void Main()
    {
        int number1, number2, sum;

        Console.WriteLine("Nhập số thứ nhất: ");
        number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Nhập số thứ hai: ");
        number2 = Convert.ToInt32(Console.ReadLine());

        sum = number1 + number2;

        Console.WriteLine("Tổng hai số là: " + sum);
    }
}
