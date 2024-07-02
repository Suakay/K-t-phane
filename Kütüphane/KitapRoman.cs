using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane
{
    public  class KitapRoman:Kitap
    {
        public string Tur { get; set; }

        public override string KitapBilgileriniGetir()
        {
            return $"Kitap Adı: {KitapAdi}, Yazar: {Yazar}, Tür: {Tur}, Durum: {durumu}";
        }

    }
}
