using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace week_3_PBO
{
    internal class Pion
    {
        public string warna;
        public int posisiPetak;
        public void langkah()
        {
            Console.WriteLine("Pion melangkah maju");
        }
    }
    class PionPutih : Pion
    {
        public PionPutih(string warna, int posisiPetak)
        {
            this.warna = warna;
            this.posisiPetak = posisiPetak;
        }
        public void promosiPutih()
        {
            Console.WriteLine("Pion putih promosi ketika di petak 8");
        }
        public int PionPutihMelangkah()
        {
            posisiPetak += 1;
            return posisiPetak;
        }
        public void eliminasiHitam()
        {
            Console.WriteLine("Pion Putih mengeliminasi Bidak Hitam");
        }
        public void infoPionPutih()
        {
            Console.WriteLine($"Pion berwarna : {warna}");
            Console.WriteLine($"Posisi Petak  : {posisiPetak}");
        }
    }
    class PionHitam : Pion
    {
        public PionHitam(string warna, int posisiPetak)
        {
            this.warna = warna;
            this.posisiPetak = posisiPetak;
        }
        public void promosiHitam()
        {
            Console.WriteLine("Pion hitam promosi ketika mencapai petak 1");
        }
        public int PionHitamMelangkah() 
        {
            posisiPetak -= 1;
            return posisiPetak;
        }
        public void eliminasiPutih()
        {
            Console.WriteLine("Pion Hitam mengeliminasi Bidak Putih");
        }
        public void infoPionHitam()
        {
            Console.WriteLine($"Pion berwarna : {warna}");
            Console.WriteLine($"Posisi Petak  : {posisiPetak}");
        }

    }
}
