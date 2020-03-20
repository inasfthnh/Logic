using System;
namespace LOGIC03
{
    class SOAL06
    {
        public SOAL06()
        {
            Console.Write("Masukkan banyak angka yang dijumlah : ");
            int val = int.Parse(Console.ReadLine());
            int[] angka = new int[val];
            int total = 0;
            for (int i = 1; i <= val; i++)
            {
                Console.Write("angka {0} = ", i);
                angka[i - 1] = int.Parse(Console.ReadLine());
                total = total + angka[i - 1];
            }

            Console.WriteLine("Total = {0}", total);

        }
    }
}
