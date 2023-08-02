using System;

interface IBankaHesabi
{
    void ParaYatir(decimal miktar);
    void ParaCek(decimal miktar);
    void HesapBilgi();
}
class BankaHesabi : IBankaHesabi
{
    private decimal bakiye;
    private String? hesapSahibi;

    public BankaHesabi(String? hesapsahibi)
    {
        this.hesapSahibi = hesapsahibi;
        this.bakiye = 0;
    }
    public void ParaYatir(decimal miktar)
    {
        this.bakiye += miktar;
        Console.WriteLine($"{hesapSahibi} adlı müşterinin banka hesabına {miktar} TL yatırıldı. İyi günler dileriz!");
    }
    public void ParaCek(decimal miktar)
    {
        this.bakiye -= miktar;
        Console.WriteLine($"{hesapSahibi} adlı müşterinin banka hesabından {miktar} TL çekildi. İyi günler dileriz!");
    }
    public void HesapBilgi()
    {
        Console.WriteLine($"{hesapSahibi} adlı müşterinin banka hesabında {bakiye} TL bulunmakta. İyi günler dileriz!");
    }
}
class ArayuzOrnek
{
    static void Main()
    {
        BankaHesabi yenihesap = new BankaHesabi("Mehmet");
        yenihesap.ParaYatir(453220);
        yenihesap.HesapBilgi();
        yenihesap.ParaCek(34500);
        yenihesap.HesapBilgi();
    }
}
