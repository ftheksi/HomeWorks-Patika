namespace ödev;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        string str20 = "20";
        int int20 = 20;
        string yeniDeger = str20 + int20.ToString();
        Console.WriteLine(yeniDeger);


        int int21 = int20 + Convert.ToInt32(str20);
        Console.WriteLine(int21);       


        int int22 = int20 + int.Parse(str20);

        //datetime

        string datetime = DateTime.Now.ToString("dd.MM.yyyy");
        Console.WriteLine(datetime);

        string datetime2 = DateTime.Now.ToString("dd-MM-yyyy");
        Console.WriteLine(datetime2);

        string hour = DateTime.Now.ToString("HH:mm");
        Console.WriteLine(hour);
    }
}
