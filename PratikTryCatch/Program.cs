while (true)
{
    try
    {
        Console.Write("Lütfen bir sayı giriniz: ");
        string input = Console.ReadLine();
        int sayi = Convert.ToInt32(input);
        Console.WriteLine($"Girilen sayı: {sayi}\nGirilen sayının karesi:{sayi*sayi}");
        break;
    }
    catch (FormatException ex)
    {
        Console.WriteLine("Geçersiz giriş lütfen sayı giriniz.");
    }
}