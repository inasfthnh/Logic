using System;
namespace Inas_Fathinah
{
    public class SOAL08
    {
        public SOAL08()
        {
            Console.WriteLine("--- SOAL 08 ---");
            Console.WriteLine("Masukkan panjang deret :");
            int panjang = int.Parse(Console.ReadLine());

            int[] deret1 = new int[panjang];
            int[] deret2 = new int[panjang];

            int jumlah;
            Console.Write("Output = ");

            for (int i = 0; i < panjang; i++)
            {

                deret1[i] = (i * 3) - 1; //-1,2,5,8,11,14,17,20
                deret2[i] = i * (-2); // 0,-2,-4,-6,-8,-10,-12,-14,-16
                // hasil = -1,0,1,0,1,2,3,4
                jumlah = deret1[i] + deret2[i];
                Console.Write(jumlah + ",");
            }

        }
    }
}
