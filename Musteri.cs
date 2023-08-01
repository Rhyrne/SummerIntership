using System;

public class Musteri
{
    private String? ad;
    private String? soyad;
    private int yas;
    private String? telNo; 

    public Musteri(String? ad, String? soyad, int yas) 
    {
        this.ad = ad;
        this.soyad = soyad;
        this.yas = yas;
        this.telNo = "Bulunmamakta";
    }

    public Musteri(String? ad, String? soyad, int yas, String? telNo)
    {
        this.ad = ad;
        this.soyad = soyad;
        this.yas = yas;
        this.telNo = telNo;
    }

    public String kayitSorgu()
    {
        return ("\nMüşteri Adı: " + ad + "\nMüşteri Soyadı: " + soyad + "\nMüşterini Yaşı: " + yas.ToString() + "\nMüşterinin Telefon Numarası:" + telNo);
    }

    public void telNoGuncelle(string yeniTelNo)
    {
        this.telNo = yeniTelNo;
        Console.WriteLine("\nTelefon numarası güncellendi");
    }
}


class Program
{
    static void Main()
    {
        Musteri musteri = new Musteri("Ahmet", "Musa", 21, "555 XXX XXXX");
        Musteri musteri1 = new Musteri("Mehmet", "Akay", 45);

        Console.WriteLine(musteri.kayitSorgu());

        Console.WriteLine(musteri1.kayitSorgu());

        musteri1.telNoGuncelle("541 XXX XXXX");
        Console.WriteLine(musteri1.kayitSorgu());
    }
}
