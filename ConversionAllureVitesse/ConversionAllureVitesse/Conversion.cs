using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionAllureVitesse
{
    class Conversion
    {
        private double distance;
        private int heure;
        private int minute;
        private int seconde;
        private double vitesse;
        private double allure;

        public double Distance { get => distance; set => distance = value; }
        public int Heure { get => heure; set => heure = value; }
        public int Minute { get => minute; set => minute = value; }
        public int Seconde { get => seconde; set => seconde = value; }
        public double Vitesse { get => vitesse; set => vitesse = value; }
        public double Allure { get => allure; set => allure = value; }

        public Conversion()
        {

        }

        public bool controleValeur(String sDistance, String sHeure, String sMinute, String sSeconde)
        {
            sDistance = sDistance.Replace(".", ",");

            //Distance
            if (!Double.TryParse(sDistance, out this.distance))
            {
                return false;
            }
            else
            {
                //Distance en mètres
                this.distance = this.distance * 1000;
            }
            //Heure
            if (!int.TryParse(sHeure, out this.heure))
            {
                return false;
            }
            //Minute
            if (!int.TryParse(sMinute, out this.minute))
            {
                return false;
            }
            //Seconde
            if (!int.TryParse(sSeconde, out this.seconde))
            {
                return false;
            }


            return true;
        }

        public String calculVitesse()
        {
            double dTempsTotal;
            double dVitesse;

            //On remet tout en secondes
            dTempsTotal = this.heure * 3600;
            dTempsTotal += this.minute * 60;
            dTempsTotal += this.seconde;

            //Calcul de la vitesse = distance / temps total en seconde * 3.6
            dVitesse = this.distance / dTempsTotal * 3.6;
            this.vitesse = dVitesse;
            //Arrondit à 2 décimales
            dVitesse = Math.Round(dVitesse, 2);
            //Conversion en string et affectation au membre vitesse
            return dVitesse.ToString();
        }

        public String calculAllure()
        {
            double dAllure;
            int intPart;
            double decimalPart;
            String sAllure;

            dAllure = 60 / this.vitesse;
            intPart = (int)dAllure;
            decimalPart = (dAllure - intPart) * 60;
            decimalPart = Math.Round(decimalPart);

            if (decimalPart.ToString().Length == 1)
            {
                sAllure = intPart.ToString() + ":0" + decimalPart.ToString();
            }
            else
            {
                sAllure = intPart.ToString() + ":" + decimalPart.ToString();
            }

            return sAllure;

        }



    }
}
