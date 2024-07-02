using Kütüphane;

//Kitap nesnesi oluşturamıyoruz çünkü abstruct classların nesnesi alınmaz


Kutuphane kutuphane = new Kutuphane();

// Kitap ödünç alma
kutuphane.KitapOduncVer(1, 1);

// Kitap iade etme
kutuphane.KitapIadeAl(1, 1);

// Kitap durumunu güncelleme
kutuphane.KitapDurumunuGuncelle(3, KitapDurumu.OduncAlabilir);

// Üyenin ödünç aldığı kitapları görüntüleme
kutuphane.UyeninOduncAldigiKitaplariGoruntule(1);

// Kütüphane durumunu görüntüleme
kutuphane.KutuphaneDurumunuGoruntule();
        
    



