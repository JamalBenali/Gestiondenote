using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PFE
{
    public partial class Form1 : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private SqlConnection con;
        private SqlDataAdapter da;
        private DataSet ds;
        private DataTable dt = new DataTable();
        private DataTable dtt = new DataTable();
        public _Etudiant Etd;
        public _Enseignant Ens;
        public Administrateur admn;
        private SqlCommandBuilder cmdb;
        private string connectionString = "Server=DESKTOP-SEJ5RM7; DataBase=GestionDeNote; integrated Security=true";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void email_MouseClick(object sender, MouseEventArgs e)
        {
            cin.Text = "";
        }

        private void password_MouseClick(object sender, MouseEventArgs e)
        {
            password.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            da = new SqlDataAdapter("SELECT * FROM login WHERE CIN = '" + cin.Text + "' AND password = '" + password.Text + "'", con);
            ds = new DataSet();
            try
            {
                da.Fill(ds, "Login");
                if (ds.Tables["Login"].Rows.Count != 0)
                {
                    switch (ds.Tables["Login"].Rows[0][2].ToString())
                    {
                        case "Etudiant":
                            Etd = FillEtd();
                            Etudiant etudiant = new Etudiant(Etd);
                            this.Hide();
                            etudiant.Show();
                            break;
                        case "Enseignant":
                            Ens = FillEns();
                            Enseignant_UI.Enseignant enseignant = new Enseignant_UI.Enseignant(Ens);
                            this.Hide();
                            enseignant.Show();
                            break;
                        case "Administrateur":
                            admn = FillAdmin();
                            AdminPanel adm = new AdminPanel(admn);
                            this.Hide();
                            adm.Show();
                            break;
                    }
                }
                else
                    incorrect.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur ! \nPlus de détials : " + ex.ToString());
            }
        }
        _Etudiant FillEtd()
        {
            _Etudiant Etd;
            con = new SqlConnection(connectionString);
            dt.Clear();
            da = new SqlDataAdapter("select * from etudiant where CIN = '" + cin.Text + "'", con);
            cmdb = new SqlCommandBuilder(da);
            da.Fill(dt);
            string date = dt.Rows[0][4].ToString().Substring(0, 10);
            string day = date.Substring(0, 2);
            string month = date.Substring(3, 2);
            string year = date.Substring(6, 4);
            DateTime dateNai = new DateTime(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day));
            Etd = new _Etudiant(dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), dateNai, dt.Rows[0][5].ToString(), dt.Rows[0][6].ToString(), dt.Rows[0][7].ToString(), dt.Rows[0][8].ToString(), "GI", dt.Rows[0][0].ToString());

            return Etd;
        }
        _Enseignant FillEns()
        {
            _Enseignant Ens;
            con = new SqlConnection(connectionString);
            dt.Clear();
            da = new SqlDataAdapter("select * from enseignant where CIN = '" + cin.Text + "'", con);
            cmdb = new SqlCommandBuilder(da);
            da.Fill(dt);
            string date = dt.Rows[0][3].ToString().Substring(0, 10);
            string day = date.Substring(0, 2);
            string month = date.Substring(3, 2);
            string year = date.Substring(6, 4);
            DateTime dateNai = new DateTime(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day));
            List<string> Elem = new List<string>();
            dtt.Clear();
            da = new SqlDataAdapter("select El.disignation from Element El,Enseigne En where El.id_Element = En.id_Element and En.CIN = '" + cin.Text + "'", con);
            cmdb = new SqlCommandBuilder(da);
            da.Fill(dtt);
            for (int i = 0; i < dtt.Rows.Count; i++)
                Elem.Add(dtt.Rows[i][0].ToString());
            Ens = new _Enseignant(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dateNai, dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString(), dt.Rows[0][6].ToString(), dt.Rows[0][7].ToString(), Elem);


            return Ens;
        }
        Administrateur FillAdmin()
        {
            Administrateur Admin;
            con = new SqlConnection(connectionString);
            dt.Clear();
            da = new SqlDataAdapter("select * from Administrateur where CIN = '" + cin.Text + "'", con);
            cmdb = new SqlCommandBuilder(da);
            da.Fill(dt);
            string date = dt.Rows[0][3].ToString().Substring(0, 10);
            string day = date.Substring(0, 2);
            string month = date.Substring(3, 2);
            string year = date.Substring(6, 4);
            DateTime dateNai = new DateTime(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day));
            Admin = new Administrateur(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dateNai, dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString(), dt.Rows[0][6].ToString(), dt.Rows[0][7].ToString(), "filiere");
            return Admin;
        }
    }
}
