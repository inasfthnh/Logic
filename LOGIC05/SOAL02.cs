using System;
namespace LOGIC05
{
    public class SOAL02
    {
        public SOAL02()
        {
            Console.WriteLine("----- Find the median -----");
            Console.WriteLine("Masukkan deret angka (pisahkan dengan spasi)");
            decimal[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), val => Convert.ToDecimal(val));

            Array.Sort(arr); // SYNTAX SORT
            int mid = 0;
            decimal median = 0;

            if (arr.Length % 2 == 1)
            {
                mid = arr.Length / 2;
                Console.WriteLine("Nilai tengah : {0}", arr[mid]);
                median = arr[mid];
            }
            else
            {
                mid = (arr.Length / 2) - 1;
                Console.WriteLine("Nilai tengah : {0} & {1}", arr[mid], arr[mid+1]);
                median = (arr[mid] + arr[mid + 1]) / 2;
            }
            Console.WriteLine("Median : {0}", median);
        }
    }
}
