using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane
{
    public abstract class Kitap
    {
        public int KitapId {  get; set; }   
        public string Baslık {  get; set; } 
        public string KitapAdi {  get; set; }   
        public string Yazar {  get; set; }  
        public DateTime YayınYılı {  get; set; }    
        public KitapDurumu durumu { get; set; }
        public abstract string KitapBilgileriniGetir();
    }
}
