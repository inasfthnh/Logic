using System;
namespace topik
{
    public class anagrams
    {
        public anagrams()
        {
            Console.WriteLine("--- SOAL 09 String: Making Anagrams ---");
            Console.Write("Masukkan string arr : ");
            string[] kata = Console.ReadLine().Split(' ');

            string lib = kata[0];

            //bandingkan dgn kata selanjutnya
            for (int i = 0; i < kata[1].Length; i++)
            {
                if (lib.IndexOf(kata[1].Substring(i, 1)) > -1)
                {
                    lib = lib.Remove(lib.IndexOf(kata[1].Substring(i, 1)), 1);
                }
                else
                {
                    lib += kata[1].Substring(i, 1);
                }
            }

            Console.WriteLine(lib + " => " + lib.Length);
        }
    }
}
