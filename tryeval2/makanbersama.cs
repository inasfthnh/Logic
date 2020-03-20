using System;
namespace tryeval2
{
    public class makanbersama
    {
        public makanbersama()
        {
            Console.WriteLine("--- Makan Bersama ---");
            Console.Write("Harga tiap makanan (makanan ke-1 mengandung ikan) : ");
            double[] harga = Array.ConvertAll(Console.ReadLine().Split(','), hrg => double.Parse(hrg));

            double[] bagi = new double[2] { 0, 0 };
            for (int i = 0; i < harga.Length; i++)
            {
                bagi[0] = harga[0] + (harga[0] * 0.15);
            }
            for (int i = 1; i < harga.Length; i++)
            {
                bagi[1] += harga[i];
            }

            bagi[1] = bagi[1] + (bagi[1] * 0.15);
            Console.Write("Harga yang harus dibayar untuk si alergi ikan : {0}, dan lainnya : {1}", bagi[1]/4, bagi[0]/3 + bagi[1]/4);
        }
    }
}