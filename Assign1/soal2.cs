using System;

class soal2
{
    static void Main()
    {
        Console.Write("Enter the range : ");
        int[] angka = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int jum = 0;
        jum = int.Parse(Console.ReadLine());
        int m = 0;
        int tengah = 0;
        for (int i = jum; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(" ");
            }
            for (int j1 = jum; j1 > i; j1--)
            {
                Console.Write(angka[m]);
                m++;
                if (m > 8)
                {
                    m = 0;
                }
            }
            if (tengah > 8)
            {
                tengah = 0;
            }
            Console.Write(angka[tengah]);
            tengah++;
            m = tengah;
            m--;
            m--;
            for (int j2 = jum; j2 > i; j2--)
            {
                if (m < 0)
                {
                    m = 8;
                }
                Console.Write(angka[m]);
                m--;
            }
            Console.WriteLine();
            m = 0;
        }
    }
}