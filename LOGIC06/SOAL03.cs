using System;
namespace LOGIC06
{
    public class SOAL03
    {
        public SOAL03()
        {
            Console.WriteLine("----- Minimum Loss -----");
            Console.WriteLine("Harga jual beli rumah (urutkan berdasarkan tahun) :");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), val => Convert.ToInt32(val));

            int diff = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (i == 0)
                    diff = arr[i] - arr[i + 1];

                for (int j = i+1; j < arr.Length; j++)
                {
                    if ((arr[i] - arr[j]) < diff && diff > 0)
                    {
                        diff = arr[i] - arr[i+1];
                        Console.WriteLine("Lauren buys the house in year {0} at price {1}, and sells it in year {2} " +
                         "at price {3} for a minimal loss of {1} - {3} = {4}", i + 1, arr[i], j + 1, arr[j], diff);
                    }
                }
            }

          
        }
    }
}
