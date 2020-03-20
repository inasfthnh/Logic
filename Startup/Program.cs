using System;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string repeat = "Y";
                while (repeat.ToUpper() == "Y")
                {
                    Console.Write("Masukkan logic ke : ");
                    int logicNum = int.Parse(Console.ReadLine());
                    switch (logicNum)
                    {
                        case 1:
                            // Logic 01
                            Logic01.Program prog01 = new Logic01.Program();
                            break;
                        case 2:
                            LOGIC02.Program prog02 = new LOGIC02.Program();
                            break;
                        case 3:
                            LOGIC03.Program prog03 = new LOGIC03.Program();
                            break;
                        default:
                            break;
                    }

                    Console.Write("Lanjut ketik Y/y : ");
                    repeat = Console.ReadLine();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }

        }
    }
}
