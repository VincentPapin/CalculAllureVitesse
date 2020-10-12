using System;

namespace ConversionAllureVitesse
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.allure = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Allure = new System.Windows.Forms.Label();
            this.tb_Distance = new System.Windows.Forms.TextBox();
            this.lb_Vitesse = new System.Windows.Forms.Label();
            this.tb_Heure = new System.Windows.Forms.TextBox();
            this.btn_Calcul = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Minute = new System.Windows.Forms.TextBox();
            this.tb_Seconde = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_CalculDistanceTemps = new System.Windows.Forms.Button();
            this.lv_DistanceTemps = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_AllureMin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_AllureSec = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.allure.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.allure);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(284, 219);
            this.tabControl1.TabIndex = 11;
            // 
            // allure
            // 
            this.allure.Controls.Add(this.label1);
            this.allure.Controls.Add(this.lb_Allure);
            this.allure.Controls.Add(this.tb_Distance);
            this.allure.Controls.Add(this.lb_Vitesse);
            this.allure.Controls.Add(this.tb_Heure);
            this.allure.Controls.Add(this.btn_Calcul);
            this.allure.Controls.Add(this.label2);
            this.allure.Controls.Add(this.label4);
            this.allure.Controls.Add(this.tb_Minute);
            this.allure.Controls.Add(this.tb_Seconde);
            this.allure.Controls.Add(this.label3);
            this.allure.Location = new System.Drawing.Point(4, 22);
            this.allure.Name = "allure";
            this.allure.Padding = new System.Windows.Forms.Padding(3);
            this.allure.Size = new System.Drawing.Size(276, 193);
            this.allure.TabIndex = 0;
            this.allure.Text = "Calcul vitesse/allure";
            this.allure.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Distance";
            // 
            // lb_Allure
            // 
            this.lb_Allure.AutoSize = true;
            this.lb_Allure.Location = new System.Drawing.Point(22, 136);
            this.lb_Allure.Name = "lb_Allure";
            this.lb_Allure.Size = new System.Drawing.Size(33, 13);
            this.lb_Allure.TabIndex = 10;
            this.lb_Allure.Text = "Allure";
            // 
            // tb_Distance
            // 
            this.tb_Distance.Location = new System.Drawing.Point(61, 13);
            this.tb_Distance.Name = "tb_Distance";
            this.tb_Distance.Size = new System.Drawing.Size(167, 20);
            this.tb_Distance.TabIndex = 0;
            this.tb_Distance.TextChanged += new System.EventHandler(this.tb_Distance_TextChanged);
            // 
            // lb_Vitesse
            // 
            this.lb_Vitesse.AutoSize = true;
            this.lb_Vitesse.Location = new System.Drawing.Point(22, 113);
            this.lb_Vitesse.Name = "lb_Vitesse";
            this.lb_Vitesse.Size = new System.Drawing.Size(41, 13);
            this.lb_Vitesse.TabIndex = 9;
            this.lb_Vitesse.Text = "Vitesse";
            // 
            // tb_Heure
            // 
            this.tb_Heure.Location = new System.Drawing.Point(61, 39);
            this.tb_Heure.Name = "tb_Heure";
            this.tb_Heure.Size = new System.Drawing.Size(28, 20);
            this.tb_Heure.TabIndex = 2;
            // 
            // btn_Calcul
            // 
            this.btn_Calcul.Location = new System.Drawing.Point(96, 81);
            this.btn_Calcul.Name = "btn_Calcul";
            this.btn_Calcul.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcul.TabIndex = 8;
            this.btn_Calcul.Text = "Calcul";
            this.btn_Calcul.UseVisualStyleBackColor = true;
            this.btn_Calcul.Click += new System.EventHandler(this.btn_Calcul_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Heure";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sec.";
            // 
            // tb_Minute
            // 
            this.tb_Minute.Location = new System.Drawing.Point(132, 39);
            this.tb_Minute.Name = "tb_Minute";
            this.tb_Minute.Size = new System.Drawing.Size(28, 20);
            this.tb_Minute.TabIndex = 4;
            // 
            // tb_Seconde
            // 
            this.tb_Seconde.Location = new System.Drawing.Point(200, 40);
            this.tb_Seconde.Name = "tb_Seconde";
            this.tb_Seconde.Size = new System.Drawing.Size(28, 20);
            this.tb_Seconde.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Minute";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tb_AllureSec);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btn_CalculDistanceTemps);
            this.tabPage2.Controls.Add(this.lv_DistanceTemps);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tb_AllureMin);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(276, 193);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Temps";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_CalculDistanceTemps
            // 
            this.btn_CalculDistanceTemps.Location = new System.Drawing.Point(195, 13);
            this.btn_CalculDistanceTemps.Name = "btn_CalculDistanceTemps";
            this.btn_CalculDistanceTemps.Size = new System.Drawing.Size(75, 23);
            this.btn_CalculDistanceTemps.TabIndex = 9;
            this.btn_CalculDistanceTemps.Text = "Calcul";
            this.btn_CalculDistanceTemps.UseVisualStyleBackColor = true;
            this.btn_CalculDistanceTemps.Click += new System.EventHandler(this.btn_CalculDistanceTemps_Click);
            // 
            // lv_DistanceTemps
            // 
            this.lv_DistanceTemps.GridLines = true;
            this.lv_DistanceTemps.HideSelection = false;
            this.lv_DistanceTemps.Location = new System.Drawing.Point(9, 54);
            this.lv_DistanceTemps.Name = "lv_DistanceTemps";
            this.lv_DistanceTemps.Size = new System.Drawing.Size(261, 133);
            this.lv_DistanceTemps.TabIndex = 2;
            this.lv_DistanceTemps.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Allure";
            // 
            // tb_AllureMin
            // 
            this.tb_AllureMin.Location = new System.Drawing.Point(96, 15);
            this.tb_AllureMin.Name = "tb_AllureMin";
            this.tb_AllureMin.Size = new System.Drawing.Size(24, 20);
            this.tb_AllureMin.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = ":";
            // 
            // tb_AllureSec
            // 
            this.tb_AllureSec.Location = new System.Drawing.Point(142, 15);
            this.tb_AllureSec.Name = "tb_AllureSec";
            this.tb_AllureSec.Size = new System.Drawing.Size(24, 20);
            this.tb_AllureSec.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 243);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.allure.ResumeLayout(false);
            this.allure.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage allure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Allure;
        private System.Windows.Forms.TextBox tb_Distance;
        private System.Windows.Forms.Label lb_Vitesse;
        private System.Windows.Forms.TextBox tb_Heure;
        private System.Windows.Forms.Button btn_Calcul;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Minute;
        private System.Windows.Forms.TextBox tb_Seconde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_AllureMin;
        private System.Windows.Forms.ListView lv_DistanceTemps;
        private System.Windows.Forms.Button btn_CalculDistanceTemps;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_AllureSec;
    }
}

