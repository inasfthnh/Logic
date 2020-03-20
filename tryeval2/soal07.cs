using System;
namespace tryeval2
{
    public class soal07
    {
        public soal07()
        {
            Console.WriteLine("--- SOAL 07 Keranjang Buah---");
            Console.WriteLine("Masukkan isi dari 3 buah keranjang (salah satu harus kosong(0)) :");
            Console.Write("Keranjang 1 : ");
            int keranjang1 = int.Parse(Console.ReadLine());
            Console.Write("Keranjang 2 : ");
            int keranjang2 = int.Parse(Console.ReadLine());
            Console.Write("Keranjang 3 : ");
            int keranjang3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Keranjang mana yang akan dibawa ke pasar? (1/2/3)");
            int bawa = int.Parse(Console.ReadLine());

            int jumlah = 0;
            if (bawa == 1)
            {
                jumlah = keranjang2 + keranjang3;
            }
            else if (bawa == 2)
            {
                jumlah = keranjang1 + keranjang3;
            }
            else if (bawa == 3)
            {
                jumlah = keranjang1 + keranjang2;
            }

            Console.WriteLine("Keranjang {0} dibawa ke pasar, jumlah buah = {1}", bawa, jumlah);
        }
    }
}
