using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rettangolo
    {
        // CARATTERISTICHE
        public int baseRettangolo;
        public int altezzaRettangolo;
        // STATO
        public int areaRettangolo;
        public int perimetroRettangolo;

        // METODI
        public void calcolaArea()
        {
            areaRettangolo = baseRettangolo * altezzaRettangolo;
            Console.WriteLine("L'area del rettangolo è: " + areaRettangolo + " cm2");
        }
        public void calcolaPerimetro()
        {
            perimetroRettangolo = (baseRettangolo + altezzaRettangolo) * 2;
            Console.WriteLine("\nIl perimetro del rettangolo è: " + perimetroRettangolo + " cm");
        }


        public void StampaAuto()
        {
            Console.WriteLine("Base: \t" + baseRettangolo + " cm");
            Console.WriteLine("Altezza: \t" + altezzaRettangolo + " cm");
            Console.WriteLine("Perimetro: \t" + perimetroRettangolo + " cm");
            Console.WriteLine("Area: \t" + areaRettangolo + " cm2");
        }

    }
}
