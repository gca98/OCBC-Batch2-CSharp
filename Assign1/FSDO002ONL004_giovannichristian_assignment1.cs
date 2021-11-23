using System;

class assignment1
{
    static void Main()
    {

        int pilih = -1;
        do
        {
            switch (pilih)
            {
                case 0:
                    {
                        Console.WriteLine("\n====Thank You====\n");
                        pilih = -2;
                        break;
                    }
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("\t1. Segitiga huruf");
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
                        pilih = 99;
                        break;
                    }
                case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("\t2. Segitiga angka");
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
                                if (m<0)
                                {
                                    m = 8;
                                }
                                Console.Write(angka[m]);
                                m--;
                            }
                            Console.WriteLine();
                            m = 0;
                        }
                        pilih = 99;
                        break;
                    }
                case 3:
                    {
                        Console.Clear();
                        Console.WriteLine("\t3. Faktorial");
                        Console.Write("Enter any Number : ");
                        int isi = 0;
                        isi = int.Parse(Console.ReadLine());
                        long total = 1;
                        for (int i = isi; i > 0; i--)
                        {
                            total = total * i;
                        }
                        Console.WriteLine($"Factorial of {isi} is : {total}");
                        pilih = 99;
                        break;
                    }
                case 4:
                    {
                        Console.Clear();
                        Console.WriteLine("\t4. Reversed number");
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
                        pilih = 99;
                        break;
                    }
                case 5:
                    {
                        Console.Clear();
                        Console.WriteLine("\t5. convert angka ke huruf");
                        Console.Write("Enter the Number : ");
                        // int num = int.Parse(Console.ReadLine());
                        string num = Console.ReadLine();
                        for (int i = 0; i < num.Length; i++)
                        {
                            if (num[i] == '0') Console.Write("zero ");
                            else if (num[i] == '1') Console.Write("one ");
                            else if (num[i] == '2') Console.Write("two ");
                            else if (num[i] == '3') Console.Write("three ");
                            else if (num[i] == '4') Console.Write("four ");
                            else if (num[i] == '5') Console.Write("five ");
                            else if (num[i] == '6') Console.Write("six ");
                            else if (num[i] == '7') Console.Write("seven ");
                            else if (num[i] == '8') Console.Write("eight ");
                            else if (num[i] == '9') Console.Write("nine ");
                        }

                        Console.WriteLine();
                        pilih = 99;
                        break;
                    }
                case 6:
                    {
                        Console.Clear();
                        Console.WriteLine("\t6. fibonacci");
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
                        Console.WriteLine();
                        pilih = 99;
                        break;
                    }
                case 99:
                    {
                        Console.Write("Kembali ke menu ?[Y/N]");
                        string a = Console.ReadLine();
                        if (a == "Y" || a == "y")
                        {
                            pilih = -1;
                        }
                        else if (a == "N" || a == "n")
                        {
                            pilih = 0;
                        }
                        else
                        {
                            Console.WriteLine("Tidak ada dalam pilihan");
                        }
                        break;
                    }

                default:
                    {
                        Console.Clear();
                        Console.Write("Selamat Datang di assigment 1 \n \n Nama Lengkap saya : Giovanni Christian \n Nomer Peserra : FSDO002ONL004 \n Alamat : Surabaya\n\n");
                        Console.WriteLine("\n====MENU SOAL===");
                        Console.WriteLine("1. Segitiga huruf");
                        Console.WriteLine("2. Segitiga angka");
                        Console.WriteLine("3. Faktorial");
                        Console.WriteLine("4. Reversed number");
                        Console.WriteLine("5. convert angka ke huruf");
                        Console.WriteLine("6. fibonacci");
                        Console.WriteLine("0. EXIT");
                        Console.Write(":");
                        pilih = int.Parse(Console.ReadLine());
                        break;
                    }
            }
        } while (pilih != -2);



    }
}