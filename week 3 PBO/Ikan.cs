﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3_PBO
{
    internal class ikan
    {
        public string namaIkan;
        public string namaIlmiah;
        public string warnaIkan;
        public string tempatHidup;
        public ikan(string namaIkan, string namaIlmiah, string warnaIkan, string tempatHidup)
        {
            this.namaIkan = namaIkan;
            this.namaIlmiah = namaIlmiah;
            this.warnaIkan = warnaIkan;
            this.tempatHidup = tempatHidup;
        }
    }
    class IkanAirAsin : ikan
    {
        public string asalIkan;
        public string suhuTempatHidup;
        public string makanan;
        public IkanAirAsin(string namaIkan, string namaIlmiah, string warnaIkan,string tempatHidup, string asalIkan, string suhuTempatHidup, string makanan) 
            : base(namaIkan, namaIlmiah, warnaIkan, tempatHidup)
        {
            this.namaIkan = namaIkan;
            this.namaIlmiah = namaIlmiah;
            this.warnaIkan = warnaIkan;
            this.tempatHidup = tempatHidup;
            this.asalIkan = asalIkan;
            this.suhuTempatHidup=suhuTempatHidup;
            this.makanan = makanan;
        }
        public void InfoIkan()
        {
            Console.WriteLine($"Nama Ikan             : {namaIkan}");
            Console.WriteLine($"Nama Ilmiah           : {namaIlmiah}");
            Console.WriteLine($"Warna Ikan            : {warnaIkan}");
            Console.WriteLine($"Tempat Hidup Ikan     : {tempatHidup}");
            Console.WriteLine($"Asal Ikan             : {asalIkan}");
            Console.WriteLine($"SuhuTempat Hidup Ikan : {suhuTempatHidup}");
            Console.WriteLine($"Makanan Ikan          : {makanan}");
        }
    }
}
