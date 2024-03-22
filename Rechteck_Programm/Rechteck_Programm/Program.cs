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
                    benutzerEingabe_höhe = Convert.ToInt16(Console.ReadLine()); // Hier Fehlt das der Benutzer auch Buchstaben eingeben kann

                    Console.Write("Geben sie jetzt die Gewünschte Breite ihres Rechtecks: ");
                    benutzerEingabe_breite = Convert.ToInt16(Console.ReadLine()); // Hier Fehlt auch das der Benutzer auch Buchstaben eingeben kann
                }
                catch (Exception e)
                {
                    eingabe = true;
                    Console.WriteLine(e);
                }
            } while (eingabe);

            Console.Clear();
            string größenEinheit = "cm";
            double faktorZoom = 3;

            //Objekt Rechteck wurde erstellt
            Rechteck rechteck = new Rechteck(benutzerEingabe_breite, benutzerEingabe_höhe);

            //Ausgabe der Objekt Werte
            Console.WriteLine($"Wenn die Breit des Rechtecks {benutzerEingabe_breite} {größenEinheit} ist und die höhe {benutzerEingabe_höhe} {größenEinheit} ist, dann ist:");
            Console.WriteLine($"• Der Umfang des Rechtecks {rechteck.Umfang} {größenEinheit}");
            Console.WriteLine($"• Die Fläche des Rechtecks {rechteck.Fläche} {größenEinheit}²");
            Console.WriteLine($"• Die Diagonale Seite des Rechtecks {rechteck.Diagonale_berchnung(größenEinheit)} {größenEinheit}");
            Console.WriteLine();
            Console.WriteLine();

            //Ausgabe des Objekt Rechteck wenn es gedreht wird
            Console.WriteLine("Wenn der Rechteck um 90° Grad gedrehen wird, dann ist: ");
            rechteck.Drehen();
            Console.WriteLine($"• Die Breite des Rechtecks {rechteck.Breite} {größenEinheit}");
            Console.WriteLine($"• Die Höhe des Rechtecks {rechteck.Höhe} {größenEinheit}");
            Console.WriteLine($"• Der Umfang des Rechtecks {rechteck.Umfang} {größenEinheit}");
            Console.WriteLine($"• Die Fläche des Rechtecks {rechteck.Fläche} {größenEinheit}²");
            Console.WriteLine($"• Die Diagonale Seite des Rechtecks {rechteck.Diagonale_berchnung(größenEinheit)} {größenEinheit}");
            Console.WriteLine();
            Console.WriteLine();

            //Ausgabe des Objekt Rechteck wenn es gezoomt wird
            Console.WriteLine($"Wenn der Rechteck um ein {faktorZoom} fache gezoomt wird, dann ist: ");
            rechteck.Zoomen(faktorZoom);
            Console.WriteLine($"• Der Umfang des Rechtecks {rechteck.Umfang} {größenEinheit}");
            Console.WriteLine($"• Die Fläche des Rechtecks {rechteck.Fläche} {größenEinheit}²");
            Console.WriteLine($"• Die Diagonale Seite des Rechtecks {rechteck.Diagonale_berchnung(größenEinheit)} {größenEinheit}");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}