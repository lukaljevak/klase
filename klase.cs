using System;

public class KlasaC
{
    public int Zbroj(int[] niz)
    {
        int zbroj = 0;
        foreach (int broj in niz)
        {
            zbroj += broj;
        }
        return zbroj;
    }

    public double Prosjek(int[] niz)
    {
        int zbroj = Zbroj(niz);
        double prosjek = (double)zbroj / niz.Length;
        return prosjek;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        KlasaC objekt = new KlasaC();
        int[] niz = new int[5];

        Console.WriteLine("Unesite 5 cijelih brojeva:");
        for (int i = 0; i < 5; i++)
        {
            niz[i] = Convert.ToInt32(Console.ReadLine());
        }

        int zbroj = objekt.Zbroj(niz);
        double prosjek = objekt.Prosjek(niz);

        Console.WriteLine("Zbroj: " + zbroj);
        Console.WriteLine("Prosjek: " + prosjek);
    }
}
