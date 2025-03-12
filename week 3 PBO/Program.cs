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

        Console.WriteLine("Catur");
        Pion pion = new Pion("Pion", "Putih",1,"a2 - h2","Maju Satu Langkah", "Menjadi Apapun Selain Raja" );
        pion.InfoPion();

        Benteng benteng = new Benteng("Benteng", "Putih", 5, "A1 dan H1", "Lurus");
        benteng.InfoBenteng();

        Kuda kuda = new Kuda("Kuda", "Putih", 3, "B1 dan G1", "Seperti Huruf L");
        kuda.InfoKuda();

        Gajah gajah = new Gajah("Gajah", "Putih", 3, "C1 dan F1","Putih", "Meluncur Diagonal");
        gajah.InfoGajah();

        Menteri menteri = new Menteri("Menteri", "Putih", 9, "D1", "Meluncur Seperti Gajah dan Lurus Seperti Benteng");
        menteri.InfoMentri();

        Raja raja = new Raja("Raja", "Putih", 39, "E1", "Berpindah Satu Petak Ke Segala Arah", "Jika Raja Terancam tidak bisa bergerak, permainan berakhir" );
        raja.InfoRaja();

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