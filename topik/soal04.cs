using System;
namespace tryeval2
{
    public class soal04
    {
        public soal04()
        {
            Console.WriteLine("--- SOAL 03 Diskon OPO ---");
            int saldo1 = int.Parse(Console.ReadLine());
            int order = int.Parse(Console.ReadLine());
            int diskon = order * 50 / 100;
            int harga;
            int cashback = harga * 10 / 100;

            if (diskon <= 100000 && order >= 40000)
            {
                harga = order - diskon;
            }

            



        }
    }
}
