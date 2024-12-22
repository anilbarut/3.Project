using System;

namespace Proje
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lütfen aşağıdaki bilgileri giriniz:");

            Console.Write("T.C. Kimlik Numarasını Giriniz: ");

            string tckımlıkno = Console.ReadLine();
            Console.Write("Adı: ");
            string ad = Console.ReadLine();

            Console.Write("Soyadı: ");
            string soyad = Console.ReadLine();

            Console.Write("Telefon Numarası: ");
            string telno = Console.ReadLine();

            Console.Write("Yaş: ");
            string yas = Console.ReadLine();

            int ilkürün, ikinciürün, toplam;

            Console.Write("İlk Aldığı ÜrÜnÜn Fiyatı: ");
            ilkürün = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinici Aldığı Ürünün Fiyatı: ");
            ikinciürün = Convert.ToInt32((string)Console.ReadLine());

            toplam = ilkürün + ikinciürün;
            double yüzde10 = toplam * 0.1;

            //ürün fiyatlarını saklamak için convert.toint32 ile tek bir integer olarak tanımlıyoruz.


            Console.WriteLine("------------------------------------");

            Console.WriteLine($"{tckımlıkno} T.C. Numaralı {ad} {soyad} isimli kişi için kayıt oluşturulmuştur.");
            Console.WriteLine($"{telno} Telefon Numarasına bildirim mesajı gönderilmiştir.");
            Console.WriteLine($"{toplam} TL Toplam harcama karşılığı kazanılan 10% patika puan miktari -> {yüzde10} dir.");
        }
    }
}

