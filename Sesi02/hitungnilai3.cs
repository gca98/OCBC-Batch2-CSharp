using System;

class hitungnilai3{
    public static void Main(string[] argv){
        int nilai1, nilai2 = 0;

        Console.Write("nilai1: ");
        nilai1 = int.Parse(Console.ReadLine());
        Console.Write("nilai2: ");
        nilai2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Hasil Perbandingan");
        Console.WriteLine($"nilai1 > nilai2 {nilai1 > nilai2}");
        Console.WriteLine($"nilai1 >= nilai2 {nilai1 >= nilai2}");
        Console.WriteLine($"nilai1 < nilai2 {nilai1 < nilai2}");
        Console.WriteLine($"nilai1 <= nilai2 {nilai1 <= nilai2}");
        Console.WriteLine($"nilai1 == nilai2 {nilai1 == nilai2}");
        Console.WriteLine($"nilai1 != nilai2 {nilai1 != nilai2}");

    }
}