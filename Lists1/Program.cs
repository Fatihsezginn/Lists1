using System; // Temel sınıfları kullanabilmemizi sağlar.
using System.Collections.Generic; // List gibi koleksiyonları kullanmak için gerekli.

class Program // Program sınıfı.
{
    static void Main(string[] args) // Uygulamanın başlangıç noktası.
    {
        // Davetlilerin listesi
        List<string> davetliler = new List<string> // Yeni bir string listesi oluşturuyoruz.
        {
            "1-Bülent Ersoy", // Listeye ilk isim ekleniyor.
            "2-Ajda Pekkan", // İkinci isim ekleniyor.
            "3-Ebru Gündeş", // Üçüncü isim.
            "4-Hadise", // Dördüncü isim.
            "5-Hande Yener", // Beşinci isim.
            "6-Tarkan", // Altıncı isim.
            "7-Funda Arar", // Yedinci isim.
            "8-Demet Akalın" // Sekizinci isim.
        };

        // İsimleri ekrana yazdırma
        Console.WriteLine("Gecenin Davetlileri:"); // Ekrana başlık yazdırıyoruz.
        foreach (string davetli in davetliler) // Davetliler listesindeki her bir isim için döngü başlatıyoruz.
        {
            Console.WriteLine(davetli); // Her bir davetliyi ekrana yazdırıyoruz.
        }

        // Programın kapanmasını beklemek için
        Console.ReadLine(); // Kullanıcının bir tuşa basmasını bekler, böylece konsol penceresi hemen kapanmaz.
    }
}
