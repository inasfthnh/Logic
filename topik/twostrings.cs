using System;
namespace topik
{
    public class twostrings
    {
        public twostrings()
        {
            Console.WriteLine("--- SOAL 10 Two Strings ---");
            Console.Write("Masukkan string arr : ");
            string[] kata = Console.ReadLine().Split(' ');

            string lib = "";
            for (int i = 0; i < kata[0].Length; i++)
            {
                for (int j = 0; j < kata[1].Length; j++)
                {
                    if (kata[1].Contains(kata[0].Substring(i, 1)))
                    {
                        lib += kata[0].Substring(i, 1);
                        break;
                    }
                }
            }

            Console.WriteLine(lib);
            if (lib.Length > 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
           
        }
    }
}

