using System;
using System.Collections.Generic;
using System.Linq;

namespace OgrenciYonetimSistemiV5
{
    class Uygulama
    {

        List<Ogrenci> Ogrenciler;

        public void Calistir()
        {
            Ogrenciler = new List<Ogrenci>();
            SahteVeri();
            Menu();
            AnaEkran();

        }

        public void Menu()
        {
            Console.WriteLine("------  Öğrenci Yönetim Sistemi  -----");
            Console.WriteLine("1-Öğrenci Gir");
            Console.WriteLine("2-Not Gir");
            Console.WriteLine("3-Öğrencinin ortalamasını gör");
            Console.WriteLine("4-Öğrencinin adresini gir");
            Console.WriteLine("5-Bütün Öğrencileri Listele");
            Console.WriteLine("6-Şubeye Göre Öğrencileri Listele");
            Console.WriteLine("7-Öğrencinin notlarını görüntüle");
            Console.WriteLine("8-Sınıfın Not Ortalamasını Gör");
            Console.WriteLine("9-Cinsiyetine göre öğrenci listele");
            Console.WriteLine("10-Şu tarihten sonra doğan öğrencileri listele");
            Console.WriteLine("11-Tüm öğrencileri semtlerine göre sıralayarak listele");
            Console.WriteLine("12-Okuldaki En başarılı 5 öğrenciyi listele");
            Console.WriteLine("13-Okuldaki En başarısız 3 öğrenciyi listele");
            Console.WriteLine("14-Sınıftaki En başarılı 5 öğrenciyi listele");
            Console.WriteLine("15-Sınıftaki En başarısız 3 öğrenciyi listele");
            Console.WriteLine("16-Öğrenci için açıklama gir");
            Console.WriteLine("17-Öğrencinin açıklamasını gör");
            Console.WriteLine("18-Öğrencinin okuduğu kitabı gir");
            Console.WriteLine("19-Öğrencinin okuduğu kitapları listele");
            Console.WriteLine("20-Öğrencinin okuduğu son kitabı görüntüle");
            Console.WriteLine("21-Öğrenci sil");
            Console.WriteLine("22-Öğrenci güncelle");
            Console.WriteLine();
            Console.WriteLine("Çıkış yapmak için “çıkış” yazıp “enter”a basın.");

        }

        public void AnaEkran()
        {
            while (true)
            {

                string secim = SecimAl();
                switch (secim)
                {
                    case "1":
                        OgrenciGir();
                        break;
                    case "2":
                        NotEkle();
                        break;
                    case "3":
                        OgrenciOrtalamaGor();
                        break;
                    case "4":
                        AdresGir();
                        break;
                    case "5":
                        OgrencileriListele(secim);
                        break;
                    case "6":
                        OgrencileriListele(secim);
                        break;
                    case "7":
                        OgrenciNotGoruntule();
                        break;
                    case "8":
                        SinifinOrtalamaGor();
                        break;
                    case "9":
                        OgrencileriListele(secim);
                        break;
                    case "10":
                        OgrencileriListele(secim);
                        break;
                    case "11":
                        OgrencileriListele(secim);
                        break;
                    case "12":
                        OgrencileriListele(secim);
                        break;
                    case "13":
                        OgrencileriListele(secim);
                        break;
                    case "14":
                        OgrencileriListele(secim);
                        break;
                    case "15":
                        OgrencileriListele(secim);
                        break;
                    case "16":
                        AciklamaGir();
                        break;
                    case "17":
                        AciklamaGor();
                        break;
                    case "18":
                        KitapGir();
                        break;
                    case "19":
                        OgrencileriListele(secim);
                        break;
                    case "20":
                        OgrencileriListele(secim);
                        break;
                    case "21":
                        OgrenciSil();
                        break;
                    case "22":
                        OgrenciGuncelle();
                        break;
                    case "çıkış":
                    case "cikis":
                        Environment.Exit(0);
                        break;
                    case "liste":
                        Menu();
                        break;
                    default:
                        Console.WriteLine("Hatalı işlem gerçekleştirildi. Tekrar deneyin.");
                        break;

                }
                MenuDon();
            }
        }

        public string SecimAl()
        {
            Console.WriteLine();
            Console.Write("Yapmak istediğiniz işlemi seçiniz: ");
            string giris = Console.ReadLine().ToLower();
            Console.WriteLine();
            return giris;
        }

        public void SahteVeri()
        {
            Ogrenci o1 = new Ogrenci(56, "Naz", "Şimşek", DateTime.Parse("01.01.2000"), CINSIYET.Kız, SUBE.B);
            Ogrenci o2 = new Ogrenci(77, "Yağmur", "Aktürk", DateTime.Parse("1.4.1998"), CINSIYET.Kız, SUBE.B);
            Ogrenci o3 = new Ogrenci(88, "Çiçek", "Yüzbaş", DateTime.Parse("8.8.1991"), CINSIYET.Kız, SUBE.B);
            Ogrenci o4 = new Ogrenci(99, "Engin", "Günaydın", DateTime.Parse("12.12.1993"), CINSIYET.Erkek, SUBE.B);

            this.Ogrenciler.Add(o1);
            this.Ogrenciler.Add(o2);
            this.Ogrenciler.Add(o3);
            this.Ogrenciler.Add(o4);

            o1.NotEkle(DERS.Fen, 85);
            o1.NotEkle(DERS.Matematik, 70);
            o1.NotEkle(DERS.Sosyal, 65);
            o1.NotEkle(DERS.Turkce, 55);

            o2.NotEkle(DERS.Fen, 20);
            o2.NotEkle(DERS.Matematik, 40);
            o2.NotEkle(DERS.Sosyal, 54);
            o2.NotEkle(DERS.Turkce, 32);

            o3.NotEkle(DERS.Fen, 90);
            o3.NotEkle(DERS.Matematik, 95);
            o3.NotEkle(DERS.Sosyal, 53);
            o3.NotEkle(DERS.Turkce, 88);

            o4.NotEkle(DERS.Fen, 77);
            o4.NotEkle(DERS.Matematik, 69);
            o4.NotEkle(DERS.Sosyal, 45);
            o4.NotEkle(DERS.Turkce, 33);

            o1.Adres.Sehir = "Ankara";
            o1.Adres.Semt = "Çankaya";
            o2.Adres.Sehir = "İzmir";
            o2.Adres.Semt = "Alsancak";
            o3.Adres.Sehir = "İstanbul";
            o3.Adres.Semt = "Kartal";
            o4.Adres.Sehir = "Ankara";
            o4.Adres.Semt = "Keçiören";

            o1.Kitaplar.Add("Kalemimin Sapını Gülle Donattım");
            o1.Kitaplar.Add("Bir Çift Yürek");
            o2.Kitaplar.Add("Kırmızı Saçlı Kadın");
            o2.Kitaplar.Add("Kürk Mantolu Madonna");
            o2.Kitaplar.Add("Genç Werther'in Acıları");
            o3.Kitaplar.Add("1984");
            o3.Kitaplar.Add("Hayvanlar Çiftliği");
            o4.Kitaplar.Add("Sapiens");

        }

        public void NotEkle()
        {
            Ogrenci o;
            DERS drs = DERS.Empty;
            o = OgrenciGet(OgrenciKontrol());

            bool tipCheck = true;

            Console.WriteLine("---- Eklenilebilecek Dersler ----");
            Console.WriteLine("-Fen için 1       ");
            Console.WriteLine("-Matematik için 2 ");
            Console.WriteLine("-Sosyal için 3     ");
            Console.WriteLine("-Türkçe için 4     ");
            do
            {
                Console.Write("Ders: ");
                string secimTip = Console.ReadLine();
                switch (secimTip)
                {
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                        drs = Araclar.DersBul(secimTip);
                        tipCheck = true;
                        break;
                    default:
                        Console.WriteLine("Hatalı giriş yapıldı tekrar deneyin.");
                        tipCheck = false;
                        break;
                }

            } while (!tipCheck);
            int notAdedi = Araclar.SayiAl("Eklemek istediğiniz not adedi: ");

            for (int i = 1; i <= notAdedi; i++)
            {

                int not = Araclar.SayiAl(i + ". notu girin: ");

                try
                {
                    o.NotEkle(drs, not);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    i--;
                }

            }
            Console.WriteLine("Bilgiler sisteme girilmiştir.");

        }

        public string StringMi(string mesaj)
        {
            string veri = "";
            bool check = true;
            int sayac = 1;
            while (check)
            {
                Console.Write(mesaj);
                veri = Araclar.IlkHarfBuyut(Console.ReadLine());
                string sayi = "1234567890!^+-*/?*.,#%&:;()={}[]-_\"<>'\\~@|";

                foreach (char item in veri)
                {
                    if (sayi.Contains(item))
                    {
                        Console.WriteLine("Hatalı işlem tekrar girin.");
                        break;
                    }

                    else if (veri.Length == sayac)
                    {
                        check = false;
                        break;
                    }
                    sayac++;
                }

            }
            return veri;
        }

        public void OgrenciGir()
        {
            Console.WriteLine("1-Öğrenci Gir ---------------------------------------------");
            int ogrenciNo = Araclar.SayiAl("Öğrencinin numarası: ");
            int maxNo = Ogrenciler.Max(t => t.No) + 1;

            string ogAd = StringMi("Öğrencinin adı: ");

            string ogSoyad = StringMi("Öğrencinin soyadı: ");

            DateTime ogrenciDogumTarih = Araclar.TarihAl("Öğrencinin doğum tarihi: ");

            CINSIYET ogrenciCinsiyet;
            string ogCns;
            while (true)
            {
                Console.Write("Öğrencinin cinsiyeti(K/E): ");
                ogCns = Console.ReadLine().ToUpper();

                ogrenciCinsiyet = Araclar.CinsiyetBul(ogCns);
                if (ogrenciCinsiyet != CINSIYET.Empty)
                {
                    break;
                }
                Console.WriteLine("Hatalı giriş yapıldı. Tekrar deneyin.");
            }

            SUBE ogrenciSube;
            string ogSb;
            while (true)
            {
                Console.Write("Öğrencinin şubesi(A/B/C): ");
                ogSb = Console.ReadLine().ToUpper();

                ogrenciSube = Araclar.SubeBul(ogSb);
                if (ogrenciSube != SUBE.Empty)
                {
                    break;
                }
                Console.WriteLine("Hatalı giriş yapıldı. Tekrar deneyin.");
            }


            foreach (Ogrenci item in Ogrenciler)
            {
                if (item.No == ogrenciNo)
                {
                    Console.WriteLine(maxNo + " numaralı öğrenci sisteme başarılı bir şekilde eklenmiştir.");
                    Console.WriteLine("Sistemde " + ogrenciNo + " numaralı öğrenci olduğu için verdiğiniz öğrenci no " + maxNo + " olarak değiştirildi");
                    ogrenciNo = maxNo;
                    break;
                }
            }
            if (maxNo != ogrenciNo)
            {
                Console.WriteLine(ogrenciNo + " numaralı öğrenci sisteme başarılı bir şekilde eklenmiştir.");
            }

            this.Ogrenciler.Add(new Ogrenci(ogrenciNo, ogAd, ogSoyad, ogrenciDogumTarih, ogrenciCinsiyet, ogrenciSube));

        }

        public void AdresGir()
        {
            Console.WriteLine("4 - Öğrencinin adresini gir--------------------------------");
            Ogrenci ogr;
            ogr = OgrenciGet(OgrenciKontrol());

            string il = StringMi("İl: ");
            string ilce = StringMi("İlçe: ");
            string mahalle = StringMi("Mahalle: ");
            ogr.Adres.Sehir = Araclar.IlkHarfBuyut(il);
            ogr.Adres.Semt = Araclar.IlkHarfBuyut(ilce);
            ogr.Adres.Mahalle = Araclar.IlkHarfBuyut(mahalle);

            Console.WriteLine("Bilgiler sisteme girilmiştir.");
        }

        public void AciklamaGir()
        {
            Console.WriteLine("16 - Öğrenci için açıklama gir--------------------------------");
            Ogrenci ogr;

            ogr = OgrenciGet(OgrenciKontrol());
            Console.Write("Açıklama: ");
            string aciklama = Console.ReadLine();
            ogr.Aciklama += Araclar.IlkHarfBuyut(aciklama) + "\n";

            Console.WriteLine("Bilgiler sisteme girilmiştir.");

        }

        public void AciklamaGor()
        {
            Console.WriteLine("17 - Öğrencinin açıklamasını gör--------------------------------");
            Ogrenci ogr;
            ogr = OgrenciGet(OgrenciKontrol());
            if (ogr.Aciklama != null)
            {
                Console.WriteLine("Açıklama: ");
                Console.WriteLine(ogr.Aciklama);
            }
            else
            {
                Console.WriteLine("Bu öğrenciye ait açıklama bulunmamaktadır.");
            }

        }

        public void KitapGir()
        {
            Console.WriteLine("18 - Öğrencinin okuduğu kitabı gir--------------------------------");
            Ogrenci ogr;
            ogr = OgrenciGet(OgrenciKontrol());

            Console.Write("Eklenecek Kitap Adı: ");
            string kitap = Araclar.IlkHarfBuyut(Console.ReadLine());
            ogr.Kitaplar.Add(kitap);

            Console.WriteLine("Bilgiler sisteme girilmiştir.");
        }

        public void OgrenciNotGoruntule()
        {
            Console.WriteLine("7-Öğrencinin notlarını görüntüle ------------------------------------");
            Ogrenci ogr;
            ogr = OgrenciGet(OgrenciKontrol());
            Console.WriteLine("Dersin Adı".PadRight(15) + "Notu".PadRight(5));
            Console.WriteLine("--------------------");
            List<DersNotu> dersListe = ogr.Notlar.OrderBy(t => t.DersAdi).ToList();
            foreach (DersNotu item in dersListe)
            {
                Console.WriteLine(item.DersAdi.ToString().PadRight(15) + item.Not.ToString().PadRight(5));
            }

        }

        public void Listele(List<Ogrenci> liste)
        {
            if (liste.Count > 0)
            {
                Console.WriteLine("Şube".PadRight(10) + "No".PadRight(10) + "Adı Soyadı".PadRight(25) + "Not Ort.".PadRight(15) + "Okuduğu Kitap Say.".PadRight(20));
                Console.WriteLine("-------------------------------------------------------------------------------");
                foreach (Ogrenci item in liste)
                {
                    Console.WriteLine(item.Sube.ToString().PadRight(10) + item.No.ToString().PadRight(10) + (item.Ad + " " + item.Soyad).PadRight(25) + item.NotOrtalamasi.ToString().PadRight(15) + item.Kitaplar.Count.ToString().PadRight(20));
                }

            }
            else
            {
                Console.WriteLine("Listelenecek öğrenci bulunamadı.");
            }
        }

        public void KitapListele(Ogrenci ogrencimiz, string secim)
        {
            if (ogrencimiz != null)
            {
                if (ogrencimiz.Kitaplar.Count != 0)
                {
                    if (secim == "19")
                    {
                        OgrenciGet(ogrencimiz);
                        Console.WriteLine("Okuduğu Kitaplar".PadRight(20));
                        Console.WriteLine("-----------------");
                        foreach (string item in ogrencimiz.Kitaplar)
                        {

                            Console.WriteLine(item);
                        }

                    }
                    else if (secim == "20")
                    {
                        OgrenciGet(ogrencimiz);
                        Console.WriteLine("Okuduğu Son Kitap".PadRight(20));
                        Console.WriteLine("------------------");
                        Console.WriteLine(ogrencimiz.Kitaplar[ogrencimiz.Kitaplar.Count - 1]);

                    }

                }

                else
                {
                    Console.WriteLine("Listelenecek kitap bulunamadı.");
                }
            }
            else
            {
                Console.WriteLine("Böyle bir ögrenci bulunamadı");
            }

        }

        public void OgrenciOrtalamaGor()
        {
            Console.WriteLine("3-Öğrencinin not ortalamasını gör --------------------------");
            Ogrenci ogr;
            ogr = OgrenciGet(OgrenciKontrol());

            Console.WriteLine("Öğrencinin not ortalaması: " + ogr.NotOrtalamasi);

        }

        public void SinifinOrtalamaGor()
        {
            Console.WriteLine("8-Sinifin not ortalamasını gör --------------------------");
            SUBE sb = Araclar.SubeAl("Bir şube seçin(A/B/C): ");
            Console.WriteLine();

            List<Ogrenci> SinifOrtalamasi = Ogrenciler.Where(t => t.Sube == sb).ToList();
            double sinifOrtalama = (SinifOrtalamasi.Count == 0) ? 0 : SinifOrtalamasi.Average(t => t.NotOrtalamasi);

            Console.WriteLine("Sinifin not ortalaması: " + Math.Round(sinifOrtalama, 2));

        }

        public void OgrencileriListele(string sec)
        {

            if (sec == "5")
            {
                Console.WriteLine("5- Bütün Öğrencileri Listele -------------------------------");
                Listele(Ogrenciler);
            }
            else if (sec == "6")
            {
                Console.WriteLine("6-Şubeye Göre Öğrencileri Listele -------------------------------");
                SUBE ogrenciSube = Araclar.SubeAl("Listelemek istediğiniz şubeyi girin(A/B/C): ");

                List<Ogrenci> SubeListe = Ogrenciler.Where(t => t.Sube == ogrenciSube).ToList();
                Listele(SubeListe);
            }
            else if (sec == "9")
            {
                Console.WriteLine("9-Cinsiyete Göre Öğrencileri Listele -------------------------------");
                CINSIYET ogrenciCinsiyet = Araclar.CinsiyetAl("Listelemek istediğiniz cinsiyeti girin(K / E): ");
                List<Ogrenci> CinsiyetListe = Ogrenciler.Where(t => t.Cinsiyet == ogrenciCinsiyet).ToList();
                Listele(CinsiyetListe);
            }

            else if (sec == "10")
            {
                Console.WriteLine("10-Doğum Tarihine Göre Öğrencileri Listele -------------------------------");
                DateTime ogrenciDogumTarihi = Araclar.TarihAl("Hangi tarihten sonraki öğrencileri listelemek istersiniz: ");
                List<Ogrenci> DogumTarihListe = Ogrenciler.Where(t => t.DogumTarihi > ogrenciDogumTarihi).ToList();
                Listele(DogumTarihListe);
            }

            else if (sec == "11")
            {
                Console.WriteLine("11-Semte Göre Öğrencileri Listele -------------------------------");
                List<Ogrenci> SemtListe = Ogrenciler.Where(a => a.Adres != null).OrderBy(t => t.Adres.Sehir).ThenBy(n => n.Adres.Semt).ToList();
                SemtListe.AddRange(Ogrenciler.Where(a => a.Adres == null).ToList());
                if (SemtListe.Count > 0)
                {

                    Console.WriteLine("Şube".PadRight(10) + "No".PadRight(10) + "Adı Soyadı".PadRight(25) + "Şehir".PadRight(15) + "Semt".PadRight(15));
                    Console.WriteLine("-------------------------------------------------------------------------------");
                    foreach (Ogrenci item in SemtListe)
                    {
                        Console.WriteLine(item.Sube.ToString().PadRight(10) + item.No.ToString().PadRight(10) + (item.Ad + " " + item.Soyad).PadRight(25) + item.Adres.Sehir.ToString().PadRight(15) + item.Adres.Semt.ToString().PadRight(15));
                    }

                }
                else
                {
                    Console.WriteLine("Listelenecek öğrenci bulunamadı.");
                }
            }

            else if (sec == "12")
            {
                Console.WriteLine("12-Okuldaki en başarılı 5 öğrenciyi listele --------------------------");
                List<Ogrenci> BesBasariliListe = Ogrenciler.OrderByDescending(t => t.NotOrtalamasi).Take(5).ToList();
                Listele(BesBasariliListe);
            }

            else if (sec == "13")
            {
                Console.WriteLine("13-Okuldaki en başarısız 3 öğrenciyi listele --------------------------");
                List<Ogrenci> UcBasarisizListe = Ogrenciler.OrderBy(t => t.NotOrtalamasi).Take(3).ToList();
                Listele(UcBasarisizListe);
            }

            else if (sec == "14")
            {
                Console.WriteLine("14-Sınıftaki en başarılı 5 öğrenciyi listele --------------------------");
                SUBE sb = Araclar.SubeAl("Listelenecek şube seçin(A/B/C): ");
                List<Ogrenci> SinifBasariliListe = Ogrenciler.Where(t => t.Sube == sb).OrderByDescending(t => t.NotOrtalamasi).Take(5).ToList();
                Listele(SinifBasariliListe);
            }

            else if (sec == "15")
            {
                Console.WriteLine("15-Sınıftaki en başarısız 3 öğrenciyi listele --------------------------");
                SUBE sb = Araclar.SubeAl("Listelenecek şube seçin(A/B/C): ");
                List<Ogrenci> SinifBasarisizListe = Ogrenciler.Where(t => t.Sube == sb).OrderBy(t => t.NotOrtalamasi).Take(3).ToList();
                Listele(SinifBasarisizListe);
            }
            else if (sec == "19")
            {
                Console.WriteLine("19-Öğrencinin okuduğu kitapları listele --------------------------");
                Ogrenci og = OgrenciBul();
                KitapListele(og, sec);
            }
            else if (sec == "20")
            {
                Console.WriteLine("20-Öğrencinin okuduğu son kitabı listele --------------------------");
                Ogrenci og = OgrenciBul();
                KitapListele(og, sec);
            }

        }

        public void OgrenciSil()
        {
            Console.WriteLine("Öğrenci sil --------------------------");
            Ogrenci ogr;

            if (Ogrenciler.Count == 0)
            {
                Console.WriteLine("Listede silinecek öğrenci yok.");
                return;
            }
            else
            {
                ogr = OgrenciGet(OgrenciKontrol());
                Console.WriteLine("Öğrenciyi silmek istediğinize emin misiniz (E/H).");
                string karar = Console.ReadLine().ToUpper();
                if (karar == "E")
                {
                    this.Ogrenciler.Remove(ogr);
                    Console.WriteLine("Öğrenci başarılı şekilde silindi.");
                }

            }

        }

        public void OgrenciGuncelle()
        {
            Console.WriteLine("22 - Öğrenciyi güncelle --------------------------------");
            Ogrenci ogr;
            ogr = OgrenciKontrol();
            Console.Write("Öğrencinin adı: ");
            string ad = Araclar.IlkHarfBuyut(Console.ReadLine());
            if (ad.Length != 0)
            {
                ogr.Ad = ad;
            }
            Console.Write("Öğrencinin soyadı: ");
            string soyad = Araclar.IlkHarfBuyut(Console.ReadLine());
            if (soyad.Length != 0)
            {
                ogr.Soyad = soyad;
            }

            Console.Write("Öğrencinin doğum tarihi: ");
            string giris = Console.ReadLine();

            if (giris.Length != 0)
            {
                DateTime tarih;
                DateTime.TryParse(giris, out tarih);
                ogr.DogumTarihi = tarih;
            }
            CINSIYET ogrenciCinsiyet = Araclar.CinsiyetAl("Öğrencinin cinsiyeti(K/E): ");
            if (ogrenciCinsiyet != CINSIYET.Empty)
            {
                ogr.Cinsiyet = ogrenciCinsiyet;
            }

            SUBE ogrenciSube = Araclar.SubeAl("Öğrencinin şubesi(A/B/C): ");
            if (ogrenciSube != SUBE.Empty)
            {
                ogr.Sube = ogrenciSube;
            }
            Console.WriteLine();
            Console.WriteLine("Öğrenci güncellendi.");

        }

        public Ogrenci OgrenciBul()
        {
            int no = Araclar.SayiAl("Öğrenci no giriniz: ");
            Ogrenci ogr = Ogrenciler.Where(t => t.No == no).FirstOrDefault();
            return ogr;
        }

        public void MenuDon()
        {
            Console.WriteLine();
            Console.WriteLine("Menüyü tekrar listelemek için “liste”, çıkış yapmak için “çıkış” yazın.");
            return;
        }
        public Ogrenci OgrenciGet(Ogrenci ogr)
        {
            Console.WriteLine();
            Console.WriteLine("Öğrencinin Adı Soyadı: " + ogr.Ad + " " + ogr.Soyad);
            Console.WriteLine("Öğrencinin Şubesi: " + ogr.Sube);
            Console.WriteLine();
            return ogr;
        }
        public Ogrenci OgrenciKontrol()
        {
            Ogrenci ogr;
            while (true)
            {
                ogr = OgrenciBul();
                if (ogr != null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Bu numarada bir öğrenci yok.Tekrar deneyin");
                }
            }
            return ogr;
        }

    }
}
