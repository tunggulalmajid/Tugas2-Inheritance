using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3_PBO
{
    internal class Catur
    {
        public string namaBidak;
        public int nilaiBidak;
        public Catur(string namaBidak, int nilaiBidak)
        {
            this.namaBidak = namaBidak;
            this.nilaiBidak = nilaiBidak;
        }
    }
    class Pion : Catur
    {
        public string PosisiAwal;
        public string CaraMelangkah;
        public string PromosiPion;
        public Pion(string namaBidak, int nilaiBidak,string PosisiAwal, string CaraMelangkah, string PromosiPion) :
            base(namaBidak, nilaiBidak)
        {
            this.namaBidak=namaBidak;
            this.nilaiBidak=nilaiBidak;
            this.PosisiAwal = PosisiAwal;
            this.CaraMelangkah = CaraMelangkah;
            this.PromosiPion = PromosiPion;
        }
        public void InfoPion()
        {
            Console.WriteLine($"Nama Bidak     : {namaBidak}");
            Console.WriteLine($"Nilai Bidak    : {nilaiBidak}");
            Console.WriteLine($"Posisi Awal    : {PosisiAwal}");
            Console.WriteLine($"Cara Melangkah : {CaraMelangkah}");
            Console.WriteLine($"Promosi Pion   : {PromosiPion}");
        }
    }
    class Benteng : Catur
    {
        public string PosisiAwal;
        public string CaraMelangkah;
        public Benteng(string namaBidak, int nilaiBidak, string PosisiAwal, string CaraMelangkah) :
            base(namaBidak, nilaiBidak)
        {
            this.namaBidak = namaBidak;
            this.nilaiBidak = nilaiBidak;
            this.PosisiAwal = PosisiAwal;
            this.CaraMelangkah = CaraMelangkah;
           
        }
        public void InfoBenteng()
        {
            Console.WriteLine($"Nama Bidak     : {namaBidak}");
            Console.WriteLine($"Nilai Bidak    : {nilaiBidak}");
            Console.WriteLine($"Posisi Awal    : {PosisiAwal}");
            Console.WriteLine($"Cara Melangkah : {CaraMelangkah}");
        }
    }
    class Kuda: Catur
    {
        public string PosisiAwal;
        public string CaraMelangkah;
        public Kuda(string namaBidak, int nilaiBidak, string PosisiAwal, string CaraMelangkah) :
            base(namaBidak, nilaiBidak)
        {
            this.namaBidak = namaBidak;
            this.nilaiBidak = nilaiBidak;
            this.PosisiAwal = PosisiAwal;
            this.CaraMelangkah = CaraMelangkah;

        }
        public void InfoKuda()
        {
            Console.WriteLine($"Nama Bidak     : {namaBidak}");
            Console.WriteLine($"Nilai Bidak    : {nilaiBidak}");
            Console.WriteLine($"Posisi Awal    : {PosisiAwal}");
            Console.WriteLine($"Cara Melangkah : {CaraMelangkah}");
        }
    }
    class Gajah : Catur
    {
        public string PosisiAwal;
        public string CaraMelangkah;
        public Gajah(string namaBidak, int nilaiBidak, string PosisiAwal, string CaraMelangkah) :
            base(namaBidak, nilaiBidak)
        {
            this.namaBidak = namaBidak;
            this.nilaiBidak = nilaiBidak;
            this.PosisiAwal = PosisiAwal;
            this.CaraMelangkah = CaraMelangkah;

        }
        public void InfoGajah()
        {
            Console.WriteLine($"Nama Bidak     : {namaBidak}");
            Console.WriteLine($"Nilai Bidak    : {nilaiBidak}");
            Console.WriteLine($"Posisi Awal    : {PosisiAwal}");
            Console.WriteLine($"Cara Melangkah : {CaraMelangkah}");
        }
        class Menteri : Catur
        {
            public string PosisiAwal;
            public string CaraMelangkah;
            public Menteri(string namaBidak, int nilaiBidak, string PosisiAwal, string CaraMelangkah) :
                base(namaBidak, nilaiBidak)
            {
                this.namaBidak = namaBidak;
                this.nilaiBidak = nilaiBidak;
                this.PosisiAwal = PosisiAwal;
                this.CaraMelangkah = CaraMelangkah;

            }
            public void InfoMentri()
            {
                Console.WriteLine($"Nama Bidak     : {namaBidak}");
                Console.WriteLine($"Nilai Bidak    : {nilaiBidak}");
                Console.WriteLine($"Posisi Awal    : {PosisiAwal}");
                Console.WriteLine($"Cara Melangkah : {CaraMelangkah}");
            }
        }
        class Raja : Catur
        {
            public string PosisiAwal;
            public string CaraMelangkah;
            public Raja(string namaBidak, int nilaiBidak, string PosisiAwal, string CaraMelangkah) :
                base(namaBidak, nilaiBidak)
            {
                this.namaBidak = namaBidak;
                this.nilaiBidak = nilaiBidak;
                this.PosisiAwal = PosisiAwal;
                this.CaraMelangkah = CaraMelangkah;

            }
            public void InfoRaja()
            {
                Console.WriteLine($"Nama Bidak     : {namaBidak}");
                Console.WriteLine($"Nilai Bidak    : {nilaiBidak}");
                Console.WriteLine($"Posisi Awal    : {PosisiAwal}");
                Console.WriteLine($"Cara Melangkah : {CaraMelangkah}");
            }
        }
    }

}
