using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionAllureVitesse
{
    class CalculDistanceTemps
    {
        private int allureMin;
        private int allureSec;
        private String temps;

        public int AllureMin { get => allureMin; set => allureMin = value; }
        public int AllureSec { get => allureSec; set => allureSec = value; }
        public string Temps { get => temps; set => temps = value; }


        public bool ControleValeur(String sAllureMin, String sAllureSec)
        {
            //Conversion saisie en entier
            if (!int.TryParse(sAllureMin, out allureMin))
            {
                return false;
            }
            if (!int.TryParse(sAllureSec, out allureSec))
            {
                return false;
            }

            return true;
        }

        public String CalculTemps(Double dDistance)
        {
            int allureTotaleSec;
            Double tempsTotal;

            //Conversion de l'allure en secondes
            allureTotaleSec = allureMin * 60;
            allureTotaleSec += allureSec;

            //Calcul temps total en secondes
            tempsTotal = allureTotaleSec * dDistance;

            //Conversion en TimeSpan
            TimeSpan timeSpan = TimeSpan.FromSeconds(tempsTotal);

            //Construction de la chaine et retour
            return timeSpan.Hours.ToString()+":"+ timeSpan.Minutes.ToString()+":"+ timeSpan.Seconds.ToString();
        }
    }
}
