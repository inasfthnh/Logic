using System;
namespace Inas_Fathinah
{
    public class SOAL03
    {
        public SOAL03()
        {
            Console.WriteLine("--- SOAL 03 ---");
            Console.WriteLine("Masukkan kalimat (huruf kecil) :");
            string kal = Console.ReadLine();
            Console.WriteLine("Masukkan array angka sesuai banyak huruf (pisahkan dengan koma) :");
            int[] n = Array.ConvertAll(Console.ReadLine().Split(','), val => Convert.ToInt32(val));

            char[] charkal = kal.ToCharArray();

            for (int i = 0; i < charkal.Length; i++)
            {
                if (charkal[i] == n[i] + 96)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
        }
    }
}
