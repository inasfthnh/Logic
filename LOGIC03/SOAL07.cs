using System;
namespace LOGIC03
{
    public class SOAL07
    {
        public SOAL07()
        {
            Console.Write("Region         : ");
            int[] region = Array.ConvertAll<string, int>(Console.ReadLine().Split(' '), int.Parse);

            Console.Write("Pos. Pohon [A O]: ");
            int[] pos = Array.ConvertAll<string, int>(Console.ReadLine().Split(' '), int.Parse);

            Console.Write("Apple Fall     : ");
            int[] appFall = Array.ConvertAll<string, int>(Console.ReadLine().Split(' '), int.Parse);

            Console.Write("Orange Fall    : ");
            int[] orgFall = Array.ConvertAll<string, int>(Console.ReadLine().Split(' '), int.Parse);

            int[] hasil = CountFall(region, pos, appFall, orgFall);

            Console.WriteLine("Appel : {0}, Orange : {1}", hasil[0], hasil[1]);
            Console.ReadKey();

        }

        private int[] CountFall(int[] region, int[] pos, int[] appFall, int[] orgFall)
        {
            int[] result = new int[2];
            for (int po = 0; po < pos.Length; po++)
            {
                //Apple
                if (po == 0)
                {
                    foreach (var fall in appFall)
                    {
                        Console.WriteLine("Apple fall from {0} to {1}", pos[po], pos[po] + fall);
                        if (pos[po] + fall >= region[0] && pos[po] + fall <= region[1])
                        {
                            Console.WriteLine("Di dalam region");
                            result[0]++;
                        }
                        else
                            Console.WriteLine("Di luar region");
                    }
                }
                // Orange
                else
                {
                    foreach (var fall in orgFall)
                    {
                        Console.WriteLine("Orange fall from {0} to {1}", pos[po], pos[po] + fall);
                        if (pos[po] + fall >= region[0] && pos[po] + fall <= region[1])
                        {
                            Console.WriteLine("Di dalam region");
                            result[1]++;
                        }
                        else
                            Console.WriteLine("Di luar region");
                    }
                }
            }

            return result;
        }
    }
}
