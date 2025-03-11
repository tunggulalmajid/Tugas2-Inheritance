using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3_PBO
{
    internal class Mobil
    {
        public string namaMobil;
        public string merkMobil;
        public string warnaMobil;
        public int jumlahKursi;
        public int tahunKeluar;
        public Mobil(string namaMobil, string merkMobil, string warnaMobil, int jumlahKursi, int tahunKeluar)
        {
            this.namaMobil = namaMobil;
            this.merkMobil = merkMobil;
            this.warnaMobil = warnaMobil;
            this.jumlahKursi = jumlahKursi;
            this.tahunKeluar = tahunKeluar;
        }
        
    }
    class MobilSedan : Mobil
    {
        public string typeSedan;
        public double panjangSedan;
        public double luasBagasiSedan;

        public MobilSedan (string namaMobil, string merkMobil, string warnaMobil, int jumlahKursi, int tahunKeluar, string typeSedan, 
            double panjangSedan, double luasBagasisedan) : base(namaMobil,merkMobil,warnaMobil,jumlahKursi, tahunKeluar) 
        {
            this.namaMobil = namaMobil;
            this.merkMobil = merkMobil;
            this.warnaMobil = warnaMobil;
            this.jumlahKursi = jumlahKursi;
            this.tahunKeluar=tahunKeluar;
            this.typeSedan = typeSedan;
            this.panjangSedan = panjangSedan;
            this.luasBagasiSedan = luasBagasisedan;
        }
        public void tampilkanSedan()
        {
            Console.WriteLine($"Nama Sedan    : {namaMobil} ");
            Console.WriteLine($"Merk Sedan    : {merkMobil} ");
            Console.WriteLine($"Warna Sedan   : {warnaMobil} ");
            Console.WriteLine($"Jumlh Kursi   : {jumlahKursi} ");
            Console.WriteLine($"Tahun Keluar  : {tahunKeluar} ");
            Console.WriteLine($"Tipe Sedan    : {typeSedan} ");
            Console.WriteLine($"Panjang Sedan : {panjangSedan} ");
            Console.WriteLine($"Luas Bagasi   : {luasBagasiSedan} ");

        }
    }
}
