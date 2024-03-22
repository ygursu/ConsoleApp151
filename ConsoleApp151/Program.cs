using System;
class HelloWorld
{
    static void Main()
    {

        int sayi, ters = 0;
        Console.WriteLine("Bir sayı giriniz : ");
        sayi = int.Parse(Console.ReadLine());
        while (sayi != 0)
        {
            ters = ters * 10;
            ters = ters + sayi % 10;
            sayi = sayi / 10;
        }
        Console.WriteLine("Sayının tersi : " + ters);
    }
}