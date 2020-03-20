using System;

namespace LOGIC02
{
    class MainClass
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Masukkan nilai N: ");
            int n = int.Parse(Console.ReadLine());
            LOGIC02 logic02 = new LOGIC02(n);
            */

            Console.Write("Masukkan kalimat: ");
            string kalimat = Console.ReadLine();
            SOAL05 soal5 = new SOAL05(kalimat);
            
        }
    }
}

