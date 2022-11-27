using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class RettangoloBonus
    {
        public int ibase;
        public int ialtezza;
        public string disegnoBase = " ";
        public string disegnoLati = "";
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

        public void disegnaRettangolo()
        {
            for (ibase = 0; ibase < baseRettangolo-1; ibase++)
            {
                disegnoBase += "_";
            }
            for (ialtezza = 0; ialtezza <= altezzaRettangolo; ialtezza++)
            {
                if(ialtezza == 0)
                {
                    Console.WriteLine(disegnoBase);
                }
                else if(ialtezza == 1 || ialtezza < altezzaRettangolo)
                {
                    disegnoBase = "|";
                    for (ibase = 1; ibase <= baseRettangolo; ibase++)
                    {
                        if (ibase < baseRettangolo) { 
                            disegnoBase += " ";
                        }else if(ibase == baseRettangolo)
                        {
                            disegnoBase += "|";
                        }
                    }
                    Console.WriteLine(disegnoBase);
                }else if(ialtezza == altezzaRettangolo){
                    disegnoBase = "|";
                    for (ibase = 0; ibase < baseRettangolo; ibase++)
                    {
                        if (ibase < baseRettangolo-1)
                        {
                            disegnoBase += "_";
                        }
                        else 
                        {
                            disegnoBase += "|";
                        }
                    }
                    Console.WriteLine(disegnoBase);
                }
            }
            
        }

    }
}
