using System;

public class Musteri
{
    private string Ad { get; set; }
    private string Soyad { get; set; }
    private string TelNo { get; set; }

    public Musteri(string ad, string soyad, string telNo)
    {
        this.Ad = ad;
        this.Soyad = soyad;
        this.TelNo = telNo;
    }

    public string MusteriBilgi()
    {
        return $"Müşterinin adi ve soyadi: {Ad} {Soyad}\nmüşterinin telefon numarası: {TelNo}";
    }
}

public class MusteriIliskileriYonetimi
{
    private List<Musteri> musteriler;

    public MusteriIliskileriYonetimi()
    {
        musteriler = new List<Musteri>();
    }

    public void MusteriEkle(Musteri musteri)
    {
        musteriler.Add(musteri);
    }
    public void MusteriGuncelle(int Id,Musteri guncelMusteri)
    {
        if(Id >=0 &&  Id < musteriler.Count) 
        {
            musteriler[Id] = guncelMusteri;
        }
    }
    public void MusteriSil(int Id)
    {
        if (Id >= 0 && Id < musteriler.Count)
        {
            musteriler.RemoveAt(Id);
        }
    }
    public void MusteriBilgiGoster()
    {
        foreach(var musteri in musteriler)
        {
            Console.WriteLine(musteri.MusteriBilgi());
        }
    }
}
class CRMOrnek
{
    static void Main()
    {
        MusteriIliskileriYonetimi crm = new MusteriIliskileriYonetimi();

        Musteri musteri1 = new Musteri("Ahmet", "Ölmüş", "545 XXX XXXX");
        Musteri musteri2 = new Musteri("Mehmet", "Yaşayan", "541 XXX XXXX");

        crm.MusteriEkle(musteri1);
        crm.MusteriEkle(musteri2);
        crm.MusteriSil(0);
        crm.MusteriBilgiGoster();
    }
}
