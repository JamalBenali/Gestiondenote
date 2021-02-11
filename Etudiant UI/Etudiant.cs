using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFE
{
    public partial class Etudiant : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public _Etudiant Etd;

        public Etudiant(_Etudiant etd)
        {
            InitializeComponent();
            /*Disable hover - background color*/
            //button1.FlatAppearance.MouseOverBackColor = button1.BackColor;
            // button1.BackColorChanged += (s, e) => {
            //     button1.FlatAppearance.MouseOverBackColor = button1.BackColor;
            //};
            /*Disable hover - background color*/
            //button2.FlatAppearance.MouseOverBackColor = button2.BackColor;
            //button2.BackColorChanged += (s, e) => {
            //    button2.FlatAppearance.MouseOverBackColor = button2.BackColor;
            //};
            /*Disable hover - background color*/
            // button3.FlatAppearance.MouseOverBackColor = button3.BackColor;
            // button3.BackColorChanged += (s, e) => {
            //     button3.FlatAppearance.MouseOverBackColor = button3.BackColor;
            //};
            Etd = etd;
            profile1.Etd = this.Etd;
            etudiant_parcours1.Etd = etd;
            etudiant_Notes1.Etd = etd;
            etudiant_abscence1.Etd = etd;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (sidebar.Width < 70)
            {
                sidebar.BringToFront();
                sidebar.Width = 225;
                accueil1.Location = new Point(260, 64);
                etudiant_parcours1.Location = new Point(260, 64);
                etudiant_Notes1.Location = new Point(260, 64);
                etudiant_abscence1.Location = new Point(260, 64);
                profile1.Location = new Point(260, 64);
            }
            else
            {
                sidebar.Width = 63;
                sidebar.SendToBack();
                accueil1.Location = new Point(160, 64);
                etudiant_parcours1.Location = new Point(160, 64);
                etudiant_Notes1.Location = new Point(160, 64);
                etudiant_abscence1.Location = new Point(160, 64);
                profile1.Location = new Point(160, 64);
            }
            name.Text = Etd.gsNom + " " + Etd.gsPrenom;
        }

        private void button1_BackColorChanged(object sender, EventArgs e)
        {
            //button1.BackColor = Color.White;
        }

        private void Etudiant_Load(object sender, EventArgs e)
        {
            
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

        private void Minus_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            profile1.Visible = true;
            etudiant_Notes1.Visible = false;
            accueil1.Visible = false;
            etudiant_abscence1.Visible = false;
            etudiant_parcours1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            profile1.Visible = false;
            etudiant_Notes1.Visible = true;
            accueil1.Visible = false;
            etudiant_abscence1.Visible = false;
            etudiant_parcours1.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            profile1.Visible = false;
            etudiant_Notes1.Visible = false;
            accueil1.Visible = false;
            etudiant_abscence1.Visible = false;
            etudiant_parcours1.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            profile1.Visible = false;
            etudiant_Notes1.Visible = false;
            accueil1.Visible = false;
            etudiant_abscence1.Visible = true;
            etudiant_parcours1.Visible = false;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            profile1.Visible = false;
            etudiant_Notes1.Visible = false;
            accueil1.Visible = false;
            etudiant_abscence1.Visible = false;
            etudiant_parcours1.Visible = true;
        }

        private void delete_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minus_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            //Ajouter un destructeur de l'instance courante içi
            this.Hide();
            login.Show();
        }
    }
}
