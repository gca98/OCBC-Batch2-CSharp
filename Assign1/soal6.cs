using System;


class soal6
{
    static void Main()
    {
        int satu = 0, dua = 1, tiga = 0;
        Console.Write("Enter Number: ");
        int jum = int.Parse(Console.ReadLine());
        Console.Write(dua + " ");
        for (int i = 0; i <= jum; i++)
        {
            tiga = satu + dua;
            satu = dua;
            dua = tiga;
            Console.Write(tiga + " ");
        }
    }
}