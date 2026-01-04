using System;

namespace CSharpHomework
{
    public class Problem2
    {
        // 1. GunAdiGetir Metodu
        public static string GunAdiGetir(int gunNumarasi)
        {
            // switch-case yapısı ile gün isimlerini belirliyoruz
            switch (gunNumarasi)
            {
                case 1: return "Pazartesi";
                case 2: return "Salı";
                case 3: return "Çarşamba";
                case 4: return "Perşembe";
                case 5: return "Cuma";
                case 6: return "Cumartesi";
                case 7: return "Pazar";
                default: return "Geçersiz gün";
            }
        }

        // 2. ArtikYilMi Metodu
        public static bool ArtikYilMi(int yil)
        {
            // Kuralları öncelik sırasına göre if-else ile kontrol ediyoruz
            if (yil % 400 == 0)
            {
                return true; // 400'ün katıysa kesinlikle artık yıldır
            }
            else if (yil % 100 == 0)
            {
                return false; // 400'e bölünmeyip 100'e bölünüyorsa artık yıl değildir
            }
            else if (yil % 4 == 0)
            {
                return true; // 100'e bölünmeyip 4'e bölünüyorsa artık yıldır
            }
            else
            {
                return false; // Diğer durumlar
            }
        }

        // 3. AyinGunSayisi Metodu
        public static int AyinGunSayisi(int ay, int yil)
        {
            // switch-case ile aynı gün sayısına sahip ayları grupluyoruz (fall-through)
            switch (ay)
            {
                // 31 Gün çeken aylar
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;

                // 30 Gün çeken aylar
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;

                // Şubat ayı kontrolü
                case 2:
                    // Burada yukarıda yazdığımız ArtikYilMi metodunu kullanıyoruz
                    if (ArtikYilMi(yil))
                    {
                        return 29;
                    }
                    else
                    {
                        return 28;
                    }

                // Geçersiz ay numarası
                default:
                    return 0;
            }
        }

        // 4. HaftaIciSonuMu Metodu
        public static string HaftaIciSonuMu(int gunNumarasi)
        {
            // Ternary operatör (? :) kullanımı
            // Mantık: Sayı 1-5 arasındaysa "Hafta İçi", 6-7 ise "Hafta Sonu", hiçbiri değilse "Geçersiz"
            
            return (gunNumarasi >= 1 && gunNumarasi <= 5) ? "Hafta İçi" : 
                   (gunNumarasi == 6 || gunNumarasi == 7) ? "Hafta Sonu" : "Geçersiz Gün";
        }
    }
}
