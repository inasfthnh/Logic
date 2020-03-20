using System;
namespace topik
{
    public class stringshacrank
    {
        public stringshacrank()
        {
            Console.WriteLine("----- SOAL 05 Hacker Rank in a String -----");
            Console.Write("Input query : ");
            string input = Console.ReadLine();

            string hr = "hackerrank";
            int lastpos = 0; //last position, supaya huruf yg udh kebaca ga kebaca lagi
            string hr1 = ""; // buat nyimpen sementara huruf per huruf dari hackerrank

            for (int i = 0; i < hr.Length; i++)
            {
                for (int j = lastpos; j < input.Length; j++) // j=lastpos klo blm ketemu
                {
                    if (hr.Substring(i,1) == input.Substring(j,1))
                    {
                        hr1 += input.Substring(j, 1);
                        lastpos = j + 1; // klo sdh ketemu mulai dari huruf stlhnya
                         //supaya stlh ketemu suatu huruf di hr looping lagi dari awal tp mulai dari lastpos
                    }
                }
            }

            if (hr1 == hr)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            /* if (input.Contains("hackerrank"))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            */
            //"h", "a", "c", "k", "e", "r", "r", "a", "n", "k"
        }
    }
}
