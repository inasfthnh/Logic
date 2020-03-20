using System;
namespace Inas_Fathinah
{
    public class SOAL04
    {
        public SOAL04()
        {
            Console.WriteLine("--- SOAL 04 ---");
            Console.WriteLine("Masukkan deret angka (pisahkan dengan koma) :");
            double[] narr = Array.ConvertAll(Console.ReadLine().Split(','), val => double.Parse(val));

            double[] output = new double[narr.Length];

            for (int i = 0; i < narr.Length; i++)
            {
                if (narr[i] > 0)
                {
                    output[i] = narr[i] / narr.Length;
                    Console.WriteLine("Output : {0}", Math.Round(output[i], 2));
                }
            }

        }
    }
}
