
//Parametre almayan ve geriye değer döndürmeyen void metot. 
void MerhabaDunya()
{
    Console.WriteLine("Merhaba Dünya");
}

MerhabaDunya();


Console.WriteLine("-----------------------------------");

//Parametre alan ve geriye değer döndürmeyen metot. 
void HosGeldiniz(string ad, string soyAd)
{
    Console.WriteLine($"Hoşgeldiniz {ad} {soyAd}");

}
Console.WriteLine("Adınızı giriniz.\n");
string ad = Console.ReadLine();

Console.WriteLine("Soy adınızı giriniz\n");
string soyAd = Console.ReadLine();

HosGeldiniz(ad, soyAd);

Console.WriteLine("-------------------------------");

//Parametre almayan ve geriye değer döndüren metot. 
int RastgeleSayiOlustur()
{
    Random rnd = new Random();
    int sayi = rnd.Next(1, 101);
    return sayi % 2;
}

int kalan = RastgeleSayiOlustur();
Console.WriteLine("Rastgele sayının 2 ye bölümünden kalan\n" + kalan);

Console.WriteLine("------------------------------------------------");

//Parametre alan ve geriye değer döndüren metot. 
int carp(int sayi1, int sayi2)
{
    return sayi1 * sayi2;

}

Console.WriteLine("1. sayıyı giriniz. ");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2. sayıyı giriniz");
int sayi2 = Convert.ToInt32(Console.ReadLine());

int sonuc = carp(sayi1, sayi2);
Console.WriteLine($"Çarpım sonucu {sonuc}");