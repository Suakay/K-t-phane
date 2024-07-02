using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane
{
    public class KitapBilimi : Kitap
    {
      
        public string Alan { get; set; }

        public override string KitapBilgileriniGetir()
        {
            return $"Kitap Adı: {KitapAdi}, Yazar: {Yazar}, Alan: {Alan}, Durum: {durumu}";
        }
    }
}
