using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalilPazarlama
{
    public class Depo
    {
        CamasirMakinesi[] CamasirMakineleri;
        BulasikMakinesi[] BulasikMakineleri;
        BuzDolabi[] Buzdolaplari;

        public Depo()
        {
            CamasirMakineleri = new CamasirMakinesi[0];
            BulasikMakineleri = new BulasikMakinesi[0];
            Buzdolaplari = new BuzDolabi[0];
        }

        public void Ekle(CamasirMakinesi cm)
        {
            CamasirMakinesi[] gecici = new CamasirMakinesi[CamasirMakineleri.Length + 1];
            Array.Copy(CamasirMakineleri, gecici, CamasirMakineleri.Length);
            gecici[gecici.Length - 1] = cm;
            CamasirMakineleri = gecici;
        }
        public void Ekle(BulasikMakinesi bm)
        {
            BulasikMakinesi[] gecici = new BulasikMakinesi[BulasikMakineleri.Length + 1];
            Array.Copy(BulasikMakineleri, gecici, BulasikMakineleri.Length);
            gecici[gecici.Length - 1] = bm;
            BulasikMakineleri = gecici;
        }
        public void Ekle(BuzDolabi bd)
        {
            BuzDolabi[] gecici = new BuzDolabi[Buzdolaplari.Length + 1];
            Array.Copy(Buzdolaplari, gecici, Buzdolaplari.Length);
            gecici[gecici.Length - 1] = bd;
            Buzdolaplari = gecici;
        }

        public void Listele()
        {
            Console.WriteLine("-*-*-*-Çamaşır Makineleri-*-*-*-");
            for (int i = 0; i < CamasirMakineleri.Length; i++)
            {
                Console.WriteLine($"---Ürün No=100{i + 1}---");
                Console.WriteLine(CamasirMakineleri[i].Yazdir());
            }
            Console.WriteLine("-*-*-*-Bulaşık Makineleri-*-*-*-");
            for (int i = 0; i < BulasikMakineleri.Length; i++)
            {
                Console.WriteLine($"---Ürün No=200{i + 1}---");
                Console.WriteLine(BulasikMakineleri[i].Yazdir());
            }
            Console.WriteLine("-*-*-*-Buz Dolapları-*-*-*-");
            for (int i = 0; i < Buzdolaplari.Length; i++)
            {
                Console.WriteLine($"---Ürün No=300{i + 1}---");
                Console.WriteLine(Buzdolaplari[i].Yazdir());
            }
        }
        public void Home()
        {
            Console.WriteLine("Lütfen Görmek İstediğiniz Menüyü Seçiniz");
            Console.WriteLine("1) Çamaşır Makinelerini Gör");
            Console.WriteLine("2) Bulaşık Makinelerini Gör");
            Console.WriteLine("3) Buz Dolaplarını Gör");
            Console.WriteLine("4) Tümünü Gör");
        }
        public void CamasirMakinesiListele()
        {
            Console.WriteLine("-*-*-*-Çamaşır Makineleri-*-*-*-");
            for (int i = 0; i < CamasirMakineleri.Length; i++)
            {
                Console.WriteLine((i + 1) + "-) " + CamasirMakineleri[i].Yazdir());
                Console.WriteLine("***************************");
            }

        }
        public void BulasikMakinesiListele()
        {
            Console.WriteLine("-*-*-*-Bulaşık Makineleri-*-*-*-");
            for (int i = 0; i < BulasikMakineleri.Length; i++)
            {
                Console.WriteLine((i + 1) + "-) " + BulasikMakineleri[i].Yazdir());
                Console.WriteLine("***************************");
            }

        }
        public void BuzdolabiListele()
        {
            Console.WriteLine("-*-*-*-Buz Dolapları-*-*-*-");
            for (int i = 0; i < Buzdolaplari.Length; i++)
            {
                Console.WriteLine((i + 1) + "-) " + Buzdolaplari[i].Yazdir());
                Console.WriteLine("***************************");
            }

        }
        public void CamasirSatinAl()
        {
            string devammi = "e";
            double toplam = 0;
            while (devammi.ToUpper() == "E")
            {
                CamasirMakinesiListele();
                Console.WriteLine("Lütfen Satın Almak İstediğiniz Ürünün Numarasını Giriniz");
                int selected = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < CamasirMakineleri.Length; i++)
                {
                    if (selected == i + 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Almak İstediğiniz Ürün");
                        Console.WriteLine(CamasirMakineleri[i].Yazdir());
                        Console.WriteLine("Onaylıyor Musunuz? E/H");
                        string onay = Console.ReadLine();
                        if (onay.ToUpper() == "E")
                        {
                            Console.WriteLine("Alışverişiniz İçin Teşekkür Ederiz");
                            Console.WriteLine("Ürünün Fiyatı = " + CamasirMakineleri[i].Fiyat + " TL");
                            toplam = CamasirMakineleri[i].Fiyat + toplam;
                            Console.WriteLine("Toplam Alışveriş = " + toplam);
                            Console.WriteLine("Alışverişe Devam Edilsin Mi?");
                            devammi = Console.ReadLine();


                        }
                        Console.Clear();
                    }
                }
            }

            Console.WriteLine("Bizi Tercih Ettiğiniz İçin Teşekkürler");
            Console.WriteLine("Toplam Alışveriş = " + toplam);

        }
        public void BulasikSatinAl()
        {
            string devammi = "e";
            double toplam = 0;
            while (devammi.ToUpper() == "E")
            {
                BulasikMakinesiListele();
                Console.WriteLine("Lütfen Satın Almak İstediğiniz Ürünün Numarasını Giriniz");
                int selected = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < BulasikMakineleri.Length; i++)
                {
                    if (selected == i + 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Almak İstediğiniz Ürün");
                        Console.WriteLine(BulasikMakineleri[i].Yazdir());
                        Console.WriteLine("Onaylıyor Musunuz? E/H");
                        string onay = Console.ReadLine();
                        if (onay.ToUpper() == "E")
                        {
                            Console.WriteLine("Alışverişiniz İçin Teşekkür Ederiz");
                            Console.WriteLine("Ürünün Fiyatı = " + BulasikMakineleri[i].Fiyat + " TL");
                            toplam = BulasikMakineleri[i].Fiyat + toplam;
                            Console.WriteLine("Toplam Alışveriş = " + toplam);
                            Console.WriteLine("Alışverişe Devam Edilsin Mi?");
                            devammi = Console.ReadLine();


                        }
                        Console.Clear();
                    }
                }
            }

            Console.WriteLine("Bizi Tercih Ettiğiniz İçin Teşekkürler");
            Console.WriteLine("Toplam Alışveriş = " + toplam);

        }
        public void BuzdolabiSatinAl()
        {
            string devammi = "e";
            double toplam = 0;
            while (devammi.ToUpper() == "E")
            {
                BuzdolabiListele();
                Console.WriteLine("Lütfen Satın Almak İstediğiniz Ürünün Numarasını Giriniz");
                int selected = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < Buzdolaplari.Length; i++)
                {
                    if (selected == i + 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Almak İstediğiniz Ürün");
                        Console.WriteLine(Buzdolaplari[i].Yazdir());
                        Console.WriteLine("Onaylıyor Musunuz? E/H");
                        string onay = Console.ReadLine();
                        if (onay.ToUpper() == "E")
                        {
                            Console.WriteLine("Alışverişiniz İçin Teşekkür Ederiz");
                            Console.WriteLine("Ürünün Fiyatı = " + Buzdolaplari[i].Fiyat + " TL");
                            toplam = Buzdolaplari[i].Fiyat + toplam;
                            Console.WriteLine("Toplam Alışveriş = " + toplam);
                            Console.WriteLine("Alışverişe Devam Edilsin Mi?");
                            devammi = Console.ReadLine();


                        }
                        Console.Clear();
                    }
                }
            }

            Console.WriteLine("Bizi Tercih Ettiğiniz İçin Teşekkürler");
            Console.WriteLine("Toplam Alışveriş = " + toplam);

        }
    }
}
