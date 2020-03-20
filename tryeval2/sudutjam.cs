using System;
namespace tryeval2
{
    public class sudutjam
    {
        public sudutjam()
        {
            Console.WriteLine("--- Sudut Jam ---");
            Console.Write("Masukkan waktu : ");
            decimal[] waktu = Array.ConvertAll(Console.ReadLine().Split(':'), wkt => decimal.Parse(wkt));

            // setiap jam *30
            // setiap menit *6
            // setiap kelebihan jam /2 > 30 derajat/60 menit
            decimal sudut = Math.Abs((waktu[0] * 30) - (waktu[1] * 6) + (waktu[1] / 2));
            sudut = sudut < 180 ? sudut : 360 - sudut;
            Console.WriteLine("Sudut : {0}", sudut);
        }
    }
}
