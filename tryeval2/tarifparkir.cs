using System;
namespace tryeval2
{
    public class tarifparkir
    {
        public tarifparkir()
        {
            Console.WriteLine("----- Tarif Parkir -----");
            Console.WriteLine("Parkir selama berapa jam? (jam:menit:detik)");
            decimal[] jam = Array.ConvertAll(Console.ReadLine().Split(':'), prk => decimal.Parse(prk));

            decimal parkir = 0;
            decimal totaljam = jam[0] + (jam[1] / 60) + (jam[2] / 3600);

            if (totaljam <=8)
            {
                parkir = jam[0] * 1000;
            }
            else if (totaljam > 8 && totaljam <= 24)
            {
                parkir = 8000;
            }
            else if (totaljam > 24)
            {
                parkir = 15000 + ((jam[0]-24) * 1000);
            }

            Console.WriteLine("Biaya parkir : {0}", parkir);
        }
    }
}
