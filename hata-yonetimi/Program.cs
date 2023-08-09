// try
// {
//     Console.WriteLine("Bir sayı giriniz");
//     int sayi = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine(sayi);

// }
// catch (Exception ex)
// {
//     Console.WriteLine("Hata" + ex.Message.ToString());
// }
// finally
// {
//     Console.WriteLine("İşlem Tamamlandı");
// }

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            // int a = int.Parse(null);
            // int a = int.Parse("test");
            int a = int.Parse("-23456789000");
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Boş değer girdiniz");
            Console.WriteLine(ex);

        }
        catch (FormatException ex)
        {
            Console.WriteLine("Veri Tipi uygun değil");
            Console.WriteLine(ex);

        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Çok küçük ya da çok büyük bir değer girdiniz");
            Console.WriteLine(ex);
        }
        finally
        {
            Console.WriteLine("İşlem Başarıyla tamamlandı");
        }
    }
}