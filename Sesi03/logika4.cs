using System;

public class logika4{

    public static void Main(){
        double nilai;
        Console.Write("Nilai : ");
        if(nilai >= 85) Console.WriteLine("Kamu Mendapatkan grade A");
        else if(nilai >= 65) Console.WriteLine("Kamu Mendapatkan grade B");
        else if(nilai >= 45) Console.WriteLine("Kamu Mendapatkan grade C");
        else if(nilai >= 25) Console.WriteLine("Kamu Mendapatkan grade D");

    }
}