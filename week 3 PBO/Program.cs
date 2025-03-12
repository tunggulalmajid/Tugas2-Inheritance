using week_3_PBO;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Sedan");
        MobilSedan sedan = new MobilSedan("Corola", "Toyota", "Kuning", 5, 2001, "Sedan Klasik",4.50, 10.5);
        sedan.tampilkanSedan();

        Console.WriteLine("Ikan");
        IkanAirAsin ikan = new IkanAirAsin("Hiu Putih", "Carcharodon carcharias", "Putih", "Air Asin (Laut)", "Sebuah", 20, "Ikan");
        ikan.InfoIkan();

        Console.WriteLine("Pion");
        PionPutih pp = new PionPutih("Putih",2);
        pp.infoPionPutih();
        pp.PionPutihMelangkah();
        pp.promosiPutih();
        pp.eliminasiHitam();
        pp.infoPionPutih();

        PionHitam ph = new PionHitam("Hitam", 7);
        ph.infoPionHitam();
        ph.PionHitamMelangkah();
        ph.promosiHitam();
        ph.eliminasiPutih();
        ph.infoPionHitam();

        Console.WriteLine("Rekening Bank");
        ATM atm = new ATM("Tunggul", "BRI", 242410102058, 1000000, 101010, 2078567128);
        atm.infoAtm();
        atm.tarikTunai(100000);
        atm.setorTunai(100000);

        MobileBanking mb = new MobileBanking("Tunggul", "BRI", 242410102058, 1000000, "Proton", "Proton123");
        mb.infoMobileBanking();
        mb.transfer(242410108090, 100000);

        Console.ReadLine();
    }
}