using System;
namespace Architect
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Zadajte ktoru area chcete (Teotihuacan), (Great Mosque of Mecca) (Taj Mahal)");
            string odpoved_ = Console.ReadLine();
            string odpoved = odpoved_.ToLower();

            if (odpoved == "teotihuacan")
            {
                double areaObdlznik = Obdlznik(1500, 2500);
                double areaKruh = Kruh(187.5) / 2;
                double areaTroj = Trojuholnik(750, 500);
                //calculate totalarea
                double totalarea = areaObdlznik + areaKruh + areaTroj;
                int pesos = 180;
                double totalcost = Math.Round(totalarea * pesos,2);
                Console.WriteLine($"Total cost for Teotihuacan is {totalcost} pesos");
            }

            else if (odpoved == "great mosque of mecca")
            {
                //total area calculation
                double areaPodstava1 = Stvorec(284) - Pravtroj(264, 84);
                double areaPodstava2 = Obdlznik(180,106);
                double totalarea = areaPodstava1 + areaPodstava2;
                //calculate total cost
                int pesos = 180;
                double totalcost = Math.Round(totalarea * pesos, 2);
                Console.WriteLine($"Total cost for Great Mosque of Mecca is {totalcost} pesos");
            }
            else if (odpoved=="taj mahal")
            {
                //totalarea
                double area1 = Stvorec(90.5);
                double area2 = Pravtroj(24,24);
                double totalarea = area1 - 4* area2;

                //totalcost 

                int pesos = 180;
                double totalcost = Math.Round(totalarea*pesos,2);
                Console.WriteLine($"Total cost for Taj Mahal is {totalcost} pesos");
                
            }
        }
        //obdlznik
        static double Obdlznik(double dlzka, double sirka)
        {
            return dlzka * sirka;
        }
        //
        static double Kruh(double polomer)
        {
            return Math.PI * Math.Pow(polomer, 2);
        }

        static double Trojuholnik(double spodok, double vyska)
        {
            return 0.5 * spodok * vyska;
        }
        //stvorec
        static double Stvorec(double a)
        {
            return a*a;
        }
        //pravouhly troj.
        static double Pravtroj(double a, double b)
        {
            return a * b /2;
        }
    }
}
