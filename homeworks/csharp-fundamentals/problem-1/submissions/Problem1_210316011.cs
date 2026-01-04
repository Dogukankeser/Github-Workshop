using System;

namespace CSharpHomework
{
    public class Problem1
    {
        // 1. HesaplaOrtalama Metodu
        public static double HesaplaOrtalama(int vize, int final)
        {
            // Vizenin %40'ı, Finalin %60'ı alınır
            double ortalama = (vize * 0.4) + (final * 0.6);
            return ortalama;
        }

        // 2. BelirleHarfNotu Metodu
        public static string BelirleHarfNotu(double ortalama, int final)
        {
            // ÖNEMLİ KURAL: Final 50'den düşükse ortalama ne olursa olsun FF döner.
            if (final < 50)
            {
                return "FF";
            }

            // Eğer final barajını geçtiyse ortalamaya bakılır
            if (ortalama >= 90) return "AA";
            else if (ortalama >= 85) return "BA";
            else if (ortalama >= 80) return "BB";
            else if (ortalama >= 75) return "CB";
            else if (ortalama >= 70) return "CC";
            else if (ortalama >= 65) return "DC";
            else if (ortalama >= 60) return "DD";
            else if (ortalama >= 50) return "FD";
            else return "FF";
        }

        // 3. BelirleGecmeDurumu Metodu
        public static string BelirleGecmeDurumu(string harfNotu)
        {
            // Geçme Durumları
            if (harfNotu == "AA" || harfNotu == "BA" || harfNotu == "BB" || harfNotu == "CB" || harfNotu == "CC")
            {
                return "Geçti";
            }
            // Şartlı Geçme Durumları
            else if (harfNotu == "DC" || harfNotu == "DD")
            {
                return "Şartlı Geçti";
            }
            // Kalma Durumları (FD, FF veya geçersiz notlar için)
            else
            {
                return "Kaldı";
            }
        }
    }
}
