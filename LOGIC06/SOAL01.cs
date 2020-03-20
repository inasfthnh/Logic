using System;
namespace LOGIC06
{
    public class SOAL01
    {
        public SOAL01()
        {
            Console.WriteLine("----- Sherlock and Array -----");
            Console.WriteLine("Masukkan kode angka :");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), val => Convert.ToInt32(val));

            // cari posisi patokan
            for (int i = 0; i < arr.Length; i++)
            {
                // hitung sebelah kiri
                int iKiri = 0;
                if (i > 0)
                {
                    for (int j = 0; j < i; j++)
                    {
                        iKiri += arr[j];
                    }
                }
                // hitung sebelah kanan
                int iKanan = 0;
                if (i < arr.Length - 1)
                {
                    for (int j = i +1; j < arr.Length; j++)
                    {
                        iKanan += arr[j];
                    }
                }

                if (iKiri == iKanan)
                {
                    Console.WriteLine("YES, hasil kiri: {0}, kanan {1}", iKiri, iKanan);
                    break;
                }
                else
                {
                    Console.WriteLine("NO, hasil kiri: {0}, kanan {1}", iKiri, iKanan);
                }

            }
        }
    }
}
