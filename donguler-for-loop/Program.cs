// See https://aka.ms/new-console-template for more information


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



//break-continue

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
