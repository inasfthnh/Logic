using System;
using Base;

namespace LOGIC02
{
    class SOAL06: LogicProps
    {
        public SOAL06(string kalimat)
        {
            Array1D = new string[kalimat.Length];
            FillArray(kalimat);
            LogicFunction.PrintArray(Array1D);
            Console.WriteLine("\n");
            CountUpper();
        }

        private void CountUpper()
        {
            int jmlUpper = 0;
            for (int i = 0; i < Array1D.Length; i++)
            {
                int temp = char.ConvertToUtf32(Array1D[i], 0);
                if (temp >= 65 && temp <= 90)
                    jmlUpper++;
            }

            Console.WriteLine("Hasilnya" + jmlUpper.ToString());
            Console.ReadKey();
        }

        private void FillArray(string kal)
        {
            char[] cArr = kal.ToCharArray();
            int idx = 0;
            foreach (var ch in cArr)
            {
                Array1D[idx++] = ch.ToString();
            }
        }
    }
}
