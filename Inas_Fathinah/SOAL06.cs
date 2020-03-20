using System;
namespace Inas_Fathinah
{
    public class SOAL06
    {
        public SOAL06()
        {
            Console.WriteLine("--- SOAL 06 ---");
            Console.WriteLine("Jumlah angka dalam deret :");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Deret angka Rai (pisahkan dengan spasi) :");
            int[] raiarr = Array.ConvertAll(Console.ReadLine().Split(' '), val => int.Parse(val));
            Console.WriteLine("Deret angka Elga (pisahkan dengan spasi) :");
            int[] elgarr = Array.ConvertAll(Console.ReadLine().Split(' '), val => int.Parse(val));

            if (raiarr.Length == n && elgarr.Length == n)
            {
                int rai = 0;
                int elga = 0;
                int imbang = 0;

                for (int i = 0; i < raiarr.Length; i++)
                {
                    if (raiarr[i] > elgarr[i])
                    {
                        rai++;
                    }
                    else if (raiarr[i] < elgarr[i])
                    {
                        elga++;
                    }
                    else if (raiarr[i] == elgarr[i])
                    {
                        imbang++;
                    }
                }
                Console.WriteLine("Hasil : Rai menang {0}x, Elga menang {1}x, Imbang {2}x", rai, elga, imbang);
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }  
    }
}
