using System;
namespace topik
{
    public class WUplusminus
    {
        public WUplusminus()
        {
            Console.WriteLine("----- 03 Plus Minus -----");
            Console.WriteLine("Masukkan deret angka (pisahkan dengan spasi) :");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), val => Convert.ToInt32(val));

            decimal positif = 0;
            decimal negatif = 0;
            decimal nol = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    positif++;
                }
                else if (arr[i] < 0)
                {
                    negatif++;
                }
                else
                {
                    nol++;
                }
            }

            decimal pos = positif / arr.Length;
            decimal neg = negatif / arr.Length;
            decimal zeros = nol / arr.Length;
            Console.WriteLine("Positive : {0}\nNegative : {1}\nZeros : {2}", Math.Round(pos,6), Math.Round(neg, 6), Math.Round(zeros, 6));
            //limit decimal to 6
        }
    }
}
