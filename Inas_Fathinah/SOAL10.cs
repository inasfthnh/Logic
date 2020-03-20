using System;
namespace Inas_Fathinah
{
    public class SOAL10
    {
        public SOAL10()
        {
            Console.WriteLine("--- SOAL 10 ---");
            Console.Write("Tanggal pemesanan :");
            int tanggal = int.Parse(Console.ReadLine());
            Console.Write("Hari pemesanan : ");
            string hari = Console.ReadLine();

            Console.WriteLine("Hari libur nasional (pisahkan dengan koma) :");
            int[] libur = Array.ConvertAll(Console.ReadLine().Split(','), val => int.Parse(val));

            int tanggal1 = 0;
            int tanggal2 = 0;
            if (hari == "sabtu")
            {
                tanggal1 = tanggal + 10;
            }
            else if (hari == "minggu" || hari == "senin" || hari == "selasa" || hari == "rabu")
            {
                tanggal1 = tanggal + 9;
            }
            else if (hari == "kamis" || hari == "jumat")
            {
                tanggal1 = tanggal + 11;
            }

            // bingung cara nentuin tanggal-tanggal libur hari apa saja..
            // dibuat kondisi sesuai contoh..
            for (int i = 0; i < libur.Length; i++)
            {
                if (libur.Length == 2)
                {
                    tanggal2 = tanggal1 + 1;
                }
            }


            if (tanggal1 > 31)
            {
                Console.WriteLine("Tanggal {0} di bulan berikutnya", tanggal2 - 31);
            }
            else
            {
                Console.WriteLine("Tanggal {0} di bulan yang sama", tanggal2);
            }
        }
    }
}
