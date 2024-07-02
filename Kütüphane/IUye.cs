using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane
{
    public  interface IUye
    {
        int UyeId { get; }
        string UyeAdi { get; }
        string UyeSoyadi { get; }
        List<Kitap> OduncAlinanKitaplar { get; }
        void KitapOduncAl(Kitap kitap);
        void KitapIadeEt(Kitap kitap);

    }
}
