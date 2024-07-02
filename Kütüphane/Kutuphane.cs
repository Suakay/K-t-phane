using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane
{
    public class Kutuphane
    {
        private List<Kitap> Kitaplar = new List<Kitap>();
        private List<Uye> Uyeler = new List<Uye>();
        public Kutuphane()
        {
            // Örnek kitaplar ekleme
            Kitaplar.Add(new KitapBilimi { KitapId = 1, KitapAdi = "Leyla ile Mecnun", Yazar = "İskneder Pala", durumu = KitapDurumu.OduncAlabilir, Alan = "Edebiyat" });
            Kitaplar.Add(new KitapRoman { KitapId = 2, KitapAdi = "Kaplanın Sırtında", Yazar = "Zülfü Livaneli", durumu = KitapDurumu.OduncAlabilir, Tur = "Klasik" });
            Kitaplar.Add(new KitapTarihi { KitapId = 3, KitapAdi = "Kukla", Yazar = "Ahmet Ümit", durumu = KitapDurumu.MevcutDegil, Yil = 2000 });

            // Örnek üyeler ekleme
            Uyeler.Add(new Uye(1, "Sevgi", "Gül"));
            Uyeler.Add(new Uye(2, "Müge", "Baltacı"));
        }
        public void KitapEkle(Kitap kitap)
        {
            Kitaplar.Add(kitap);
            Console.WriteLine($"'{kitap.KitapAdi}' kitap kütüphaneye eklendi.");

        }
        public Kitap KitapBul(int kitapId)
        {
            return Kitaplar.FirstOrDefault(k => k.KitapId == kitapId);
        }

        public Uye UyeBul(int uyeId)
        {
            return Uyeler.FirstOrDefault(u => u.UyeId == uyeId);
        }

        public void KitapOduncVer(int kitapId, int uyeId)
        {
            Kitap kitap = KitapBul(kitapId);
            Uye uye = UyeBul(uyeId);
            if (kitap != null && uye != null)
            {
                uye.KitapOduncAl(kitap);
            }
            else
            {
                Console.WriteLine("Kitap veya üye bulunamadı.");
            }
        }
        public void KitapIadeAl(int kitapId, int uyeId)
        {
            Kitap kitap = KitapBul(kitapId);
            Uye uye = UyeBul(uyeId);

            if (kitap != null && uye != null)
            {
                uye.KitapIadeEt(kitap);
            }
            else
            {
                Console.WriteLine("Kitap veya üye bulunamadı.");
            }

        }
        public void KitapDurumunuGuncelle(int kitapId, KitapDurumu yeniDurum)
        {
            Kitap kitap = KitapBul(kitapId);

            if (kitap != null)
            {
                kitap.durumu = yeniDurum;
                Console.WriteLine($"'{kitap.KitapAdi}' adlı kitabın durumu '{yeniDurum}' olarak güncellendi.");
            }
            else
            {
                Console.WriteLine("Kitap bulunamadı.");
            }

        }
        public void UyeninOduncAldigiKitaplariGoruntule(int uyeId)
        {
            Uye uye = UyeBul(uyeId);

            if (uye != null)
            {
                Console.WriteLine($"{uye.UyeAdi} {uye.UyeSoyadi} adlı üyenin ödünç aldığı kitaplar:");
                foreach (Kitap kitap in uye.OduncAlinanKitaplar)
                {
                    Console.WriteLine(kitap.KitapBilgileriniGetir());
                }
            }
            else
            {
                Console.WriteLine("Üye bulunamadı.");
            }
        }

        public void KutuphaneDurumunuGoruntule()
        {
            Console.WriteLine("Kütüphane Durumu:");
            Console.WriteLine("--");

            Console.WriteLine("Mevcut Kitaplar:");
            foreach (Kitap kitap in Kitaplar)
            {
                Console.WriteLine(kitap.KitapBilgileriniGetir());
            }

            Console.WriteLine("\nÜyeler:");
            foreach (Uye uye in Uyeler)
            {
                Console.WriteLine($"{uye.UyeAdi} {uye.UyeSoyadi} - Üye No: {uye.UyeId}");
            }
        
}   }   }
