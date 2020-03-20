using System;

namespace LOGIC03
{
    public class SOAL05
    {
        public SOAL05()
        {
            Console.Write("Masukkan deret     : ");
            int[] deret = Array.ConvertAll(Console.ReadLine().Split(' '), val => Convert.ToInt32(val));

            //Console.Write("Masukkan jml angka : ");
            int jmlAng = 4; /*int.Parse(Console.ReadLine());*/

            int hiSum = 0;
            int loSum = 0;
            Array.Sort(deret);

            foreach (var item in deret)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < jmlAng; i++)
            {
                hiSum += deret[deret.Length - i - 1];
                loSum += deret[i];
            }
            Console.WriteLine("HiSum : {0}, LoSum : {1}", hiSum, loSum);
            Console.ReadKey();
        }
    }
}
