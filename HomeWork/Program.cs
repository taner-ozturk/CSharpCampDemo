using System;

class MainClass
{
    public static void Main(string[] args)
    {

        Urun urun1 = new Urun();
        urun1.Kategori = "Giyim";
        urun1.UrunAdi = "Gömlek";
        urun1.Marka = "A";
        urun1.Fiyat = 100;

        Urun urun2 = new Urun();
        urun2.Kategori = "Elektronik";
        urun2.UrunAdi = "Notebook";
        urun2.Marka = "B";
        urun2.Fiyat = 8000;

        Urun urun3 = new Urun();
        urun3.Kategori = "Kozmetik";
        urun3.UrunAdi = "Parfüm";
        urun3.Marka = "C";
        urun3.Fiyat = 450;

        string[] kategoriler = new string[] { urun1.Kategori, urun2.Kategori, urun3.Kategori };

        string[] urunAdlari = new string[] { urun1.UrunAdi, urun2.UrunAdi, urun3.UrunAdi };

        Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

        Console.WriteLine("*For Loop*");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("-" + "Kategori: " + kategoriler[i]);
        }
        Console.WriteLine("*************");

        Console.WriteLine("*Foreach Loop*");
        foreach (var urun in urunler)
        {
            Console.WriteLine("-" + "Kategori: " + urun.Kategori);
            Console.WriteLine("-" + "Ürün Adı:" + urun.UrunAdi);
            Console.WriteLine("-" + "Marka: " + urun.Marka);
            Console.WriteLine("-" + "Fiyat: " + urun.Fiyat);
            Console.WriteLine("-----------");
        }
        Console.WriteLine("*************");

        Console.WriteLine("*While Loop*");
        int sayac = 0;
        while (sayac < 3)
        {
            Console.WriteLine("-" + "Ürün Adı: " + urunAdlari[sayac]);
            sayac++;
        }
    }
}

class Urun
{
    public string Kategori { get; set; }
    public string UrunAdi { get; set; }
    public string Marka { get; set; }
    public int Fiyat { get; set; }
}