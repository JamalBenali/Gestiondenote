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
    public partial class AdminPanel : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public AdminPanel(Administrateur adm)
        {
            InitializeComponent();
            adminProfile1.admin = adm;
        }

        private void navbtn_Click(object sender, EventArgs e)
        {
            if (sidebar.Width < 70)
            {
                sidebar.Width = 225;
                adminDashboard1.Location = new Point(260, adminDashboard1.Location.Y);
                gestionDesEnseignants1.Location = new Point(260, gestionDesEnseignants1.Location.Y);
                gestionDesEtudiants1.Location = new Point(260, gestionDesEtudiants1.Location.Y);
                gestionDesFilieres1.Location = new Point(260, gestionDesFilieres1.Location.Y);
                enseignant_messagerie1.Location = new Point(260, enseignant_messagerie1.Location.Y);
                adminProfile1.Location = new Point(260, adminProfile1.Location.Y);
                gestionDesNotes1.Location = new Point(260, gestionDesNotes1.Location.Y);
            }
            else
            {
                sidebar.Width = 63;
                adminDashboard1.Location = new Point(174, adminDashboard1.Location.Y);
                gestionDesEnseignants1.Location = new Point(174, gestionDesEnseignants1.Location.Y);
                gestionDesFilieres1.Location = new Point(174, gestionDesFilieres1.Location.Y);
                enseignant_messagerie1.Location = new Point(174, enseignant_messagerie1.Location.Y);
                adminProfile1.Location = new Point(174, adminProfile1.Location.Y);
                gestionDesEtudiants1.Location = new Point(174, gestionDesEtudiants1.Location.Y);
                gestionDesNotes1.Location = new Point(174, gestionDesNotes1.Location.Y);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void AdminPanel_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            //Ajoutez un destructeur içi pour detruire l'instance courante
            this.Hide();
            login.Show();
        }

        private void profile_avatar_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = true;
            adminDashboard1.BringToFront();
            gestionDesNotes1.Visible = false;
            gestionDesEtudiants1.Visible = false;
            gestionDesEnseignants1.Visible = false;
            gestionDesFilieres1.Visible = false;
            enseignant_messagerie1.Visible = false;
        }

        private void adminDashboard1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            gestionDesEtudiants1.Visible = true;
            gestionDesEtudiants1.BringToFront();
            gestionDesNotes1.Visible = false;
            gestionDesEnseignants1.Visible = false;
            adminDashboard1.Visible = false;
            gestionDesFilieres1.Visible = false;
            enseignant_messagerie1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gestionDesEnseignants1.Visible = true;
            gestionDesEnseignants1.BringToFront();
            gestionDesNotes1.Visible = false;
            gestionDesEtudiants1.Visible = false;
            adminDashboard1.Visible = false;
            gestionDesFilieres1.Visible = false;
            enseignant_messagerie1.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            gestionDesFilieres1.Visible = true;
            gestionDesFilieres1.BringToFront();
            gestionDesNotes1.Visible = false;
            gestionDesEtudiants1.Visible = false;
            gestionDesEnseignants1.Visible = false;
            adminDashboard1.Visible = false;
            enseignant_messagerie1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gestionDesNotes1.Visible = true;
            gestionDesNotes1.BringToFront();
            adminDashboard1.Visible = false;
            gestionDesEtudiants1.Visible = false;
            gestionDesEnseignants1.Visible = false;
            gestionDesFilieres1.Visible = false;
            enseignant_messagerie1.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            enseignant_messagerie1.Visible = true;
            enseignant_messagerie1.BringToFront();
            gestionDesNotes1.Visible = false;
            gestionDesEtudiants1.Visible = false;
            gestionDesEnseignants1.Visible = false;
            gestionDesFilieres1.Visible = false;
            adminDashboard1.Visible = false;
        }
    }
}
