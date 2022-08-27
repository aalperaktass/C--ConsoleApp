using System;

namespace ConsoleAppCalisma
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void DikdortgenAlanHesabı()
        {
            Console.WriteLine("Kısa kenarı girin:");
            int KısaKenar = int.Parse(Console.ReadLine());

            Console.WriteLine("Uzun kenarı girin:");
            int UzunKenar = int.Parse(Console.ReadLine());

            var CevreHesabı = (2 * KısaKenar) + (2 * UzunKenar);
            var AlanHesabı = KısaKenar * UzunKenar;
            Console.WriteLine($"Alan Hesabı : {AlanHesabı} Çevre Hesabı: {CevreHesabı}");
        }
        static void A()
        {
            Console.WriteLine("1. sayıyı girin:");
            int sayı1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2. sayıyı girin:");
            int sayı2 = int.Parse(Console.ReadLine());

            Console.WriteLine("3. sayıyı girin:");
            int sayı3 = int.Parse(Console.ReadLine());

            Console.WriteLine("4. sayıyı girin:");
            int sayı4 = int.Parse(Console.ReadLine());

            int toplam = sayı1 + sayı2 + sayı3 + sayı4;
            Console.WriteLine(toplam);
        }
        static void AdSoyad()
        {

            //string Name = "Alper";
            //var Surname = "Aktas";
            //var Age = 24;
            //Console.WriteLine($"Benim adım {Name} Soyadım {Surname} ve {Age} yaşındayım");

            Console.WriteLine("ADINIZI GİRİNİZ:");
            var AD = Console.ReadLine();

            Console.WriteLine("Soyadınızı GİRİNİZ:");
            var SOYAD = Console.ReadLine();
            Console.WriteLine($"Benim adım {AD} Soyadım {SOYAD}");
        }
        static void DizilerBasitSıralama()
        {
            string[] isimler = { "Alper", "Berkan", "Ceyhun", "Deniz", "Esra" };
            int[] sayılar = { 121, 2321, 332, 435, 521 };

            //string[] isimler = new string[5];
            //isimler[0] = "Alper";
            //isimler[1] = "Berkan";
            //isimler[2] = "Ceyhun";
            //isimler[3] = "Deniz";
            //isimler[4] = "Esra";

            //int[] sayılar = new int[5];
            //sayılar[0] = 121;
            //sayılar[1] = 2321;
            //sayılar[2] = 332;
            //sayılar[3] = 435;
            //sayılar[4] = 521;
            Console.WriteLine($"{isimler[0]} isimli {sayılar[0]} numaralı öğrenci görevlidir.");
        }
        static void VizeNotHesabı()
        {
            //Şartlar Vize1 + vize2 nin yüzde 60'ı ve finalin yüzde 40'ı
            //ortalama 50 ise ve final notu 50 altındaysa kaldı
            //ortalama 50 üzeri ise geçti

            Console.WriteLine("1.Vizeyi Giriniz:");
            var Vize1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2.Vizeyi Giriniz:");
            var Vize2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Finali Giriniz:");
            var Final = int.Parse(Console.ReadLine());

            var result = (Vize1 + Vize2) * 60 / 100 + (Final * 40 / 100);



            if (result > 50 || result == 50 && Final > 50 || Final > 70)
                Console.WriteLine($"Öğrenci {result} notu ile geçmiştir...");

            else
                Console.WriteLine($"Öğrenci {result} notu ile kalmıştır...");
        }
        static void VucutKiloIndeksi()
        {
            Console.WriteLine("Adınızı Giriniz:");
            var Ad = Console.ReadLine();

            Console.WriteLine("Soyadınızı Giriniz:");
            var Soyad = Console.ReadLine();

            Console.WriteLine("Kilo Bilginizi Giriniz:");
            var Kilo = int.Parse(Console.ReadLine());

            Console.WriteLine("Boy Bilgilerinizi Giriniz:");
            var Boy = float.Parse(Console.ReadLine());

            float result = (Kilo / (Boy * Boy));

            if (result > 0 && result < 18.5)

                Console.WriteLine($"{Ad}  {Soyad}  Kilo indexinde zayıf çıkmıştır.");

            if (result > 18.4 && result < 25)

                Console.WriteLine($"{Ad}  {Soyad}  Kilo indexinde normal çıkmıştır.");

            if (result > 24.9 && result < 30)

                Console.WriteLine($"{Ad}  {Soyad}  Kilo indexinde kilolu çıkmıştır.");

            if (result > 29.9 && result < 35)

                Console.WriteLine($"{Ad} {Soyad}  Kilo indexinde fazla kilolu çıkmıştır.");
        }
        static void EhliyetYasHesabı()
        {
            string Egitim;

            Console.WriteLine("Adınızı Giriniz:");
            var Ad = Console.ReadLine();

            Console.WriteLine("Yaşınızı Giriniz:");
            var Yas = int.Parse(Console.ReadLine());

            Console.WriteLine("Eğitim Bilgilerinizi Giriniz (Üniversite mi ? Lise mi ? ) : ");
            Egitim = Console.ReadLine().ToUpper();


            if (Yas >= 18)
            {
                if (Egitim == "LİSE" || Egitim == "ÜNİVERSİTE")
                    Console.WriteLine($" {Ad} isimli kişi ehliyet almaya hak kazanmıştır.");
            }

            else
            {
                Console.WriteLine($" {Ad} isimli kişi ehliyet almaya hak kazanamamıştır.");
            }
        }
        static void EnBüyükSayıBulma()
        {
            int sayı1, sayı2, sayı3;

            Console.WriteLine("1.Sayıyı Giriniz");
            sayı1 = int.Parse(Console.ReadLine());


            Console.WriteLine("2.Sayıyı Giriniz");
            sayı2 = int.Parse(Console.ReadLine());


            Console.WriteLine("3.Sayıyı Giriniz");
            sayı3 = int.Parse(Console.ReadLine());


            if (sayı1 > sayı2 && sayı1 > sayı3)
            {
                Console.WriteLine($"Yazmış olduğunuz sayılardan en büyüğü : {sayı1} ");
            }

            if (sayı2 > sayı1 && sayı2 > sayı3)
            {
                Console.WriteLine($"Yazmış olduğunuz sayılardan en büyüğü : {sayı2} ");
            }

            else
            {
                Console.WriteLine($"Yazmış olduğunuz sayılardan en büyüğü : {sayı3} ");
            }
        }
        static void OgrenciHarfNotuHesaplama()
        {
            Console.WriteLine("Adınızı Giriniz");
            var ogrenci = Console.ReadLine();


            Console.WriteLine("Birinci yazılı notunuzu giriniz:");
            var yazılı1 = int.Parse(Console.ReadLine());

            Console.WriteLine("İkinci yazılı notunuzu giriniz:");
            var yazılı2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Sözlü notunuzu giriniz:");
            var sozlu = int.Parse(Console.ReadLine());

            var result = (yazılı1 * 40 / 100) + (yazılı2 * 40 / 100) + (sozlu * 20 / 100);


            if ((result >= 90) && (result <= 100))
            {
                Console.WriteLine($"{ogrenci} isimli öğrencinin harf notu AA");

            }

            if ((result >= 80) && (result <= 89))
            {
                Console.WriteLine($"{ogrenci} isimli öğrencinin harf notu BA");

            }

            if ((result >= 75) && (result <= 79))
            {
                Console.WriteLine($"{ogrenci} isimli öğrencinin harf notu BB");

            }

            if ((result >= 70) && (result <= 74))
            {
                Console.WriteLine($"{ogrenci} isimli öğrencinin harf notu CB");

            }

            if ((result >= 60) && (result <= 69))
            {
                Console.WriteLine($"{ogrenci} isimli öğrencinin harf notu CC");

            }

            if ((result >= 50) && (result <= 59))
            {
                Console.WriteLine($"{ogrenci} isimli öğrencinin harf notu DC");

            }

            if ((result >= 40) && (result <= 49))
            {
                Console.WriteLine($"{ogrenci} isimli öğrencinin harf notu DD");

            }

            if ((result >= 30) && (result <= 39))
            {
                Console.WriteLine($"{ogrenci} isimli öğrencinin harf notu FD");

            }

            if ((result >= 0) && (result <= 38))
            {
                Console.WriteLine($"{ogrenci} isimli öğrencinin harf notu FF");

            }

        }
        static void sd()
        {

        }


    }
}
