using System;
namespace LOGIC06
{
    public class SOAL02
    {
        public SOAL02()
        {
            Console.WriteLine("----- Search Pairs -----");
            Console.WriteLine("Masukkan deret angka (pisahkan dengan spasi");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), val => Convert.ToInt32(val));
            Array.Sort(arr);
            Array.Reverse(arr);

            Console.Write("Input difference : ");
            int diff = 0;

                foreach (var item in arr)
                {
                    Console.Write(item + "\t");
                }
            Console.WriteLine();

            int match = 0;
            // titik depan
            for (int i = 0; i < arr.Length; i++)
            {
                //titik belakang
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (Math.Abs(arr[i] - arr[j]) == diff)
                    {
                        Console.WriteLine("Match {0} & {1}", arr[i], arr[j]);
                        match++;
                    }
                }
            }

            Console.WriteLine("\nTotal match: {0}", match);
            Console.ReadLine();

        }
    }
}
