using System;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {

            Laptop laptop1 = new Laptop();

            laptop1.merk = "lenovo";
            laptop1.ram = 4;
            laptop1.memory = 128;

            Console.WriteLine("merk laptop adalah {0} ", laptop1.merk);
            Console.WriteLine("kapasitas Ram ada {0} ", laptop1.ram);
            Console.WriteLine("Kapasitas Memory ada {0} ", laptop1.memory);

            laptop1.chatting();
            laptop1.sosmed();
            laptop1.onlineshop();

            Laptop laptop2 = new Laptop();

            Console.Write("Merk Laptop: ");
            laptop2.merk = Console.ReadLine();
            Console.Write("Ram Laptop: ");
            laptop2.ram = int.Parse(Console.ReadLine());
            Console.Write("Memory Laptop: ");
            laptop2.memory = int.Parse(Console.ReadLine());
            Console.WriteLine("\nmerk laptop adalah {0} ", laptop2.merk);
            Console.WriteLine("kapasitas Ram ada {0} ", laptop2.ram);
            Console.WriteLine("Kapasitas Memory ada {0} ", laptop2.memory);
            laptop2.chatting();
            laptop2.sosmed();
            laptop2.onlineshop();
            
        }
    }
}
