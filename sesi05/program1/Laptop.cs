using System;

namespace program1
{
    public class Laptop{
        public string merk;
        public int ram;
        public int memory;

        public void chatting(){
            Console.WriteLine("\n{0} sedang chatting", this.merk);
        }

        public void sosmed(){
            Console.WriteLine("\n{0} sedang sosmed", this.merk);
        }
        public void onlineshop(){
            Console.WriteLine("\n{0} sedang online shop", this.merk);
        }
    }
}