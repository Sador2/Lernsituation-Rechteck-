using System.Drawing;

namespace Rechteck_Programm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool eingabe = false;

            double benutzerEingabe_höhe = 0;
            double benutzerEingabe_breite = 0;
            
            do
            {
                try
                {
                    eingabe = false;

                    //Aufforderung von Benutzer Eingabe 
                    Console.WriteLine("Guten Tag!");
                    Console.Write("Geben sie die Gewünschte Höhe ihres Rechtecks: ");
                    Console.ForegroundColor = ConsoleColor.Yellow; benutzerEingabe_höhe = RichteBenutzerEingabe(Console.ReadLine()); Console.ForegroundColor = ConsoleColor.White;

                    Console.Write("Geben sie jetzt die Gewünschte Breite ihres Rechtecks: ");
                    benutzerEingabe_breite = RichteBenutzerEingabe(Console.ReadLine());
                }
                catch (Exception e)
                {
                    eingabe = true;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            } while (eingabe);

            Console.Clear();
            string größenEinheit = "cm";
            double faktorZoom = 3;

            //Objekt Rechteck wurde erstellt
            Rechteck rechteck = new Rechteck(benutzerEingabe_breite, benutzerEingabe_höhe);

            //Ausgabe der Objekt Werte
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Wenn die Breit des Rechtecks {benutzerEingabe_breite} {größenEinheit} ist und die höhe {benutzerEingabe_höhe} {größenEinheit} ist, dann ist:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"• Der Umfang des Rechtecks {rechteck.Umfang} {größenEinheit}");
            Console.WriteLine($"• Die Fläche des Rechtecks {rechteck.Fläche} {größenEinheit}²");
            Console.WriteLine($"• Die Diagonale Seite des Rechtecks {rechteck.Diagonale_berchnung(größenEinheit)} {größenEinheit}");
            Console.WriteLine();
            Console.WriteLine();

            //Ausgabe des Objekt Rechteck wenn es gedreht wird
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Wenn der Rechteck um 90° Grad gedrehen wird, dann ist: ");
            Console.ForegroundColor = ConsoleColor.White;
            rechteck.Drehen();
            Console.WriteLine($"• Die Breite des Rechtecks {rechteck.Breite} {größenEinheit}");
            Console.WriteLine($"• Die Höhe des Rechtecks {rechteck.Höhe} {größenEinheit}");
            Console.WriteLine($"• Der Umfang des Rechtecks {rechteck.Umfang} {größenEinheit}");
            Console.WriteLine($"• Die Fläche des Rechtecks {rechteck.Fläche} {größenEinheit}²");
            Console.WriteLine($"• Die Diagonale Seite des Rechtecks {rechteck.Diagonale_berchnung(größenEinheit)} {größenEinheit}");
            Console.WriteLine();
            Console.WriteLine();

            //Ausgabe des Objekt Rechteck wenn es gezoomt wird
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Wenn der Rechteck um ein {faktorZoom} fache gezoomt wird, dann ist: ");
            Console.ForegroundColor = ConsoleColor.White;
            rechteck.Zoomen(faktorZoom);
            Console.WriteLine($"• Der Umfang des Rechtecks {rechteck.Umfang} {größenEinheit}");
            Console.WriteLine($"• Die Fläche des Rechtecks {rechteck.Fläche} {größenEinheit}²");
            Console.WriteLine($"• Die Diagonale Seite des Rechtecks {rechteck.Diagonale_berchnung(größenEinheit)} {größenEinheit}");
            Console.WriteLine();
            Console.WriteLine();
        }

        //Die Methode überprüft das der Benutzer nur Zahlen eingebt
        static double RichteBenutzerEingabe(string eingabe)
        {
            
            if (eingabe.Contains("\"")|| eingabe.Contains("\\") || eingabe.Contains("@") ||
                eingabe.Contains("#") || eingabe.Contains("'") || eingabe.Contains("§") ||
                eingabe.Contains("*") || eingabe.Contains("+") || eingabe.Contains("-") ||
                eingabe.Contains(".") || eingabe.Contains(":") || eingabe.Contains("_") ||
                eingabe.Contains("<") || eingabe.Contains(">") || eingabe.Contains("|") ||
                eingabe.Contains(",") || eingabe.Contains(";") || eingabe.Contains("~") ||
                eingabe.Contains("´") || eingabe.Contains("{") || eingabe.Contains("}") ||
                eingabe.Contains("(") || eingabe.Contains(")") || eingabe.Contains("=") ||
                eingabe.Contains("[") || eingabe.Contains("]") || eingabe.Contains("?") ||
                eingabe.Contains("$") || eingabe.Contains("%") || eingabe.Contains("ß"))
            {
                throw new Exception("Nur Zahlen werden akzeptiert");
            }

            for (char buchstabe = 'a'; buchstabe <= 'z'; buchstabe++)
            {
                if (eingabe.Contains(buchstabe))
                {
                    throw new Exception("Keine Buchstabe nur Zahlen werden akzeptiert");
                }
            }
            for (char buchstabe = 'A'; buchstabe <= 'Z'; buchstabe++)
            {
                if (eingabe.Contains(buchstabe))
                {
                    throw new Exception("Keine Buchstabe nur Zahlen werden akzeptiert");
                }
            }
            return Convert.ToDouble(eingabe);
        }
    }
}