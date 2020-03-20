using System;
using Base;

namespace LOGIC02
{
    class SOAL05 : LogicProps
    {
        public SOAL05(string kalimat)
        {
            Array1D = new string[kalimat.Length];
            FillArray(kalimat);
            Console.WriteLine("\n");
            sensor();
        }


        private void sensor()
        {
            for (int i = 0; i < Array1D.Length; i++)
            {
                if (i == 0 || i == Array1D.Length - 1) //huruf pertama & terakhir kalimat
                    Console.Write(Array1D[i]);
                else if (Array1D[i - 1] == " " || Array1D[i + 1] == " ") //huruf deket spasi
                    Console.Write(Array1D[i]);
                else if (Array1D[i] == " ") //spasi
                    Console.Write(Array1D[i]);
                else
                    Console.Write("*");
                //cetak
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
