using System;
using Base;

namespace LOGIC03
{
    class SOAL03
    {
        public SOAL03()
        {
            Console.WriteLine("Masukkan nilai untuk Alice (skala 1-100) (pisahkan dengan koma) :");
            string a = Console.ReadLine();
            string[] arr = a.Split(',');

            Console.WriteLine("Masukkan nilai untuk Bob (skala 1-100) (pisahkan dengan koma) :");
            string b = Console.ReadLine();
            string[] brr = b.Split(',');

            count(arr, brr);
            int[] result = count(arr, brr);
            hasil(result);
            //count(arr, brr);

        }

        private int count(string[] arr, string[] brr)
        {
            int[] result = new int[2];
            int alice = 0;
            int bob = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (int.Parse(arr[i]) > int.Parse(brr[i]))
                {
                    alice++;
                }
                else if (int.Parse(arr[i]) < int.Parse(brr[i]))
                {
                    bob++;
                }
            }

            result[0] = alice;
            result[1] = bob;
            return result;

            //hasil(alice, bob);
            //return (0);
            //utk return int, utk return string pakai return("")
        }

        private void hasil(int alice, int bob)
        {
            Console.WriteLine("Poin [Alice,Bob] : [" + alice + "," + bob + "]");
        }

    }
}
