using System;
using Base;

namespace LOGIC02
{
    class LOGIC02: LogicProps
    {
        public LOGIC02(int n)
        {
            Array2D = new string[2,n];
            FillArray7();
            LogicFunction.PrintArray(Array2D);
            //Console.Write("Press any key to continue");
            //Console.ReadKey();
        }

        private void FillArray1()
        {
            // baris 0
            for (int I = 0; I < Array2D.GetLength(1); I++)
            {
                Array2D[0, I] = I.ToString();
            }

            //baris 1
            for (int I = 0; I < Array2D.GetLength(1); I++)
            {
                Array2D[1, I] = (Math.Pow(3, I)).ToString();
            }
        }

        private void FillArray2()
        {
            // baris 0
            for (int I = 0; I < Array2D.GetLength(1); I++)
            {
                Array2D[0, I] = I.ToString();
            }

            //baris 1
            for (int I = 0; I < Array2D.GetLength(1); I++)
            {
                Array2D[1, I] = (Math.Pow(3, I)).ToString();

                if ((I + 1) % 3 == 0)
                {
                    Array2D[1,I] = "-" + (Math.Pow(3, I)).ToString();
                }
            }
        }

        private void FillArray3()
        {
            // baris 0
            for (int I = 0; I < Array2D.GetLength(1); I++)
            {
                Array2D[0, I] = I.ToString();
            }

            // utk kondisi beda, perhitungan beda, urutan sama, tp susah ketemu ditengah
            /*
            int x = 3;
            //baris 1
            for (int I = 0; I < Array2D.GetLength(1); I++)
            {
               
                if (I < Array2D.GetLength(1)/2)
                {
                    Array2D[1, I] = x.ToString();
                    x = x + 3;
                }
                else if (I >= Array2D.GetLength(1)/2)
                {
                    Array2D[1, I] = x.ToString();
                    x = x - 3;
                }
            }
            */

            // utk kondisi beda, perhitungan sama, urutan beda
            //baris 1
            for (int I = 0; I < Array2D.GetLength(1); I++)
            {
                if (I <= Array2D.GetLength(1) / 2)
                {
                    Array2D[1, I] = (3 * (I + 1)).ToString();
                    Array2D[1, Array2D.GetLength(1) - I - 1] = (3 * (I + 1)).ToString();
                }
            }
        }

        private void FillArray4()
        {
            int x = 1;
            int y = 5;
            //baris 0
            for (int I = 0; I < Array2D.GetLength(1); I++)
            {
                Array2D[0, I] = I.ToString();
            }

            //baris 1
            for (int I = 0; I < Array2D.GetLength(1); I++)
            {
                if (I % 2 == 0)
                {
                    Array2D[1, I] = x.ToString();
                    x = x + 1;
                }
                else
                {
                    Array2D[1, I] = y.ToString();
                    y = y + 5;
                }

            }
        }

        private void FillArray7()
        {
            int x = 1;
            //baris 1
            for (int I = 0; I < Array2D.GetLength(1); I++)
            {
                Array2D[0, Array2D.GetLength(1) - I - 1] = I.ToString();
            }

            //baris 2
            for (int I = 0; I < Array2D.GetLength(1); I++)
            {
                Array2D[1,I] = x.ToString();
                x = x + (x * 2);

                if ((I + 1) % 3 == 0)
                {
                    Array2D[1,I] = "XXX";
                }
            }
        }
    }
}
