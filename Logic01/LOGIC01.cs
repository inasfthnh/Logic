using System;
using Base;

namespace Logic01
{
    class LOGIC01: LogicProps
    {
        //CARA URUT ANGKA DENGAN ACUAN ANGKA SEBELUMNYA
        public LOGIC01(int n)
        {
            Array2D = new string[1, n];
            Array1D = new string[n];
            FillArray8();
            LogicFunction.PrintArray(Array2D);
            LogicFunction.PrintArray(Array1D);
            //Console.Write("Press any key to continue");
            //Console.ReadKey();
        }

        private void FillArray4()
        {
            int val = 1;
            for (int col = 0; col < Array2D.GetLength(1); col++)
            {
                Array2D[0, col] = val.ToString();
                val = val + 3;
            }
        }

        private void FillArray5()
        {
            int val = 1;
            for (int col = 0; col < Array1D.Length; col++)
            {
                if ((col + 1) % 3 == 0)
                {
                    Array1D[col] = "*";
                }
                else
                {
                    Array1D[col] = val.ToString();
                    val = val + 4;
                }
            }
        }

        private void FillArray6()
        {
            int val = 1;
            for (int col = 0; col < Array1D.Length; col++)
            {
                Array1D[col] = val.ToString();
                val = val + 4;

                if ((col+1) % 3 == 0)
                {
                    Array1D[col] = "*";
                }
            }
        }

        private void FillArray7()
        {
            int val = 2;
            for (int col = 0; col < Array1D.Length; col++)
            {
                Array1D[col] = val.ToString();
                val = val + (val * 1);
            }
        }

        private void FillArray8()
        {
            int val = 3;
            for (int col = 0; col < Array1D.Length; col++)
            {
                Array1D[col] = val.ToString();
                val = val + (val * 2);
            }
        }

        private void FillArray9()
        {
            int val = 4;
            for (int col = 0; col < Array1D.Length; col++)
            {
                if ((col + 1) % 3 == 0)
                {
                    Array1D[col] = "*";
                }
                else
                {
                    Array1D[col] = val.ToString();
                    val = val + (val * 3);
                }
            }
        }

        private void FillArray10()
        {
            int val = 3;
            for (int col = 0; col < Array1D.Length; col++)
            {
                Array1D[col] = val.ToString();
                val = val + (val * 2);

                if ((col + 1) % 4 == 0)
                {
                    Array1D[col] = "XXX";
                }
            }
        }
    }
}
