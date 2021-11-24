using System;
namespace program3
{
    public class pesawat
    {
        public string nama;
        public string ketinggian;
        public string JumlahPenumpang;
        public int JumlahRoda;
        
        public void terbang()
        {
            Console.WriteLine("Pesawat dengan nama {0}\n"+
            "yang mempunyai jumlah roda{1}"+
            "sedang berada pada ketinggian {2}"+
            "dengan membawa jumlah penumpang sebanyak {3}"+
            "akan meledakan senjata\n", 
            this.nama, 
            this.JumlahRoda,
            this.ketinggian,
            this.JumlahPenumpang);
        }
        public void sudahterbang()
        {
            Console.WriteLine("Pesawat sekarang berada pada ketinggian {0}\n", this.ketinggian);
        }
    }
    class pesawat_tempur : pesawat
    {
        public void terbangtinggi()
        {
            Console.WriteLine("Pesawat tempur dengan nama {0}\n"+
            "yang mempunyai jumlah roda{1}"+
            "sedang berada pada ketinggian {2}"+
            "dengan membawa jumlah penumpang sebanyak {3}"+
            "akan meledakan senjata\n", 
            this.nama, 
            this.JumlahRoda,
            this.ketinggian,
            this.JumlahPenumpang);
        }
    }
}