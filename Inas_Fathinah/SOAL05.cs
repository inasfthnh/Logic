using System;
namespace Inas_Fathinah
{
    public class SOAL05
    {
        public SOAL05()
        {
            Console.WriteLine("--- SOAL 05 ---");
            Console.WriteLine("Masukkan kalimat 1 :");
            string kal1 = Console.ReadLine();
            Console.WriteLine("Masukkan kalimat 2 :");
            string kal2 = Console.ReadLine();
            Console.WriteLine("Jumlah karakter sama yang diinginkan :");
            int n = int.Parse(Console.ReadLine());

            string gabung = kal1 + kal2;
            string kar = "";

            for (int i = 0; i < gabung.Length - 1; i++)
            {
                for (int j = i + 1; j < gabung.Length; j++)
                {
                    if (gabung.Substring(i, 1) == gabung.Substring(j, 1))
                    {

                        kar += gabung.Substring(i, 1);
                        Console.WriteLine(gabung[i] + ",");
                    }
                }
            }
            Console.WriteLine("Jumlah karakter : {0}", kar.Length);

        }
    }
}
