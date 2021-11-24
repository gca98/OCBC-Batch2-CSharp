using System;
namespace program4
{
    public class data
    {
        public string nama;
        public double nomer_telepon;
        public void print(string nama){
            this.nama = nama;
            Console.WriteLine("Namanya adalah : {0}", this.nama);
        }
        public void print(double nomer_telepon){
            this.nomer_telepon = nomer_telepon;
            Console.WriteLine("nomer HP : {0}", this.nomer_telepon);
        }
    }
}