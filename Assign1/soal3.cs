using System;

class soal3
{
    static void Main()
    {
        Console.Write("Enter any Number : ");
        int isi = 0;
        isi = int.Parse(Console.ReadLine());
        int total = 1;
        for (int i = isi; i > 0 ; i--)
        {
            total = total * i;
        }
        Console.WriteLine($"Factorial of {isi} is : {total}");
    }
}