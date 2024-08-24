using System;

class Program
{
    static void Main()
    {

        List<string> kahveListesi = new List<string>();

        Console.WriteLine("Lütfen 5 adet kahve ismi giriniz:");

        for (int i = 0; i < 5; i++) {

            Console.Write("Kahveniz" +  (i+1) + ":");
            string kahveIsmi = Console.ReadLine(); 
            kahveListesi.Add(kahveIsmi);
        
        }

        Console.WriteLine("Girdiğiniz Kahveler:");
        foreach (string kahve in kahveListesi) { Console.WriteLine(kahve); }
    }
}
