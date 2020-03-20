using System;
namespace LOGIC05
{
    public class SOAL03
    {
        public SOAL03()
        {
            Console.WriteLine("----- closest numbers -----");
            Console.WriteLine("Masukkan deret angka (pisahkan dengan spasi)");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), val => Convert.ToInt32(val));

            Array.Sort(arr);
            int diff = 0;

            // titik awal
            for (int i = 0; i < arr.Length - 1; i++)
            {
                //pemberi nilai awal
                if (i == 0)
                    diff = Math.Abs(arr[i] - arr[i + 1]);

                //titik akhir
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (Math.Abs(arr[i] - arr[i + 1]) < diff)
                    {
                        diff = Math.Abs(arr[i] - arr[i + 1]);
                    }
                }
            }

            Console.WriteLine("\nResult : ");

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (Math.Abs(arr[i] - arr [i+1]) == diff)
                {
                    Console.WriteLine("{0}\t{1}\t", arr[i], arr[i + 1]);
                }
            }

            Console.WriteLine();

        }
    }
}
