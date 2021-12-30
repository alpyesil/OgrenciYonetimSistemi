using System;
using System.Collections.Generic;
using System.Text;

namespace OgrenciYonetimSistemiV5
{
    class Araclar
    {
        static public string IlkHarfBuyut(string veri)
        {
            if (veri.Length != 0)
            {
                veri= veri.Substring(0, 1).ToUpper() + veri.Substring(1).ToLower();
            }
            return veri;
        }


        static public int SayiAl(string mesaj)
        {
            while (true)
            {
                Console.Write(mesaj);
                string giris = Console.ReadLine();
                int sayi;

                if (int.TryParse(giris, out sayi) && sayi>=0)
                {
                    return sayi;
                }

                Console.WriteLine("Hatali giris yapildi. Tekrar deneyin");
            }
        }

        static public DERS DersBul(string veri)
        {
            DERS drs = DERS.Empty;
            if (veri.ToUpper() == "1")
            {
                drs = DERS.Fen;
            }
            else if (veri.ToUpper() == "2")
            {
                drs = DERS.Matematik;
            }
            else if (veri.ToUpper() == "3")
            {
                drs = DERS.Sosyal;
            }
            else if (veri.ToUpper() == "4")
            {
                drs = DERS.Turkce;
            }

            return drs;
        }



        static public SUBE SubeAl(string mesaj)
        {
            SUBE ogrenciSube;
            while (true)
            {
                Console.Write(mesaj);
                string sb = Console.ReadLine().ToUpper();
                ogrenciSube = SubeBul(sb);
                if (ogrenciSube != SUBE.Empty)
                {
                    break;
                }
                Console.WriteLine("Hatalı giriş yapıldı. Tekrar deneyin.");
            }
            return ogrenciSube;
        }

        static public CINSIYET CinsiyetAl(string mesaj)
        {
            CINSIYET ogrenciCinsiyet;
            while (true)
            {
                Console.Write(mesaj);
                string cns = Console.ReadLine().ToUpper();
                ogrenciCinsiyet = CinsiyetBul(cns);
                if (ogrenciCinsiyet != CINSIYET.Empty)
                {
                    break;
                }
                Console.WriteLine("Hatalı giriş yapıldı. Tekrar deneyin.");
            }
            return ogrenciCinsiyet;
        }


        static public DateTime TarihAl(string mesaj)
        {
            while (true)
            {
                Console.Write(mesaj);
                string giris = Console.ReadLine();
                DateTime tarih;

                if (DateTime.TryParse(giris, out tarih))
                {
                    return tarih;
                }

                Console.WriteLine("Hatali giris yapildi. Tekrar deneyin");
            }
        }

        static public CINSIYET CinsiyetBul(string veri)
        {
            CINSIYET cns = CINSIYET.Empty;
            if (veri.ToUpper() == "K")
            {
                cns = CINSIYET.Kız;
            }
            else if (veri.ToUpper() == "E")
            {
                cns = CINSIYET.Erkek;
            }

            return cns;
        }


        static public SUBE SubeBul(string veri)
        {
            SUBE sube = SUBE.Empty;
            if (veri.ToUpper() == "A")
            {
                sube = SUBE.A;
            }
            else if (veri.ToUpper() == "B")
            {
                sube = SUBE.B;
            }
            else if (veri.ToUpper() == "C")
            {
                sube = SUBE.C;
            }

            return sube;
        }

    }
}
