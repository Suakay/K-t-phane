using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane
{
    public class Uye : IUye
    {
        public int UyeId { get; private set; }
        public string UyeAdi { get; private set; }
        public string UyeSoyadi { get; private set; }
        public List<Kitap> OduncAlinanKitaplar { get; private set; } = new List<Kitap>();

        public Uye(int uyeId, string uyeAdi, string uyeSoyadi)
        {
            UyeId = uyeId;
            UyeAdi = uyeAdi;
            UyeSoyadi = uyeSoyadi;
        }
        public void KitapOduncAl(Kitap kitap)
        {
            if (kitap.durumu == KitapDurumu.OduncAlabilir)
            {
                OduncAlinanKitaplar.Add(kitap);
                kitap.durumu = KitapDurumu.OduncVerildi;
                Console.WriteLine($"{UyeAdi} {UyeSoyadi} adlı üye '{kitap.KitapAdi}' adlı kitabı ödünç aldı.");
            }
            else
            {
                Console.WriteLine($"'{kitap.KitapAdi}' adlı kitap ödünç alınamaz.");
            }

        }
        public void KitapIadeEt(Kitap kitap)
        {
            if (OduncAlinanKitaplar.Contains(kitap))
            {
                OduncAlinanKitaplar.Remove(kitap);
                kitap.durumu = KitapDurumu.OduncAlabilir;
                Console.WriteLine($"{UyeAdi} {UyeSoyadi} adlı üye '{kitap.KitapAdi}' adlı kitabı iade etti.");
            }
            else
            {
                Console.WriteLine($"'{kitap.KitapAdi}' adlı kitabı bu üye ödünç almamış.");
            }
        }
    }

}
