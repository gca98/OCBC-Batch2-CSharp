using System;

class soal1
{
    static void Main()
    {
        char[] huruf = new char[26] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        Console.Write("Enter the range : ");
        int jum = 0;
        jum = int.Parse(Console.ReadLine());
        int m = 0;
        for (int i = jum; i > 0; i--)
        {
            //segitiga space
            for (int j = 0; j < i; j++)
            {
                Console.Write(" ");
            }
            //segitiga1 (kiri)
            for (int j1 = jum; j1 > i; j1--)
            {
                Console.Write(huruf[m]);
                m++;
            }
            //segitiga2 (tengah sampai habis)
            for (int j2 = jum + 1; j2 > i; j2--)
            {
                Console.Write(huruf[m]);
                m--;
            }
            Console.WriteLine();
            m = 0;
        }
    }
}