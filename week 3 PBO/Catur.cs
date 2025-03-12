//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace week_3_PBO
//{
//    internal class Catur
//    {
//        public string namaBidak;
//        public string warna;
//        public int nilaiBidak;
//        public Catur(string namaBidak,string warna, int nilaiBidak)
//        {
//            this.namaBidak = namaBidak;
//            this.nilaiBidak = nilaiBidak;
//        }
//    }
//    class Pion : Catur
//    {
//        public string PosisiAwal;
//        public string CaraMelangkah;
//        public string PromosiPion;
//        public Pion(string namaBidak, string warna, int nilaiBidak,string PosisiAwal, string CaraMelangkah, string PromosiPion) :
//            base(namaBidak, warna, nilaiBidak)
//        {
//            this.namaBidak=namaBidak;
//            this.warna=warna;
//            this.nilaiBidak=nilaiBidak;
//            this.PosisiAwal = PosisiAwal;
//            this.CaraMelangkah = CaraMelangkah;
//            this.PromosiPion = PromosiPion;
//        }
//        public void InfoPion()
//        {
//            Console.WriteLine($"Nama Bidak     : {namaBidak}");
//            Console.WriteLine($"Warna Bidak    : {warna}");
//            Console.WriteLine($"Nilai Bidak    : {nilaiBidak}");
//            Console.WriteLine($"Posisi Awal    : {PosisiAwal}");
//            Console.WriteLine($"Cara Melangkah : {CaraMelangkah}");
//            Console.WriteLine($"Promosi Pion   : {PromosiPion}");
//            Console.WriteLine("");
//        }
//    }
//    class Benteng : Catur
//    {
//        public string PosisiAwal;
//        public string CaraMelangkah;
//        public Benteng(string namaBidak, string warna, int nilaiBidak, string PosisiAwal, string CaraMelangkah) :
//            base(namaBidak, warna, nilaiBidak)
//        {
//            this.namaBidak = namaBidak;
//            this.warna = warna;
//            this.nilaiBidak = nilaiBidak;
//            this.PosisiAwal = PosisiAwal;
//            this.CaraMelangkah = CaraMelangkah;
           
//        }
//        public void InfoBenteng()
//        {
//            Console.WriteLine($"Nama Bidak     : {namaBidak}");
//            Console.WriteLine($"Warna Bidak    : {warna}");
//            Console.WriteLine($"Nilai Bidak    : {nilaiBidak}");
//            Console.WriteLine($"Posisi Awal    : {PosisiAwal}");
//            Console.WriteLine($"Cara Melangkah : {CaraMelangkah}");
//            Console.WriteLine("");
//        }
//    }
//    class Kuda: Catur
//    {
//        public string PosisiAwal;
//        public string CaraMelangkah;
//        public Kuda(string namaBidak, string warna, int nilaiBidak, string PosisiAwal, string CaraMelangkah) :
//            base(namaBidak, warna, nilaiBidak)
//        {
//            this.namaBidak = namaBidak;
//            this.warna=warna;
//            this.nilaiBidak = nilaiBidak;
//            this.PosisiAwal = PosisiAwal;
//            this.CaraMelangkah = CaraMelangkah;

//        }
//        public void InfoKuda()
//        {
//            Console.WriteLine($"Nama Bidak     : {namaBidak}");
//            Console.WriteLine($"Warna Bidak    : {warna}");
//            Console.WriteLine($"Nilai Bidak    : {nilaiBidak}");
//            Console.WriteLine($"Posisi Awal    : {PosisiAwal}");
//            Console.WriteLine($"Cara Melangkah : {CaraMelangkah}");
//            Console.WriteLine("");
//        }
//    }
//    class Gajah : Catur
//    {
//        public string PosisiAwal;
//        public string PetakGajah;
//        public string CaraMelangkah;
//        public Gajah(string namaBidak, string warna, int nilaiBidak, string PosisiAwal,string PetakGajah, string CaraMelangkah) :
//            base(namaBidak, warna, nilaiBidak)
//        {
//            this.namaBidak = namaBidak;
//            this.warna = warna;
//            this.nilaiBidak = nilaiBidak;
//            this.PosisiAwal = PosisiAwal;
//            this.PetakGajah = PetakGajah;
//            this.CaraMelangkah = CaraMelangkah;

//        }
//        public void InfoGajah()
//        {
//            Console.WriteLine($"Nama Bidak     : {namaBidak}");
//            Console.WriteLine($"Warna Bidak    : {warna}");
//            Console.WriteLine($"Nilai Bidak    : {nilaiBidak}");
//            Console.WriteLine($"Posisi Awal    : {PosisiAwal}");
//            Console.WriteLine($"Petak Gajah    : {PetakGajah}");
//            Console.WriteLine($"Cara Melangkah : {CaraMelangkah}");
//            Console.WriteLine("");
//        }
//    }
//    class Menteri : Catur
//    {
//        public string PosisiAwal;
//        public string CaraMelangkah;
//        public Menteri(string namaBidak, string warna, int nilaiBidak, string PosisiAwal, string CaraMelangkah) :
//            base(namaBidak, warna, nilaiBidak)
//        {
//            this.namaBidak = namaBidak;
//            this.warna=warna;
//            this.nilaiBidak = nilaiBidak;
//            this.PosisiAwal = PosisiAwal;
//            this.CaraMelangkah = CaraMelangkah;

//        }
//        public void InfoMentri()
//        {
//            Console.WriteLine($"Nama Bidak     : {namaBidak}");
//            Console.WriteLine($"Warna Bidak    : {warna}");
//            Console.WriteLine($"Nilai Bidak    : {nilaiBidak}");
//            Console.WriteLine($"Posisi Awal    : {PosisiAwal}");
//            Console.WriteLine($"Cara Melangkah : {CaraMelangkah}");
//            Console.WriteLine("");
//        }
//    }
//    class Raja : Catur
//    {
//        public string PosisiAwal;
//        public string CaraMelangkah;
//        public string peranRaja;
//        public Raja(string namaBidak, string warna, int nilaiBidak, string PosisiAwal, string CaraMelangkah, string peranRaja) :
//            base(namaBidak, warna, nilaiBidak)
//        {
//            this.namaBidak = namaBidak;
//            this.warna=warna;
//            this.nilaiBidak = nilaiBidak;
//            this.PosisiAwal = PosisiAwal;
//            this.CaraMelangkah = CaraMelangkah;
//            this.peranRaja = peranRaja;

//        }
//        public void InfoRaja()
//        {
//            Console.WriteLine($"Nama Bidak     : {namaBidak}");
//            Console.WriteLine($"Warna Bidak    : {warna}");
//            Console.WriteLine($"Nilai Bidak    : {nilaiBidak}");
//            Console.WriteLine($"Posisi Awal    : {PosisiAwal}");
//            Console.WriteLine($"Cara Melangkah : {CaraMelangkah}");
//            Console.WriteLine($"Peran Raja     : {peranRaja}");
//            Console.WriteLine("");

//        }
//    }
//}


