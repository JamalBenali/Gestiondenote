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
    public partial class NouvelleAbs : UserControl
    {
        private string connectionString = "Server=DESKTOP-SEJ5RM7; DataBase=GestionDeNote; integrated Security = true";
        private SqlConnection con;
        private SqlDataAdapter da, da1, da2;
        private DataSet ds;
        private SqlCommandBuilder cb;
        private BindingSource bs;
        //Cordonnées d'abscence
        private string Student_Abscence_cne;
        private string Student_Abscence_nom;
        private string Student_Abscence_prenom;

        private string Element_Abscence;
        private string Date_Abscence;
        private string Heure_Abscence = "";

        public NouvelleAbs()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
        }

        private void NouvelleAbs_Load(object sender, EventArgs e)
        {
            string CIN = "pa88623";
            con = new SqlConnection(connectionString);
            ds = new DataSet();

            //Visualizing Data through the data grid view
            da2 = new SqlDataAdapter("SELECT Et.CNE, Nom, Prenom, E.disignation, note FROM Etudiant Et, Notes N, Element E WHERE N.id_Element = E.id_Element AND Et.CNE = N.CNE AND E.id_Element in ( SELECT PE.id_Element FROM enseigne PE WHERE PE.CIN = '" + CIN+"')", con);
            try
            {
                da2.Fill(ds, "Etudiants");
                if(ds.Tables["Etudiants"].Rows.Count != 0)
                {
                    bs = new BindingSource();
                    bs.DataSource = ds.Tables["Etudiants"];
                    dataGridView1.DataSource = bs;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur ! \n Plus de détails: " + ex.ToString());
            }
            //Loading the Elements List into the Drop down Selection Menue
            List<string> liste_elem = new List<string>();
            da = new SqlDataAdapter("SELECT E.disignation as 'Elements Enseignés' FROM Element E, enseigne En WHERE E.id_Element = En.id_element AND En.CIN = '" + CIN + "'", con);
            try
            {
                da.Fill(ds, "elements");
                if (ds.Tables["elements"].Rows.Count != 0)
                {
                    foreach (DataRow r in ds.Tables["elements"].Rows)
                        liste_elem.Add(r["Elements Enseignés"].ToString());
                }
                listes_elements.Items = liste_elem.ToArray();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur ! \n Plus de détails : " + ex.ToString());
            }

        
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            //Stockage des données dans des variables locals
            if (listes_elements.selectedIndex == -1 || bunifuDatepicker1 == null || bunifuDropdown2.selectedIndex == -1)
            {
                MessageBox.Show("Veuillez remplir tous les champs avant de continuer !");
            }
            else
            {
                this.Element_Abscence = listes_elements.selectedValue;
                this.Date_Abscence = bunifuDatepicker1.Value.Date.ToString("yyyy - MM - dd");
                this.Heure_Abscence = bunifuDropdown2.selectedValue;
                //Affectation des valeurs dynamiques au Labels
                cne_abscent.Text = Student_Abscence_cne;
                nom_abscent.Text = Student_Abscence_nom;
                prenom_abscent.Text = Student_Abscence_prenom;
                date_abscent.Text = this.Date_Abscence.ToString();
                seance_abscent.Text = this.Element_Abscence;
                heure_abscent.Text = this.Heure_Abscence;
                //Affichage de la partie : Confirmation
                verifier_abs.Show();
                verifier_abs.BringToFront();
                step_2.BackColor = Color.FromArgb(3, 126, 243);
                step_1.BackColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Hiding the verification panel
            verifier_abs.Visible = false;
            verifier_abs.SendToBack();
            //Showing the panel
            data_panel.Visible = true;
            data_panel.BringToFront();
            //Changing the _step_ buttons color
            step_1.BackColor = Color.FromArgb(3, 126, 243);
            step_2.BackColor = Color.Silver;
        }

        private void data_panel_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                Student_Abscence_cne = Convert.ToString(selectedRow.Cells["CNE"].Value);
                Student_Abscence_nom = Convert.ToString(selectedRow.Cells["Nom"].Value);
                Student_Abscence_prenom = Convert.ToString(selectedRow.Cells["prenom"].Value);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            //Stockage des données dans la BD
            da1 = new SqlDataAdapter("SELECT * FROM Abscence", con);
            cb = new SqlCommandBuilder(da1);
            DataRow r;
            try
            {
                da1.Fill(ds, "Abscence");
                r = ds.Tables["Abscence"].NewRow();
                r[0] = "C138067244";
                r[1] = Convert.ToDateTime(this.Date_Abscence);
                r[2] = this.Heure_Abscence;
                //Justification d'abscence
                if (justification.selectedValue != "Non Justifié")
                {
                    r[3] = "O";
                }
                else
                    r[3] = "N";
                //Element d'abscence
                SqlDataAdapter da2 = new SqlDataAdapter("SELECT id_Element FROM Element WHERE designation = '" + this.Element_Abscence +"'", con);
                da2.Fill(ds, "id_element");
                if (ds.Tables["id_element"].Rows.Count != 0)
                    r[4] = ds.Tables["id_element"].Rows[0]["id_Element"].ToString();
                else
                    MessageBox.Show("Erreur de specification de l'element, Veuillez ressayer plus tard !");
                ds.Tables["Abscence"].Rows.Add(r);
                //Conservation des operations dans la base de données
                da1.Update(ds, "Abscence");
                ds.Tables["Abscence"].AcceptChanges();
                MessageBox.Show("Operation effectuée avec succes");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur ! plus de détails : \n" + ex.ToString());
            }
            //Redirection vers la page de la gestion des abscences
            this.Hide();
        }

        private void data_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
