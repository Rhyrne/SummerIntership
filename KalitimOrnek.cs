using System;

public class Hayvan
{
    protected String? ozelIsim;
    protected String? turu;
    protected int yas;
    protected int enerji = 100;

    public String HayvanBilgi()
    {
        return ("Hayvanın adı : " + ozelIsim + "\nHayvanın türü : " + turu + "\nHayvanın yaşı : " + yas + "\nHayvanın enerji durumu : " + "%" + enerji.ToString());
    }
    public virtual void SesCikar()
    {
        Console.WriteLine("");
    }

    public virtual void HareketEt()
    {
    }

    public Hayvan(String? OzelIsim, String? Turu, int Yas) 
    {
        this.yas = Yas;
        this.turu = Turu;
        this.ozelIsim = OzelIsim;
    }
}
public class Kopek:Hayvan
{
    public Kopek(String? OzelIsim, String? Turu, int Yas) : base(OzelIsim, Turu, Yas)
    {
        this.ozelIsim = OzelIsim;
        this.turu = Turu;
        this.yas = Yas;
    }
    public override void SesCikar() 
    {
        Console.WriteLine("Hav Hav");
    }
    public override void HareketEt()
    {
        int yorgunlukMiktari = 10;
        enerji -= yorgunlukMiktari;
        Console.WriteLine(this + " koştu, kaybettiği enerji miktarı : {0}\nKalan enerji : %{1}", yorgunlukMiktari, enerji);
    }
}
public class Kedi : Hayvan
{
    public Kedi(String? OzelIsim, String? Turu, int Yas) : base(OzelIsim, Turu, Yas)
    {
        this.ozelIsim = OzelIsim;
        this.turu = Turu;
        this.yas = Yas;
    }
    public override void SesCikar()
    {
        Console.WriteLine("Miyav Miyav");
    }
    public override void HareketEt()
    {
        int yorgunlukMiktari = 6;
        enerji -= yorgunlukMiktari;
        Console.WriteLine(this + " koştu, kaybettiği enerji miktarı : {0}\nKalan enerji : %{1}", yorgunlukMiktari, enerji);
    }
}
public class Kus : Hayvan
{
    public Kus(String? OzelIsim, String? Turu, int Yas) : base(OzelIsim, Turu, Yas)
    {
        this.ozelIsim = OzelIsim;
        this.turu = Turu;
        this.yas = Yas;
    }
    public override void SesCikar()
    {
        Console.WriteLine("Cik Cik");
    }
    public override void HareketEt()
    {
        int yorgunlukMiktari = 15;
        enerji -= yorgunlukMiktari;
        Console.WriteLine(this + " uçtu, kaybettiği enerji miktarı : {0}\nKalan enerji : %{1}", yorgunlukMiktari, enerji);
    }
}
class KalitimOrnek
{
    static void Main()
    {
        Kopek kopek = new Kopek("Karabaş", "Kangal", 3);
        kopek.SesCikar();
        Console.WriteLine(kopek.HayvanBilgi());
        kopek.HareketEt();
        Console.WriteLine(kopek.HayvanBilgi());
    }
}
