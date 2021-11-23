using System;

class soal4
{
    static void Main()
    {
        Console.Write("Enter a number : ");
        int num = int.Parse(Console.ReadLine());
        int temp = num;
        int rev = 0;
        while (temp != 0)
        {
            if (temp != num) rev = rev * 10;
            rev = rev + temp % 10;
            temp = temp / 10;
        }
        Console.WriteLine("Reversed number : " + rev);
        Console.ReadLine();
    }
}