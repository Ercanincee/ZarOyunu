Console.WriteLine("Zar Atma Oyununa hosgeldiniz Kazanmak için belirtilen sayiden daha yüksek degeri atin");
do
{
   
    Random dice = new();
    int sayi = dice.Next(1, 7);
    Console.WriteLine($"{sayi} sayisindan daha yüksek veya esit zar atiniz");
    Console.WriteLine("Lutfen konsola zar atmak icin at yaziniz");
    string onay = Console.ReadLine();
    if (onay == "at")
    {
        int rastgelesayi = dice.Next(1, 7);
        Console.WriteLine($"{rastgelesayi} attiginiz zarin degeridir");
        if (rastgelesayi >= sayi)
        {
            Console.WriteLine("Kazandınız");
            Console.WriteLine("Tekrar oynamak icin devam yazınız");
            string devammi = Console.ReadLine();
            if (devammi == "devam") {
                continue;
            } else { break; }
        }
        else { Console.WriteLine("Kaybettiniz"); }
    }
    else
    {
        Console.WriteLine("Lütfen zar atmak icin konsola at yaziniz");
    }

} while (true);

