using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane
{
    public  class KitapTarihi:Kitap
    {
        public int Yil { get; set; }

        public override string KitapBilgileriniGetir()
        {
            return $"Kitap Adı: {KitapAdi}, Yazar: {Yazar}, Yıl: {Yil}, Durum: {durumu}";
        }
    }
}
