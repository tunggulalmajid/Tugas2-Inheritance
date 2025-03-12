﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace week_3_PBO
{
    internal class RekeningBank
    {
        public string namaNasabah, namaBank;
        public int nomorRekening;
        public ulong saldoRekening;
        public RekeningBank(string namaNasabah,string namaBank, int nomorRekening, ulong saldoRekening)
        {
            this.namaNasabah = namaNasabah;
            this.namaBank = namaBank;
            this.nomorRekening = nomorRekening;
            this.saldoRekening = saldoRekening;
        }
    }
    class ATM : RekeningBank
    {
        public int pinAtm;
        public int nomorKartu;
        public ATM(string namaNasabah,string namaBank, int nomorRekening, ulong saldoRekening, int pinAtm, int nomorKartu) :
            base(namaNasabah ,namaBank, nomorRekening, saldoRekening)
        {
            this.namaNasabah = namaNasabah;
            this.namaBank = namaBank;
            this.nomorRekening = nomorRekening;
            this.saldoRekening = saldoRekening;
            this.pinAtm = pinAtm;
            this.nomorKartu = nomorKartu;
        }
        public void infoAtm()
        {
            Console.WriteLine($"Nama Nasabah   : {namaNasabah}");
            Console.WriteLine($"Bank           : {namaBank}");
            Console.WriteLine($"Nomor Rekening : {nomorRekening}");
            Console.WriteLine($"Saldo Rekening : {saldoRekening}");
            Console.WriteLine($"Pin            : {pinAtm}");
            Console.WriteLine($"Nomor Kartu    : {nomorKartu}");
        }
        public void tarikTunai (int jumlahDitarik)
        {
            Console.WriteLine($"Saldo Berhasil Ditarik Sebesar : {jumlahDitarik}");
        }
        public void setorTunai(int jumlahSetor)
        {
            Console.WriteLine($"Saldo Berhasil Disetor Sebanyak : {jumlahSetor}");
        }
    }
    class MobileBanking : RekeningBank
    {
        public string username, password;
        public MobileBanking(string namaNasabah, string namaBank, int nomorRekening, ulong saldoRekening, string username, string password) :
            base(namaNasabah, namaBank, nomorRekening, saldoRekening)
        {
            this.namaNasabah = namaNasabah;
            this.namaBank = namaBank;
            this.nomorRekening = nomorRekening;
            this.saldoRekening = saldoRekening;
            this.username = username;
            this.password = password;
        }
        public void infoMobileBanking()
        {
            Console.WriteLine($"Nama Nasabah   : {namaNasabah}");
            Console.WriteLine($"Bank           : {namaBank}");
            Console.WriteLine($"Nomor Rekening : {nomorRekening}");
            Console.WriteLine($"Saldo Rekening : {saldoRekening}");
            Console.WriteLine($"Username       : {username}");
            Console.WriteLine($"Password       : {password}");
        }
        public void transfer(int rekening, int jumlah)
        {
            Console.WriteLine($"Saldo sebanyak {jumlah} berhasil di transfer ke {rekening}");
        }
    } 
}
