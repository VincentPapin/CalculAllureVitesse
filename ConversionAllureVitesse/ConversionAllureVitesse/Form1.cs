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
            CalculVitesseAllure calculVitesseAllure = new CalculVitesseAllure();
            //Apel de la méthode qui va contrôler, convertir les valeurs et affecter les valeurs aux membres de la classe
            if (!calculVitesseAllure.ControleValeur(tb_Distance.Text, tb_Heure.Text, tb_Minute.Text, tb_Seconde.Text))
            {
                MessageBox.Show("La distance doit être saisie sous ce format : 42,195 \nLes heures, minutes et secondes doivent être saisies sous ce format : entier");
            }
            else
            {
                //Appel des méthodes de calcul de vitesse et allure et affichage des valeurs
                lb_Vitesse.Text = $"Vitesse : { calculVitesseAllure.CalculVitesse()} Km/h";
                lb_Allure.Text = $"Allure : { calculVitesseAllure.CalculAllure()} min/Km";
            }

        }

        private void btn_CalculDistanceTemps_Click(object sender, EventArgs e)
        {
            CalculDistanceTemps calculDistanceTemps = new CalculDistanceTemps();

            if (!calculDistanceTemps.ControleValeur(tb_AllureMin.Text, tb_AllureSec.Text))
            {
                MessageBox.Show("L'allure doit être saisie sous ce format : entier");
            }
            else
            {
                //Calcul sur différentes distances :
                lv_DistanceTemps.Items.Add($"5 Kms : {calculDistanceTemps.CalculTemps(5)}");
                lv_DistanceTemps.Items.Add($"10 Kms : {calculDistanceTemps.CalculTemps(10)}");
                lv_DistanceTemps.Items.Add($"20 Kms : {calculDistanceTemps.CalculTemps(20)}");
                lv_DistanceTemps.Items.Add($"Semi-marathon 21,0975 Kms : {calculDistanceTemps.CalculTemps(21.0975)}");
                lv_DistanceTemps.Items.Add($"Marathon 42,195 Kms : {calculDistanceTemps.CalculTemps(42.195)}");
                lv_DistanceTemps.Items.Add($"50 Kms : {calculDistanceTemps.CalculTemps(50)}");
                lv_DistanceTemps.Items.Add($"100 Kms : {calculDistanceTemps.CalculTemps(100)}");

            }


        }
    }
}
