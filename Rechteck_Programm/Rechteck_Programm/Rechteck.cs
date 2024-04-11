using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechteck_Programm
{
    internal class Rechteck
    {
        //Dekladieren von Attribute
        private double breite;
        private double höhe;

        //Dekladieren der Eigenschaft Breite
        public double Breite
        {
            get { return breite; }
            set
            {
                if (value >= 0)
                {
                    breite = value;
                }
                else
                {
                    throw new Exception("breite darf nicht Negative oder ein Buchstabe sein");
                }
            }
        }

        //Dekladieren der Eigenschaft Höhe
        public double Höhe
        {
            get { return höhe; }
            set
            {
                if (value >= 0)
                {
                    höhe = value;
                }
                else
                {
                    throw new Exception("höhe darf nicht Negative oder ein Buchstabe sein");
                }
            }
        }

        //Dekladieren der Eigenschaft Umfang
        public double Umfang
        {
            get { return 2 * höhe + 2 * breite; }
        }

        //Dekladieren der Eigenschaft Fläche
        public double Fläche
        {
            get { return höhe * breite; }
        }


        //Konstruktoren 
        public Rechteck(double seite)
        {
            Breite = seite;
            Höhe = seite;
        }

        public Rechteck(double breite, double höhe)
        {
            Breite = breite;
            Höhe = höhe;
        }

        //Methoden zur berechnung der Diagnole
        public double Diagonale_berchnung(string einheit)
        {
            if (einheit != "cm" && einheit != "Zoll")
            {
                throw new Exception("Entweder cm oder Zoll");
            }

            else
            {
                if (einheit == "Zoll")
                {
                    return Math.Sqrt(Breite * Höhe)* 0.39370079;
                }
                return Math.Sqrt(Breite * Höhe);
            }
        }

        //Methoden zur berechnung des Zoomen
        public void Zoomen(double faktor)
        {
            Breite *= faktor;
            Höhe *= faktor; 
        }

        //Methoden um den Rechteck zu derehen
        public void Drehen()
        {
            double b = Höhe;

            Höhe = Breite;
            Breite = b;
        }
    }
}
