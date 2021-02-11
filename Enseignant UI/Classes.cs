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
    public partial class Classes : UserControl
    {
        private SqlDataAdapter notes;
        private SqlCommandBuilder builder_notes;
        private SqlConnection cn = new SqlConnection(@"Server=DESKTOP-SEJ5RM7; DataBase=GestionDeNote; integrated Security = true");
        private SqlDataAdapter Da;
        private SqlCommand cmd;
        private SqlCommandBuilder cmdb;
        private DataTable Dt = new DataTable();
        private DataSet ds = new DataSet();
        private SqlDataReader dr;
        public _Enseignant Ens = new _Enseignant();
        public Classes()
        {
            InitializeComponent();
            notes = new SqlDataAdapter("Select * from notes", cn);
            builder_notes = new SqlCommandBuilder(notes);
            notes.Fill(ds, "notes");
            CNE1.Hide();
            Nom1.Hide();
            Prenom1.Hide();
            Note1.Hide();
            button2.Hide();
        }
        public void Afficher_note()
        {
            cmd = new SqlCommand("ListeEtudiant", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("disigniation", SqlDbType.Text);
            p[0].Value = bunifuDropdown1.selectedValue.ToString();
            cmd.Parameters.AddRange(p);
            cn.Open();
            cmd.ExecuteNonQuery();
            SqlDataAdapter da;
            da = new SqlDataAdapter("select T.cne as CNE,T.nom as Nom,T.prenom as Prenom,C.Note as Note from TableEtudiant T,Notes C,Element E where C.CNE=T.CNE and C.id_Element=E.id_Element and E.disignation='" + bunifuDropdown1.selectedValue + "'", cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "note_ajouter");
            dataGridView1.DataSource = ds.Tables["note_ajouter"];
            cmd = new SqlCommand("Drop table TableEtudiant", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void afficher_noteNoInsererted()
        {
            cmd = new SqlCommand("ListeEtudiant", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("disigniation", SqlDbType.Text);
            p[0].Value = bunifuDropdown1.selectedValue.ToString();
            cmd.Parameters.AddRange(p);
            cn.Open();
            cmd.ExecuteNonQuery();
            SqlDataAdapter da;
            da = new SqlDataAdapter("select cne as CNE,nom as Nom,prenom as Prenom from TableEtudiant  where cne not in(select n.CNE from Notes n,Element e where n.id_Element=e.id_Element and e.disignation='" + bunifuDropdown1.selectedValue + "')", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd = new SqlCommand("Drop table TableEtudiant", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void Classes_Load(object sender, EventArgs e)
        {
            Dt.Clear();
            Da = new SqlDataAdapter("select El.disignation from Element El,Enseigne En where El.id_Element = En.id_Element and En.CIN = '" + Ens.gsCin + "'", cn);
            cmdb = new SqlCommandBuilder(Da);
            Da.Fill(Dt);
            for (int i=0; i<Dt.Rows.Count; i++)
            bunifuDropdown1.AddItem(Dt.Rows[i][0].ToString());

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Show();
            Note.Text = "Note";
            CNE.Text = "CNE";
            Nom.Text = "Nom";
            Prenom.Text = "Prenom";
            CNE1.Show();
            Nom1.Show();
            Prenom1.Show();
            Note1.Show();
            button2.Text = "Ajouter";
            afficher_noteNoInsererted();

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                int pos = dataGridView1.CurrentRow.Index;
                CNE.Text = dataGridView1.Rows[pos].Cells[0].Value.ToString();
                Nom.Text = dataGridView1.Rows[pos].Cells[1].Value.ToString();
                Prenom.Text = dataGridView1.Rows[pos].Cells[2].Value.ToString();
                Note.ReadOnly = false;
                Note.Text = "";
            }
            catch
            {
                MessageBox.Show("Aucune ligne dans la table", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button2.Show();
            Note.Text = "Note";
            CNE.Text = "CNE";
            Nom.Text = "Nom";
            Prenom.Text = "Prenom";
            CNE1.Show();
            Nom1.Show();
            Prenom1.Show();
            Note1.Show();
            button2.Text = "Modifier";
            Afficher_note();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(button2.Text== "Ajouter")
            {
                try { 
                cmd = new SqlCommand("select id_Element from element where disignation='" + bunifuDropdown1.selectedValue + "'", cn);
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                int a = Convert.ToInt32(dr[0].ToString());
                cn.Close();
                DataRow r;
                r = ds.Tables["notes"].NewRow();
                r[1] = a; 
                r[2] = CNE.Text.ToString();
                r[3] = Note.Text.ToString();
                r[4] = DateTime.Now;
                ds.Tables["notes"].Rows.Add(r);
                notes.Update(ds, "notes");
                ds.Tables["notes"].AcceptChanges();
                dataGridView1.Refresh();
                MessageBox.Show("La Note a été bien Ajouter !", "Add State", MessageBoxButtons.OK, MessageBoxIcon.Information);
                afficher_noteNoInsererted();
                }
                catch
                {
                    if(Note.Text=="")
                    MessageBox.Show("veuillez inserez une note", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("veuillez selectionner un etudiant", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (button2.Text == "Modifier")
            {
                try { 
                    cmd = new SqlCommand("select id_Element from element where disignation='" + bunifuDropdown1.selectedValue + "'", cn);
                    cn.Open();
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    int a = Convert.ToInt32(dr[0].ToString());
                    cn.Close();
                    cmd = new SqlCommand("Update notes set note ='" + Note.Text +"' Where CNE ='" + CNE.Text+"' and id_element="+a, cn);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("La Note a été bien Modifié !", "Update State", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.Refresh();
                cn.Close();
                Afficher_note();
                }
                 catch
                {
                    if (Note.Text == "")
                        MessageBox.Show("veuillez inserez une note", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("veuillez selectionner un etudiant", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }
    }
}
