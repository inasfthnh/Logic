using System;
namespace tryeval2
{
    public class mampubeli
    {
        public mampubeli()
        {
            Console.WriteLine("--- Kemampuan Beli ---");
            Console.Write("Masukkan Jumlah Uang : ");
            int uang = int.Parse(Console.ReadLine());
            Console.Write("Masukkan list harga barang 1 : ");
            int[] barang1 = Array.ConvertAll(Console.ReadLine().Split(','), hrg => int.Parse(hrg));

            Console.Write("Masukkan list harga barang 2 : ");
            int[] barang2 = Array.ConvertAll(Console.ReadLine().Split(','), hrg => int.Parse(hrg));

            int maxBeli = 0;
            int[] barang = new int[2];
            for (int i = 0; i < barang1.Length; i++)
            {
                for (int j = 0; j < barang2.Length; j++)
                {
                    if (barang1[i] + barang2[j] > maxBeli && barang1[i] + barang2[j] <= uang)
                    {
                        barang[0] = barang1[i];
                        barang[1] = barang2[j];
                        maxBeli = barang1[i] + barang2[j];
                    }
                }
            }

            Console.WriteLine("Barang 1 : {0}, Barang 2 : {1}, Pembelian max {2}", barang[0], barang[1], maxBeli);
            Console.ReadKey();

        }
    }
}
