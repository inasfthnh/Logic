using System;
using Base;

namespace LOGIC02
{
    class SOAL08: LogicProps
    {
        public SOAL08(string kalimat)
        {
            Array1D = new string[kalimat.Length];
            FillArray(kalimat);
            Console.WriteLine("\n");
            dibalik();
        }

        private void dibalik()
        {
            for (int I = 0; I < Array1D.Length; I++)
            {
                //Array1D[I] = Array1D[Array1D.Length - I - 1];
                Console.Write(Array1D[Array1D.Length - I - 1]);
            }
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
