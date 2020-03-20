using System;
namespace LOGIC04
{
    public class SOAL04
    {
        public SOAL04()
        {
            Console.WriteLine("Input Signal");
            string signal = Console.ReadLine();
            int output = 0;

            for (int i = 0; i < signal.Length; i+=3)
            {
                if (signal.Substring(i,3) != "SOS" && signal.Substring(i, 3) != "sos")
                {
                    output++;
                }
            }

            Console.WriteLine("difference : {0}", output);
        }
    }
}
