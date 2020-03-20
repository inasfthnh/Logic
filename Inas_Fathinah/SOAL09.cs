using System;
namespace Inas_Fathinah
{
    public class SOAL09
    {
        public SOAL09()
        {
            Console.WriteLine("--- SOAL 09 ---");
            Console.WriteLine("Tanggal 1 adalah hari :");
            string hari = Console.ReadLine();
            Console.WriteLine("Ada berapa hari libur nasional?");
            int libur = int.Parse(Console.ReadLine());
            Console.WriteLine("Tanggal - tanggal libur nasional (pisahkan dengan koma):");
            int[] tanggal = Array.ConvertAll(Console.ReadLine().Split(','), val => int.Parse(val));

            int tambah = 0;

            for (int i = 0; i <= libur; i++)
            {
                if ((hari == "sabtu" || hari == "minggu") && tanggal[i] == 1)
                {
                    tambah = libur - 1;
                }
            }

            Console.WriteLine("Tambahan hari libur : {0}", tambah);
        }
    }
}
