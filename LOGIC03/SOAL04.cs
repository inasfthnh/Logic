using System;
using Base;

namespace LOGIC03
{
    public class SOAL04: LogicProps
    {
        public SOAL04()
        {
            Console.WriteLine("Masukkan deret 2 dim:");
            string[] split1 = Console.ReadLine().Split(',');
            int jmlBrs = split1.Length;
            int jmlKol = 0;
            foreach (var item in split1)
            {
                string[] split2 = item.Split(' ');
                jmlKol = split2.Length;
                break;
            }
            Array2D = new string[jmlBrs, jmlKol];

            int brs = 0;
            foreach (var item1 in split1)
            {
                int kol = 0;
                string[] split2 = item1.Split(' ');
                foreach (var item2 in split2)
                {
                    Array2D[brs, kol] = item2;
                    kol++;
                }
                brs++;
            }

            LogicFunction.PrintArray(Array2D);
        }
    }
}
