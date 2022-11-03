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
        Urunno[] urunnolari;
        public Depo()
        {
            CamasirMakineleri = new CamasirMakinesi[0];
            BulasikMakineleri = new BulasikMakinesi[0];
            Buzdolaplari = new BuzDolabi[0];
            urunnolari = new Urunno[0];
        }
        public void Ekle(Urunno u)
        {
            Urunno[] gecici = new Urunno[urunnolari.Length + 1];
            Array.Copy(urunnolari, gecici, urunnolari.Length);
            gecici[gecici.Length - 1] = u;
            urunnolari = gecici;
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

        string urunno = "";
        public void Listele()
        {
            Console.WriteLine("-*-*-*-Çamaşır Makineleri-*-*-*-");
            for (int i = 0; i < CamasirMakineleri.Length; i++)
            {
                Console.WriteLine($"---Ürün No=100{i + 1}---");
                Console.WriteLine((i + 1) + "-)" + CamasirMakineleri[i].Yazdir());
                Ekle(new Urunno("100"));
            }
            Console.WriteLine("-*-*-*-Bulaşık Makineleri-*-*-*-");
            for (int i = 0; i < BulasikMakineleri.Length; i++)
            {
                Console.WriteLine($"---Ürün No=200{i + 1}---");
                Console.WriteLine((CamasirMakineleri.Length + i + 1) + "-)" + BulasikMakineleri[i].Yazdir());
                Ekle(new Urunno("200"));
            }
            Console.WriteLine("-*-*-*-Buz Dolapları-*-*-*-");
            for (int i = 0; i < Buzdolaplari.Length; i++)
            {
                Console.WriteLine($"---Ürün No=300{i + 1}---");
                Console.WriteLine((CamasirMakineleri.Length + BulasikMakineleri.Length + i + 1) + "-)" + Buzdolaplari[i].Yazdir());
                Ekle(new Urunno("300"));
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
        double toplam = 0;
        public void CamasirSatinAl()
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




                    }

                }
            }

        }


        public void BulasikSatinAl()
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



                    }

                }
            }

        }
        public void BuzdolabiSatinAl()
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



                    }

                }
            }

        }

        public void TumundenSatinAl()
        {

            Listele();
            Console.WriteLine("Lütfen Satın Almak İstediğiniz Ürünün Numarasını Giriniz");
            int selected = Convert.ToInt32(Console.ReadLine());
            for (int u = 0; u < urunnolari.Length; u++)
            {
                urunno = urunnolari[u].Yazdır();
                char firstCharacter = urunno[0];
                if (firstCharacter == '1')
                {
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




                            }
                        }
                    }

                }
                if (firstCharacter == '2')
                {
                    for (int i = 0; i < BulasikMakineleri.Length; i++)
                    {
                        if (selected == CamasirMakineleri.Length + i + 1)
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



                            }
                        }
                    }
                }
                if (firstCharacter == '3')
                {
                    for (int i = 0; i < Buzdolaplari.Length; i++)
                    {
                        if (selected == CamasirMakineleri.Length + BulasikMakineleri.Length + i + 1)
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



                            }
                        }
                    }
                }
            }

        }
        public double GetToplam()
        {
            return toplam;
        }
    }
}
