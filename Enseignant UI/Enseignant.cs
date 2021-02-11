using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFE.Enseignant_UI
{
    public partial class Enseignant : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public Enseignant(_Enseignant ens)
        {
            InitializeComponent();
            /*Disable hover - background color*/
            button2.FlatAppearance.MouseOverBackColor = button2.BackColor;
            button2.BackColorChanged += (s, e) => {
                button2.FlatAppearance.MouseOverBackColor = button2.BackColor;
            };
            /*Disable hover - background color*/
            button3.FlatAppearance.MouseOverBackColor = button3.BackColor;
            button3.BackColorChanged += (s, e) => {
                button3.FlatAppearance.MouseOverBackColor = button3.BackColor;
            };
            classes2.Ens = ens;
            enseignant_emploie1.Ens = ens;
            enseignant_etudiants1.Ens = ens;
        }

        private void navbtn_Click(object sender, EventArgs e)
        {
            if (sidebar.Width < 70)
            {
                sidebar.Width = 225;
                enseignant_messagerie2.Location = new Point(231, enseignant_messagerie2.Location.Y);
                enseignant_emploie1.Location = new Point(231, enseignant_emploie1.Location.Y);
                enseignant_etudiants1.Location = new Point(231, enseignant_etudiants1.Location.Y);
                accueil_ens1.Location = new Point(231, accueil_ens1.Location.Y);
                profile_Ens1.Location = new Point(231, accueil_ens1.Location.Y);
                ens_abscence1.Location = new Point(231, accueil_ens1.Location.Y);
            }
            else
            {
                sidebar.Width = 63;
                enseignant_messagerie2.Location = new Point(150, enseignant_messagerie2.Location.Y);
                enseignant_emploie1.Location = new Point(150, enseignant_emploie1.Location.Y);
                enseignant_etudiants1.Location = new Point(150, enseignant_etudiants1.Location.Y);
                profile_Ens1.Location = new Point(150, accueil_ens1.Location.Y);
                ens_abscence1.Location = new Point(150, accueil_ens1.Location.Y);
                accueil_ens1.Location = new Point(150, accueil_ens1.Location.Y);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            enseignant_emploie1.Visible = true;
            enseignant_emploie1.BringToFront();
            enseignant_etudiants1.Visible = false;
            profile_Ens1.Visible = false;
            ens_abscence1.Visible = false;
            accueil_ens1.Visible = false;
            enseignant_messagerie2.Visible = false;
            classes2.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            enseignant_messagerie2.BringToFront();

            enseignant_messagerie2.BringToFront();
            enseignant_messagerie2.Visible = true;
            enseignant_etudiants1.Visible = false;
            enseignant_emploie1.Visible = false;
            profile_Ens1.Visible = false;
            ens_abscence1.Visible = false;
            accueil_ens1.Visible = false;
            classes2.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            enseignant_etudiants1.BringToFront();
            enseignant_etudiants1.Visible = true;
            enseignant_emploie1.Visible = false;
            profile_Ens1.Visible = false;
            ens_abscence1.Visible = false;
            accueil_ens1.Visible = false;
            enseignant_messagerie2.Visible = false;
            classes2.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ens_abscence1.BringToFront();
            ens_abscence1.Visible = true;
            accueil_ens1.Visible = false;
            enseignant_messagerie2.Visible = false;
            enseignant_emploie1.Visible = false;
            enseignant_etudiants1.Visible = false;
            profile_Ens1.Visible = false;
            classes2.Visible = false;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }
        private void topbar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void topbar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void topbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Minus_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void delete_Click_2(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Enseignant_Load(object sender, EventArgs e)
        {

        }

        private void profile_avatar_Click(object sender, EventArgs e)
        {
            sidebar.Width = 63;
            profile_Ens1.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            classes2.BringToFront();
            classes2.Visible = true;
            ens_abscence1.Visible = false;
            accueil_ens1.Visible = false;
            enseignant_messagerie2.Visible = false;
            enseignant_emploie1.Visible = false;
            enseignant_etudiants1.Visible = false;
            profile_Ens1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            //Ajouter un desctructeur de l'objet courant içi
            this.Hide();
            login.Show();
        }
    }
}
