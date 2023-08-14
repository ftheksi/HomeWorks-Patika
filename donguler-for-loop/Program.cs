


Console.Write("Lütfen Bir sayı giriniz:");
int sayac =int.Parse(Console.ReadLine());

for (int i = 1; i <=sayac; i++)
{
    if(i%2==1)
    Console.WriteLine(i);
}


int tekToplam =0;
int ciftToplam =0;
for (int i = 1; i <=1000; i++)
{
    if(i%2==1)
        tekToplam+=i;
    else
        ciftToplam+=i;
}
Console.WriteLine("tekToplam:"+tekToplam);
Console.WriteLine("ciftToplam:"+ciftToplam);



// break-continue

for (int i = 1; i <10; i++){
    
    if(i==4)
        break;
    Console.WriteLine(i);
}
for (int i = 1; i <10; i++){
    
    if(i==4)
        continue;
    Console.WriteLine(i);
}

int sayi = int.Parse(Console.ReadLine());
int sayac3 = 1;
int toplam = 0;
while (sayac3<=sayi)
{
    toplam+=sayac3;
    sayac3++;
}
Console.WriteLine(toplam/sayi);

char character = 'a';
while (character<'z')
{
    Console.WriteLine(character);
    character++;
}    


string[] arabalar = {"bmw","ford","toyota","nissan"};

foreach(var araba in arabalar)
{
    Console.WriteLine(araba);
}