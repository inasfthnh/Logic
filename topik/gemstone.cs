using System;
namespace topik
{
    public class gemstone
    {
        public gemstone()
        {
            Console.WriteLine("--- Gemstone ---");
            Console.Write("Masukkan string arr : ");
            string[] kata = Console.ReadLine().Split(' ');

            string lib = "";
            string lib2 = "";

            //ambil koleksi library
            for (int i = 0; i < kata[0].Length; i++)
            {
                if (!lib.Contains(kata[0].Substring(i, 1)))
                    lib += kata[0].Substring(i, 1);
            }

            //bandingkan dgn kata selanjutnya
            for (int i = 1; i < kata.Length; i++)
            {
                for (int j = 0; j < lib.Length; j++)
                {
                    if (kata[i].Contains(lib.Substring(j, 1)))
                        lib2 += lib.Substring(j, 1);
                }
                lib = lib2;
                lib2 = "";
            }

            Console.WriteLine(lib + " => " + lib.Length);
            Console.ReadKey();
        }
    }
}
