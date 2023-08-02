using System;


public class Yigin <jenerikTip>
{
    private int ustObje;
    private jenerikTip[] elemanlar;

    public Yigin(int kapasite)
    {
        elemanlar = new jenerikTip[kapasite];
        ustObje = -1; //Yığının eleman sayısını gösterir. "-1" ise boş demektir.
    }
    public void Push(jenerikTip Eleman)
    {
        if(ustObje == elemanlar.Length - 1)
            Console.WriteLine("Yığın dolu, önce eleman çıkarın.");
        else
            ustObje++;
            elemanlar[ustObje] = Eleman;
    }
    public void Pop()
    {
        if(ustObje == -1)
            Console.WriteLine("Yığın boş, önce eleman ekleyin.");
        else
            ustObje--;
            Console.WriteLine("En üstteki eleman artık : " + elemanlar[ustObje]);
    }
    public void IsEmpty()
    {
        if(ustObje == -1)
            Console.WriteLine("Yığın boş.");
        else
            Console.WriteLine("Yığında eleman bulunmakta.");
    }
    public void Clear()
    {
        ustObje = -1;
        Console.WriteLine("Yığın boşaltıldı.");
    }
    public void ShowAll()
    {
        for(int i = -1;i<ustObje;i++)
        {
            Console.WriteLine(elemanlar[i+1]);
        }
    }
}

class Program
{
    static void Main()
    {
        Yigin<int> yigin = new Yigin<int>(5);
        yigin.Push(15);
        yigin.Push(20);
        yigin.IsEmpty();
        yigin.ShowAll();
        Yigin<String> yigin2 = new Yigin<String>(10);
        yigin2.Push("Mehmet");   
        yigin2.Push("Ahmet");   
        yigin2.Push("Can");
        yigin2.Pop();
        yigin2.ShowAll();
        yigin2.Clear();
        yigin2.ShowAll();

    }
}
