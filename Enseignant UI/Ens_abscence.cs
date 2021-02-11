using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PFE.Enseignant_UI
{
    public partial class Ens_abscence : UserControl
    {
        private SqlConnection con;
        private string connectionString = "Server=DESKTOP-SEJ5RM7; DataBase=GestionDeNote; integrated Security = true";
        private SqlDataAdapter da, da_names, da_target;
        private DataSet ds;
        private BindingSource bs;
        private string CIN = "BH158675";
        public Ens_abscence()
        {
            InitializeComponent();
            //Disabling the buttons hover color
            Settings_btn.FlatAppearance.MouseOverBackColor = Settings_btn.BackColor;
            Settings_btn.BackColorChanged += (s, e) => {
                Settings_btn.FlatAppearance.MouseOverBackColor = Settings_btn.BackColor;
            };
            //==
            Settings_btn2.FlatAppearance.MouseOverBackColor = Settings_btn2.BackColor;
            Settings_btn2.BackColorChanged += (s, e) => {
                Settings_btn.FlatAppearance.MouseOverBackColor = Settings_btn2.BackColor;
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!dropdown.Visible)
            {
                dropdown.Visible = true;
                dropdown.BringToFront();
            }
            else
                dropdown.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Showing attendance ms
            nouvelleAbs1.Visible = true;
            nouvelleAbs1.BringToFront();
            students_liste.Visible = false;
            bunifuThinButton21.Visible = false;
            //Hiding the drop down
            dropdown.Visible = false;
        }

        private void students_liste_onItemSelected(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            ds = new DataSet();
            string target_student = students_liste.selectedValue;
            string target_query = "select Et.CNE, (Nom + ' ' + Prenom) as 'Nom Complet' , disignation as 'Seance', Date, Heure, justifier_NonJustifier 'Justification' from abscence A, Element E , Etudiant Et Where A.id_Element=E.id_Element AND Et.CNE = A.CNE AND E.id_Element in ( SELECT id_Element from Enseigne WHERE CIN = '" + CIN + "' AND (Nom + ' ' + Prenom) = '" + target_student + "')";
            da_target = new SqlDataAdapter(target_query, con);
            try
            {
                da_target.Fill(ds, "Abscence_etudiants");
                bs = new BindingSource();
                bs.DataSource = ds.Tables["Abscence_etudiants"];
                dataGridView1.DataSource = bs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur ! \n Plus de détails : " + ex.ToString());
            }
        }

        private void Ens_abscence_Click(object sender, EventArgs e)
        {
            dropdown.Visible = false;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            ds = new DataSet();
            if (students_liste.selectedIndex == -1)
                MessageBox.Show("Veuillez choisir une étudiant pour continuer !");
            else
            {
                string target_student = students_liste.selectedValue;
                string target_query = "select Et.CNE, (Nom + ' ' + Prenom) as 'Nom Complet' , designation as 'Seance', Date, Heure, justifier_NonJustifier 'Justification' from abscence A, Element E , Etudiant Et Where A.id_Element=E.id_Element AND Et.CNE = A.CNE AND E.id_Element in ( SELECT id_Element from Enseigne WHERE CIN = '" + CIN + "' AND (Nom + ' ' + Prenom) = '" + target_student + "')";
                da_target = new SqlDataAdapter(target_query, con);
                try
                {
                    da_target.Fill(ds, "Abscence_etudiants");
                    bs = new BindingSource();
                    bs.DataSource = ds.Tables["Abscence_etudiants"];
                    dataGridView1.DataSource = bs;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur ! \n Plus de détails : " + ex.ToString());
                }
            }

        }

        private void Ens_abscence_Load(object sender, EventArgs e)
        {
            //Loading Data into the combo box - PART 1
            List<string> Students_names = new List<string>();
            con = new SqlConnection(connectionString);
            ds = new DataSet();
            string Query_Names = "SELECT (Nom + ' ' + Prenom) as 'fullname' FROM Etudiant ";
            da_names = new SqlDataAdapter(Query_Names, con);
            //Showing attendance Data in the Data Grid View - PART 2
            string Query = "Select CNE, disignation as 'Seance', Date, Heure, justifier_NonJustifier 'Justification' from abscence A, Element E Where A.id_Element=E.id_Element AND E.id_Element in ( SELECT id_Element from enseigne WHERE CIN = '" + CIN + "' )";
            da = new SqlDataAdapter(Query, con);
            //Traitement
            try
            {
                //PART - 1
                da_names.Fill(ds, "Names");
                if(ds.Tables["Names"].Rows.Count != 0)
                {
                    foreach(DataRow r in ds.Tables["Names"].Rows)
                    {
                        Students_names.Add(r["fullname"].ToString());
                    }
                }
                students_liste.Items = Students_names.ToArray();
                //PART - 2
                da.Fill(ds, "Abscences");
                if (ds.Tables["Abscences"].Rows.Count != 0)
                {
                    bs = new BindingSource();
                    bs.DataSource = ds.Tables["Abscences"];
                    dataGridView1.DataSource = bs;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur ! \n Plus de détails : " + ex.ToString());
            }
        }
    }
}
