using System;

namespace program3
{
    class Program
    {
        static void Main(string[] args)
        {
            pesawat pesawat = new pesawat();
            pesawat_tempur pswttempr = new pesawat_tempur();

            pesawat.nama = "Helly";
            pesawat.JumlahRoda = 3;
            pesawat.ketinggian = "1000 kaki";
            pesawat.JumlahPenumpang = "3 Penumpang";
            pswttempr.nama = "AZ500TPU";
            pswttempr.JumlahRoda = 5;
            pswttempr.ketinggian = "200 kaki";
            pswttempr.JumlahPenumpang = "2 Penumpang plus kopilot dan asistance";

            pesawat.terbang();
            pswttempr.terbangtinggi();
        }
    }
}
