using System;
namespace tryeval2
{
    public class soal01
    {
        public soal01()
        {
            Console.WriteLine("\t Pulsa");
            Console.Write("Beli Pulsa =");
            int pulsa = int.Parse(Console.ReadLine());
            int mm = 0;
            int ll = 0;

            if (pulsa > 10000 && pulsa < 30001)
            {
                mm = (pulsa - 10000) / 1000;
            }
            else if (pulsa > 30000)
            {
                int a = (pulsa - 30000);
                ll = (a / 1000) * 2;
                mm = 20;
            }
            else
            {
                Console.WriteLine("Anda tidak mendapatkan Point!!");
            }
            int jml = mm + ll;
            Console.WriteLine("output\t: " + "0 + " + mm + " + " + ll + " = " + jml);
        }
    }
}
