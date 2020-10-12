using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversionAllureVitesse
{
    public partial class Form1 : Form
    {
        Conversion maConversion = new Conversion();

        public Form1()
        {
            InitializeComponent();
        }

        private void tb_Distance_TextChanged(object sender, EventArgs e)
        {
           //Implémenter un contrôle sur le champ
        }

        private void btn_Calcul_Click(object sender, EventArgs e)
        {
            //Apel de la méthode qui va contrôler, convertir les valeurs et affecter les valeurs aux membres de la classe
            if (!maConversion.controleValeur(tb_Distance.Text, tb_Heure.Text, tb_Minute.Text, tb_Seconde.Text))
            {
                MessageBox.Show("La distance doit être saisie sous ce format : 42,195 \nLes heures, minutes et secondes doivent être saisies sous ce format : entier");
            }
            else
            {
                lb_Vitesse.Text = $"Vitesse : { maConversion.calculVitesse()} Km/h";
                lb_Allure.Text = $"Allure : { maConversion.calculAllure()} min/Km";
            }

        }

     
    }
}
