/* 
 * 
 * Auteur : AYED Merwann 
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP01._2___IMC_GUI
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e) {

        }

        // Algorithme de calcul de l'IMC
        static void calculIMC(double poids, double taille) {

            // Je convertis et traite les calculs au début
            double taillenew = (taille / 100);
            double IMCcalcul = poids / Math.Pow(taillenew, 2);

            // Arrondi pour faire plus propre
            double IMC = Math.Round(IMCcalcul, 2);


            // Algorithme de sélection de l'option selon la valeur de l'IMC
            if (IMC > 40) {

                MessageBox.Show("Votre IMC est de " + IMC + "\nVous êtes en situation d'obésité morbide.");

            } else if (IMC >= 35 && IMC <= 40) {

                MessageBox.Show("Votre IMC est de " + IMC + "\nVous êtes en situation d'obésité sévère.");

            } else if (IMC >= 30 && IMC <= 35) {

                MessageBox.Show("Votre IMC est de " + IMC + "\nVous êtes en situation d'obésité modérée.");

            } else if (IMC >= 25 && IMC <= 30) {

                MessageBox.Show("Votre IMC est de " + IMC + "\nVous êtes en situation de surpoids.");

            } else if (IMC >= 18.5 && IMC <= 25) {
                
                MessageBox.Show("Votre IMC est de " + IMC + "\nVous êtes en situation de corpulence normale.");

            } else if (IMC >= 16.5 && IMC <= 18.5) {

                MessageBox.Show("Votre IMC est de " + IMC + "\nVous êtes en situation de maigreur.");

            } else {
                MessageBox.Show("Votre IMC est de " + IMC + "\nVous êtes en situation de famine.");

            }

        }

        private void button1_Click(object sender, EventArgs e) {
            // Utilisation du try catch pour un gain de sécurité

            try {

                // Hop, je convertis pour éviter les erreurs
                double poids = Convert.ToDouble(poidsTxtBox.Text);
                double taille = Convert.ToDouble(tailleTxtBox.Text);

                // Je me suis arrangé pour enclencher la fonction au moment du clic sur le bouton afin d'aérer le code
                calculIMC(poids, taille);

            } catch {

                // Message d'erreur au cas où
                MessageBox.Show("Une erreur a été rencontrée, veuillez vérifier si le format des données saisies ont été respectées.", "Erreur !",
   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
