namespace HalilPazarlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Depo d = new Depo();

            #region Doldur
            #region Çamaşır Makinesi
            CamasirMakinesi cm = new CamasirMakinesi("Ariston", "AR123", 11000, 7, true);
            d.Ekle(cm);
            d.Ekle(new CamasirMakinesi("SIEMENS", "S123", 5000, 8, true));
            d.Ekle(new CamasirMakinesi("BOSCH", "WGA142XSTR", 11999, 9, true));
            d.Ekle(new CamasirMakinesi("ALTUS", "AL 10123", 8829, 10, true));
            d.Ekle(new CamasirMakinesi("PROFILO", "CMU12T91TR", 8499, 9, false));
            d.Ekle(new CamasirMakinesi("SAMSUNG", "WW90T4020CE/AH", 8499, 9, true));
            #endregion
            #region Bulaşık Makinesi
            d.Ekle(new BulasikMakinesi("REGAL", "KAFA1500", 5500, 10, "A++"));
            d.Ekle(new BulasikMakinesi("Grundig", "GDF 6503", 5998, 6, "D"));
            d.Ekle(new BulasikMakinesi("PROFILO", "BM4321EG", 6900, 4, "D"));
            d.Ekle(new BulasikMakinesi("Vestel", "BM 4202 X", 6049, 4, "E"));
            d.Ekle(new BulasikMakinesi("ALTUS", "AL 434 P", 5150.60, 4, "E"));
            d.Ekle(new BulasikMakinesi("SIEMENS", "SN615X01DT IQ100", 9015.42, 5, "D"));
            #endregion
            #region Buz Dolabı
            d.Ekle(new BuzDolabi("SIEMENS", "IQ500 KG76NAIF0N", 23203.50, 578, 2, false));
            d.Ekle(new BuzDolabi("BOSCH", "KGN86AID1N", 24570, 631, 2, false));
            d.Ekle(new BuzDolabi("SAMSUNG", "RF85K90127F/TR", 55799.07, 850, 4, true));
            d.Ekle(new BuzDolabi("Grundig", "GSND 6384 S", 16499, 580, 2, false));
            d.Ekle(new BuzDolabi("ALTUS", "Alk 471", 9989, 514, 2, false));
            d.Ekle(new BuzDolabi("PROFILO", "BD3155WFVN", 14694, 483, 2, false));
            #endregion
            #endregion


            string devammi = "e";
            while (devammi.ToUpper() == "E")
            {


                d.Home();
                int selected = System.Convert.ToInt32(System.Console.ReadLine());
                while (selected != 1 && selected != 2 && selected != 3 && selected != 4)
                {
                    System.Console.WriteLine("Lütfen Geçerli Bir Numara Giriniz");
                    selected = System.Convert.ToInt32(System.Console.ReadLine());
                }
                if (selected == 1)
                {
                    d.CamasirSatinAl();
                }
                if (selected == 2)
                {
                    d.BulasikSatinAl();
                }
                if (selected == 3)
                {
                    d.BuzdolabiSatinAl();
                }
                if (selected == 4)
                {
                    d.TumundenSatinAl();
                }
                System.Console.WriteLine("Alışverişe Devam Edilsin Mi?");
                devammi = System.Console.ReadLine();
                System.Console.Clear();
            }
            double toplam = d.GetToplam();
            System.Console.WriteLine("Bizi Tercih Ettiğiniz İçin Teşekkürler");
            System.Console.WriteLine("Toplam Alışveriş = " + toplam);


        }
    }
}
