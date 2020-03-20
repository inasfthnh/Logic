using System;
namespace tryeval2
{
    public class soal03
    {
        public soal03()
        {
            Console.WriteLine("----- SOAL 03 -----");
            Console.Write("Dari volume :");
            string vol1 = Console.ReadLine();
            Console.Write("Sebanyak :");
            double jumlah1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ke volume :");
            string vol2 = Console.ReadLine();

            double jumlah2 = 0;
            if (vol1 == "botol" && vol2 == "gelas")
            {
               jumlah2 = jumlah1 * 2;
            }
            else if (vol1 == "gelas" && vol2 == "botol")
            {
                jumlah2 = jumlah1 / 2;
            }
            else if (vol1 == "botol" && vol2 == "cangkir")
            {
                jumlah2 = jumlah1 * 5;
            }
            else if (vol1 == "cangkir" && vol2 == "botol")
            {
                jumlah2 = jumlah1 / 5;
            }
            else if (vol1 == "botol" && vol2 == "teko")
            {
                jumlah2 = jumlah1 * 5;
            }
            else if (vol1 == "teko" && vol2 == "botol")
            {
                jumlah2 = jumlah1 / 5;
            }
            else if (vol1 == "teko" && vol2 == "cangkir")
            {
                jumlah2 = jumlah1 * 25;
            }
            else if (vol1 == "cangkir" && vol2 == "teko")
            {
                jumlah2 = jumlah1 / 25;
            }
            else if (vol1 == "gelas" && vol2 == "cangkir")
            {
                jumlah2 = jumlah1 * 2.5;
            }
            else if (vol1 == "cangkir" && vol2 == "gelas")
            {
                jumlah2 = jumlah1 / 2.5;
            }
            else if (vol1 == "gelas" && vol2 == "teko")
            {
                jumlah2 = jumlah1 / 10;
            }
            else if (vol1 == "teko" && vol2 == "gelas")
            {
                jumlah2 = jumlah1 * 10;
            }


            Console.WriteLine("{0} {1} = {2} {3}", jumlah1, vol1, jumlah2, vol2);
        }
    }
}
