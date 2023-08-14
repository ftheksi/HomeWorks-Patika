// See https://aka.ms/new-console-template for more information

string[] renkler = new string[5];

string[] hayvanlar = {"Kedi", "Köpek", "Kuş", "Maymun"};

int[] dizi;
dizi = new int[5];

renkler[0] = "Mavi";
dizi[3] =10;
Console.WriteLine(hayvanlar[1]);
Console.WriteLine(dizi[3]);
Console.WriteLine(renkler[0]);

// Döngülerle dizi kullanımı

Console.WriteLine("Lütfen dizinin eleman sayısını giriniz: ");
int diziUzunlugu = int.Parse(Console.ReadLine());
int[] ornekDizi = new int [diziUzunlugu];

for (int i = 0; i < diziUzunlugu; i++)
{
    Console.WriteLine("Lütfen {0}. sayı giriniz: ", i+1);
    ornekDizi[i]= int.Parse(Console.ReadLine());
}

int toplam = 0;
foreach (var sayi in ornekDizi)
    toplam+= sayi;

Console.WriteLine("ortalama:", + toplam/diziUzunlugu);

