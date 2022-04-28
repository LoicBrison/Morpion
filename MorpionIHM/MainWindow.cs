using MorpionLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorpionIHM
{
    public partial class MainWindow : Form
    {
        Morpion morpion;

        private Joueur j1;
        private Joueur j2;
        public MainWindow()
        {
            InitializeComponent();
        }
                
        //Affiche un message de fin en fonction de morpion.CompteCase() Gagner ou null
        private bool Fin()
        {
            if (morpion.CompteCase() == 1)
            {
                MessageBox.Show(morpion.JoueurCourant.Nom + " a Gagné !!");
                this.Close(); // Ferme l'application à la fin de chaque partie
                return true;
            }
            else if (morpion.CompteCase() == 2)
            {
                MessageBox.Show("Match null !!");
                this.Close();
                return true;
            }
            else return false;
        }

        private void textBox_J1_TextChanged(object sender, EventArgs e)
        {
            if (textBox_J1.Text == "IA" || textBox_J1.Text == "Ia" || textBox_J1.Text == "iA" || textBox_J1.Text == "ia")
            {
                MessageBox.Show("Le joueur 1 ne peut pas être une IA");
            }
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox_J1.Text) || String.IsNullOrWhiteSpace(textBox_J2.Text))
            {
                MessageBox.Show("Les nom des joueurs ne peuvent pas être vide");
            }
            else if (textBox_J1.Text == textBox_J2.Text)
            {
                MessageBox.Show("Les deux joueurs ne peuvent pas avoir le meme nom");
            }
            else if (!(textBox_J1.Text == "IA" || textBox_J1.Text == "Ia" || textBox_J1.Text == "iA" || textBox_J1.Text == "ia" 
                || String.IsNullOrWhiteSpace(textBox_J1.Text) || String.IsNullOrWhiteSpace(textBox_J2.Text)))
            {
                this.j1 = new Joueur(textBox_J1.Text);
                if (textBox_J2.Text == "IA" || textBox_J2.Text == "Ia" || textBox_J2.Text == "iA" || textBox_J2.Text == "ia")
                {
                    this.j2 = new Joueur("IA");
                }
                else this.j2 = new Joueur(textBox_J2.Text);
                morpion = new Morpion(j1, j2);
                richTextBox1.Text = morpion.JoueurCourant.Nom + " à toi de commencer";

            }
        }

        private void Button_Click(object sender, EventArgs e)
        {

            //Si morpion existe et n'est pas fini
            if (morpion == null)
            {
                MessageBox.Show("Completer les joueurs puis lancer la partie");
            }
            else if (morpion != null || this.Fin() == false)
            {
                Button btn = sender as Button;
                if (btn != null)
                {
                    //Coordonée de la case choisi
                    //X
                    int colone = tableLayoutPanel1.GetColumn(btn);
                    //Y
                    int ligne = tableLayoutPanel1.GetRow(btn);

                    //Vérifie que la case choisi est null
                    if (morpion.EstVide(colone, ligne))
                    {
                        if (morpion.JoueurCourant.Nom == j1.Nom)
                        {
                            btn.Image = Properties.Resources.j1;
                        }
                        else
                        {
                            btn.Image = Properties.Resources.j2;
                        }
                        //Marque la case cocher 
                        morpion.Joue(colone, ligne);
                        //Affiche les coups
                        richTextBox1.Text += "\n" + morpion.JoueurCourant.Nom + ": X:" + ligne + " Y:" + colone+ "\n";
                        //Test si le jeu est fini
                        if (morpion.EstFini())
                        {
                            this.Fin();
                        }
                        //Si non joueur suivant
                        else
                        {
                            morpion.JoueurSuivant();
                        }
                    }

                    //Si le joueur 2 est un IA
                    if (morpion.JoueurCourant.Nom == "IA" && !morpion.EstFini())
                    {
                        //On fait jouer l'IA
                        Case c = morpion.JoueurCourant.JoueIA(morpion);

                        //Coordonées de la case chois
                        int x = c.GetX;
                        int y = c.GetY;


                        //On recherche dans la grille l'image de la case choisis est on la change
                        foreach (var control in tableLayoutPanel1.Controls)
                        {
                            if (control is Button button)
                            {
                                if (tableLayoutPanel1.GetRow(button) == y && tableLayoutPanel1.GetColumn(button) == x)
                                {
                                    button.Image = Properties.Resources.j2;
                                }
                            }
                        }

                        richTextBox1.Text += "\n" + morpion.JoueurCourant.Nom + ": X:" + x + " Y:" + y+ "\n";

                        //Test si le jeu est fini
                        if (morpion.EstFini())
                        {
                            this.Fin();
                        }
                        //Si non joueur suivant
                        else
                        {
                            morpion.JoueurSuivant();
                        }
                    }
                }
            }
        }
    }
}
