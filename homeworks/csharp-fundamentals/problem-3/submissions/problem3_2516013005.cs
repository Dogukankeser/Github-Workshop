using System;
using System.Collections.Generic;

namespace CSharpHomework
{
    public class Problem3
    {
        // 1. Faktoriyel Metodu (for döngüsü)
        public static long Faktoriyel(int n)
        {
            long sonuc = 1;
            // 1'den n'e kadar olan sayıları çarpıyoruz
            for (int i = 1; i <= n; i++)
            {
                sonuc *= i; // sonuc = sonuc * i
            }
            return sonuc;
        }

        // 2. FibonacciSerisi Metodu (while döngüsü)
        public static List<int> FibonacciSerisi(int adet)
        {
            List<int> serisi = new List<int>();
            
            // Eğer 0 veya negatif girilirse boş liste dön
            if (adet <= 0) return serisi;

            int sayi1 = 0;
            int sayi2 = 1;
            int sayac = 0;

            // İstenilen adede ulaşana kadar döngü devam eder
            while (sayac < adet)
            {
                serisi.Add(sayi1);
                int toplam = sayi1 + sayi2;
                sayi1 = sayi2;
                sayi2 = toplam;
                sayac++;
            }
            return serisi;
        }

        // 3. BasamakSayisi Metodu (do-while döngüsü)
        public static int BasamakSayisi(int sayi)
        {
            int basamak = 0;
            
            // Negatif sayıların mutlak değerini alıyoruz (örn: -999 -> 999)
            if (sayi < 0) sayi = Math.Abs(sayi);

            // do-while en az bir kere çalışır (0 sayısı 1 basamaklıdır kuralı için ideal)
            do
            {
                sayi /= 10; // Sayıyı 10'a bölerek son basamağı atıyoruz
                basamak++;
            } while (sayi > 0);

            return basamak;
        }

        // 4. AsalMi Metodu (for döngüsü)
        public static bool AsalMi(int sayi)
        {
            // 2'den küçük sayılar (0, 1 ve negatifler) asal değildir
            if (sayi < 2) return false;

            // Bir sayının kareköküne kadar bölen yoksa, sayı asaldır (Optimizasyon)
            for (int i = 2; i * i <= sayi; i++)
            {
                if (sayi % i == 0)
                {
                    return false; // Tam bölünüyorsa asal değildir
                }
            }
            return true;
        }

        // 5. SayilarinToplami Metodu (for döngüsü)
        public static int SayilarinToplami(int n)
        {
            int toplam = 0;
            // 1'den n'e kadar toplama
            for (int i = 1; i <= n; i++)
            {
                toplam += i;
            }
            return toplam;
        }
    }
}
