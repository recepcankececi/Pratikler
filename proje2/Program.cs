﻿using System;
using System.Collections.Generic;

namespace proje2
{
    class Program
    {
        
        public static List<Kartlar> toDo = new List<Kartlar>();
        public static List<Kartlar> progress = new List<Kartlar>();
        public static List<Kartlar> done = new List<Kartlar>();
        static void Main(string[] args)
        {
            TakımUyesiOlustur();
            KartOlustur();
            int key = 0;
            while (key < 1 || key > 4)
            {
                Console.Clear();
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Board Listelemek");
                Console.WriteLine("(2) Board'a Kart Eklemek");
                Console.WriteLine("(3) Board'dan Kart Silmek");
                Console.WriteLine("(4) Kart Taşımak");
                
                key = Convert.ToInt32(Console.ReadLine());

                switch (key)
                {
                    case 1:
                        BoardListeleme();
                        break;

                    case 2:
                        BoardaKartEkleme();
                        break;

                    case 3:
                        BoarddanKartSilme();
                        break;

                    case 4:
                        KartTasima();
                        break;
                    
                }
            }
            
        }

        private static void KartTasima()
        {
            throw new NotImplementedException();
        }

        private static void BoarddanKartSilme()
        {
            throw new NotImplementedException();
        }

        public static void BoardaKartEkleme()
        {
            Kartlar yeniKart = new Kartlar();

            Console.WriteLine("Başlık giriniz                                      : ");
            yeniKart.baslik = Console.ReadLine();
            
            Console.WriteLine("İçerik giriniz                                      : ");
            yeniKart.icerik = Console.ReadLine();

            Console.WriteLine("Büyüklük seçiniz -> XS(1), S(2), M(3), L(4), XL(5)  : ");
            int temp = Convert.ToInt32(Console.ReadLine());
            if (temp == 1)
            {
                yeniKart.kartBuyuklugu = KartBuyuklugu.XS;
            }
            if (temp == 2)
            {
                yeniKart.kartBuyuklugu = KartBuyuklugu.S;
            }
            if (temp == 3)
            {
                yeniKart.kartBuyuklugu = KartBuyuklugu.M;
            }
            if (temp == 4)
            {
                yeniKart.kartBuyuklugu = KartBuyuklugu.L;
            }
            if (temp == 5)
            {
                yeniKart.kartBuyuklugu = KartBuyuklugu.XL;
            }

            Console.WriteLine("Kişi seçiniz                                        : ");
            yeniKart.atanankisi = Console.ReadLine();

            Console.WriteLine("Hangi Line'a eklemek istiyorsunuz? -> ToDo (1), Progress (2), Done (3) :");
            int line = Convert.ToInt32(Console.ReadLine());
            if (line == 1)
            {
                toDo.Add(yeniKart);
            }
            if (line == 2)
            {
                progress.Add(yeniKart);
            }
            if (line == 3)
            {
                done.Add(yeniKart);
            }
            Main(null);
        }

        public static void BoardListeleme()
        {
            Console.Clear();
            Console.WriteLine("Done List");
            Console.WriteLine("******************");
            for (int i = 0; i < done.Count; i++)
            {
                Console.WriteLine("Başlık : " + done[i].baslik);
                Console.WriteLine("İçerik : " + done[i].icerik);
                Console.WriteLine("Atanan Kişi : " + done[i].atanankisi);
                Console.WriteLine("Büyüklük: " + done[i].kartBuyuklugu);
                Console.WriteLine("-----------------");
            }
            
            Console.WriteLine();
            Console.WriteLine("Progress List");
            for (int i = 0; i < progress.Count; i++)
            {
                Console.WriteLine("Başlık : " + progress[i].baslik);
                Console.WriteLine("İçerik : " + progress[i].icerik);
                Console.WriteLine("Atanan Kişi : " + progress[i].atanankisi);
                Console.WriteLine("Büyüklük: " + progress[i].kartBuyuklugu);
                Console.WriteLine("-----------------");
            }
            
            Console.WriteLine();
            Console.WriteLine("ToDo List");
            for (int i = 0; i < toDo.Count; i++)
            {
                Console.WriteLine("Başlık : " + toDo[i].baslik);
                Console.WriteLine("İçerik : " + toDo[i].icerik);
                Console.WriteLine("Atanan Kişi : " + toDo[i].atanankisi);
                Console.WriteLine("Büyüklük: " + toDo[i].kartBuyuklugu);
                Console.WriteLine("-----------------");
            }
            Console.ReadKey();
            Main(null);
        }
        public static Dictionary<int, string> takımUyeleri = new Dictionary<int, string>();
        public static void TakımUyesiOlustur()
        {
            takımUyeleri.Add(0, "Recep Can");
            takımUyeleri.Add(1, "Çağatay");
            takımUyeleri.Add(2, "Büşra");
            takımUyeleri.Add(3, "Ali");
            takımUyeleri.Add(4, "Veli");
        }
        public static void KartOlustur()
        {
            Kartlar kart_1 = new Kartlar();
            kart_1.baslik = "Proje taslağını çıkar.";
            kart_1.icerik = "Taslak";
            kart_1.atanankisi = takımUyeleri[0];
            kart_1.kartBuyuklugu = KartBuyuklugu.M;
            kart_1.progress = 2;
            done.Add(kart_1);

            Kartlar kart_2 = new Kartlar();
            kart_2.baslik = "Projeyi tamamla.";
            kart_2.icerik = "Proje";
            kart_2.atanankisi = takımUyeleri[1];
            kart_2.kartBuyuklugu = KartBuyuklugu.XL;
            kart_2.progress = 1;
            progress.Add(kart_2);

            Kartlar kart_3 = new Kartlar();
            kart_3.baslik = "Projeyi gite yükle";
            kart_3.icerik = "Proje";
            kart_3.atanankisi = takımUyeleri[2];
            kart_3.kartBuyuklugu = KartBuyuklugu.XS;
            kart_3.progress = 2;
            toDo.Add(kart_3);

        }
    }
    public enum KartBuyuklugu
    {
        XS, S, M, L, XL
    }
    
    public class Kartlar
    {
        public string baslik, icerik, atanankisi;
        public int progress;
        public KartBuyuklugu kartBuyuklugu;
    }
}