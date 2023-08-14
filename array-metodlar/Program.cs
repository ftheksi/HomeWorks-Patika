// See https://aka.ms/new-console-template for more information

int[] sayiDizisi = {23,12,4,86,72,3,11,17};
foreach (var sayi in sayiDizisi)
    Console.WriteLine(sayi);

Console.WriteLine("Sıralı Diziler");
Array.Sort(sayiDizisi);

foreach (var sayi in sayiDizisi)
    Console.WriteLine(sayi);

//clear
Console.WriteLine("Array clear");
//2. indexten itibaren 2 elemanı sıfırlar
Array.Clear(sayiDizisi,2,2);
foreach (var sayi in sayiDizisi)
    Console.WriteLine(sayi);

//tersine sıralama
Console.WriteLine("Array reverse");
Array.Reverse(sayiDizisi);
foreach (var sayi in sayiDizisi)
    Console.WriteLine(sayi);

Console.WriteLine("Array Indexof");
Console.WriteLine(Array.IndexOf(sayiDizisi,23));

//resize
Console.WriteLine("array resize");
Array.Resize<int>(ref sayiDizisi,9);
sayiDizisi[8]=99;

foreach (var sayi in sayiDizisi)
    Console.WriteLine(sayi);


