﻿namespace If_else;

class Program
{
    static void Main(string[] args)
    {
        int time = DateTime.Now.Hour;
        if(time>=6 && time<11)
            Console.WriteLine("Günaydın");
        else if(time<=18)
            Console.WriteLine("İyi Günler");
        else
            Console.WriteLine("İyi geceler");
            
        string sonuc = time<=18 ? "İyi Günler" : "İyi geceler";
        Console.WriteLine(sonuc);

        string sonuc1 = time>=6 && time<=11 ? "Günaydın" : time<=18 ? "iyi günler" : "iyi geceler";
        Console.WriteLine(sonuc1);
    }
}
