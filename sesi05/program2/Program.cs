using System;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            class_pesawat pesawat = new class_pesawat();
            pesawat.nama = "GARUDAKU";
            // pesawat.ketinggian = "2500 kaki";

             pesawat.terbang();
             pesawat.sudahterbang();
             Console.Read();
        }
    }
}
