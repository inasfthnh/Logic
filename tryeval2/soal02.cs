using System;
namespace tryeval2
{
    public class soal02
    {
        public soal02()
        {
            Console.WriteLine("1.Toko ke Tempat 1= 2KM");
            Console.WriteLine("2.Tempat 1 ke Tempat 2= 500M");
            Console.WriteLine("3.Tempat 2 ke Tempat 3= 1.5KM");
            Console.WriteLine("4.Tempat 3 ke Tempat 4= 2.5KM");
            Console.WriteLine("=============================");

            int[] arah = { 2000, 500, 1500, 2500 };

            Console.Write("Masukkan Tujuan: ");
            int tuju = int.Parse(Console.ReadLine());
            double total = 0;
            for (int i = 0; i < tuju; i++)
            {
                total += arah[i];
            }
            for (int j = tuju - 2; j >= 0; j--)
            {
                total += arah[j];
            }
            Console.WriteLine();
            Console.WriteLine("jarak tempuh\t:" + total / 1000 + "KM");
            Console.WriteLine("Bensin\t:" + Math.Ceiling(total / 2500) + " Liter");
            Console.ReadKey();
        }
    }
}
