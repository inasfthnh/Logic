using System;
namespace Logic
{
    class soallogic
    {
        // CARA URUT ANGKA DENGAN ACUAN ANGKA 0 1 2 3 DST
        public soallogic()
        {
            Console.Write("Masukkan nilai N: ");
            int n = int.Parse(Console.ReadLine());
            cetak7(n);
            
        }

        //SOAL 01
        private void cetak1(int n)
        {
            for (int I = 0; I < n; I++)
            {
                Console.Write(I * 2 + 1 + "\t");
            }
        }

        //SOAL 02
        private void cetak2(int n)
        {
            for (int I = 0; I < n; I++)
            {
                Console.Write(I * 2 + 2 + "\t");
            }
        }

        //SOAL 03
        private void cetak3(int n)
        {
            for (int I = 0; I < n; I++)
            {
                Console.Write(I * 3 + 1 + "\t");
            }
        }

        //SOAL 05
        private void cetak5(int n)
        {
            for (int I = 0; I < n; I++)
            {
                for (int J = 0; J < 2; J++)
                {
                    Console.Write(J*2+1 + "*");
                }

                Console.Write(I * 4 + 1 + "\t");
            }
        }

        //SOAL 07
        private void cetak7(int n)
        {
            for (int I = 1; I < n; I++)
            {
                Console.Write((Math.Pow(2, I)) + "\t");
                //perpangkatan : Math.Pow(nilai,pangkat)
            }
        }

    }
}
