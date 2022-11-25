//-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.- PROGRAMMA PRINCIPALE -.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-
using Geometria;
// ISTANZIO 1 rettangolo

Rettangolo rettangolo1 = new Rettangolo();

string myString = "";
int intValue;
bool controllo;

Console.Write("Inserisci il valore per la base del rettangolo: ");
do
{
    myString = Console.ReadLine();
    if (int.TryParse(myString, out rettangolo1.baseRettangolo))
    {
        controllo = true;
    }
    else
    {
        Console.WriteLine("\nHai inserito un valore errato!!!");
        controllo = false;
        Console.Write("\nInserisci UN NUMERO per define la base del rettangolo: ");
    }
} while (!controllo);

Console.WriteLine("[ Base rettangolo - " + rettangolo1.baseRettangolo + " cm - ]\n");


Console.Write("Inserisci il valore per la altezza del rettangolo: ");
do
{
    myString = Console.ReadLine();
    if (int.TryParse(myString, out rettangolo1.altezzaRettangolo))
    {
        controllo = true;
    }
    else
    {
        Console.WriteLine("\nHai inserito un valore errato!!!");
        controllo = false;
        Console.Write("\nInserisci UN NUMERO per define la altezza del rettangolo: ");
    }
} while (!controllo);

Console.WriteLine("[ Altezza rettangolo - " + rettangolo1.altezzaRettangolo + " cm - ]\n");


rettangolo1.calcolaPerimetro();

rettangolo1.calcolaArea();



