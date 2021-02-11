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

namespace PFE.Admin
{
    public partial class GestionDeFiliere : UserControl
    {
        private SqlDataAdapter adapter_filiere;
        private SqlCommandBuilder builder_filiere; // assurer l'ajout, modif,sup vers la bd
        DataSet ds = new DataSet();
        SqlConnection cnx = new SqlConnection(@"Server=DESKTOP-SEJ5RM7;DataBase=GestionDeNote;Integrated Security=true;");
        SqlCommand cmd;
        SqlDataReader dr;
        public GestionDeFiliere()
        {
            InitializeComponent();
            adapter_filiere = new SqlDataAdapter("select disignation from filiere", cnx);
            adapter_filiere.Fill(ds, "filiere");
            int i;
            for (i = 0; i < ds.Tables["filiere"].Rows.Count; i++)
            {
                filiereChoice.AddItem(ds.Tables["filiere"].Rows[i][0].ToString());
                filiereSupp.AddItem(ds.Tables["filiere"].Rows[i][0].ToString());
            }
            cmd = new SqlCommand("select max(id_Filiere) from Filiere", cnx);
            cnx.Open();
            dr = cmd.ExecuteReader();
            dr.Read();
            int a = Convert.ToInt32(dr[0].ToString());
            a++;
            textBox1.Text = a.ToString();
            dr.Close();
            cnx.Close();
        }
        public void updateFiliere()
        {
            filiereSupp.Clear();
            filiereChoice.Clear();
            ds.Tables["filiere"].Clear();
            adapter_filiere = new SqlDataAdapter("select disignation from filiere", cnx);
            adapter_filiere.Fill(ds, "filiere");
            for (int i = 0; i < ds.Tables["filiere"].Rows.Count; i++)
            {
                filiereChoice.AddItem(ds.Tables["filiere"].Rows[i][0].ToString());
                filiereSupp.AddItem(ds.Tables["filiere"].Rows[i][0].ToString());
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (disignationAjout.Text == "") MessageBox.Show("veuillez entrez les champs vides", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    adapter_filiere = new SqlDataAdapter("select * from filiere", cnx);
                    builder_filiere = new SqlCommandBuilder(adapter_filiere);
                    adapter_filiere.Fill(ds, "Allfiliere");
                    DataRow r;
                    r = ds.Tables["Allfiliere"].NewRow();
                    r[0] = Convert.ToInt32(textBox1.Text.Trim());
                    r[1] = disignationAjout.Text.ToString();
                    ds.Tables["Allfiliere"].Rows.Add(r);
                    adapter_filiere.Update(ds, "Allfiliere");
                    ds.Tables["Allfiliere"].AcceptChanges();
                    MessageBox.Show(r[1].ToString(), "Ajout", MessageBoxButtons.OK);
                    int a = Convert.ToInt32(textBox1.Text.Trim()) + 1;
                    textBox1.Text = a.ToString();
                    updateFiliere();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error : " + ex.Message);
                }
                finally
                {
                    cnx.Close();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (filiereSupp.selectedIndex == 0) MessageBox.Show("veuillez entrez les champs vides", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    cmd = new SqlCommand("select id_filiere from filiere where disignation='" + filiereSupp.selectedValue.ToString() + "'", cnx);
                    cnx.Open();
                    dr=cmd.ExecuteReader();
                    dr.Read();
                    int a =Convert.ToInt32(dr["id_filiere"].ToString());
                    cnx.Close();
                    cmd = new SqlCommand("suppfiliere", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter param = new SqlParameter();
                    param = new SqlParameter("@id", SqlDbType.Int);
                    param.Value = a;
                    cmd.Parameters.Add(param);
                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                    int b = Convert.ToInt32(textBox1.Text.Trim()) - 1;
                    textBox1.Text = b.ToString();
                    MessageBox.Show("filière supprimé");
                    
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error : " + ex.Message);
                }
                finally
                {
                    cnx.Close();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (filiereChoice.selectedIndex == 0) MessageBox.Show("veuillez entrez les champs vides", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    cmd = new SqlCommand("select * from filiere where disignation='" + filiereChoice.selectedValue.ToString() + "'", cnx);
                    cnx.Open();
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    textBox12.Text = dr["id_filiere"].ToString();
                    textBox11.Text = dr["disignation"].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error :" + ex.Message);
                }
                finally
                {
                    cnx.Close();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (filiereChoice.selectedIndex == -1 || textBox11.Text == "") MessageBox.Show("veuillez entrez les champs vides", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    cmd = new SqlCommand("update filiere set disignation='" + textBox11.Text.ToString() + "' where id_filiere=" + Convert.ToInt32(textBox12.Text.ToString()), cnx);
                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    updateFiliere();
                    MessageBox.Show("Modification réussie");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error :" + ex.Message);
                }
                finally
                {
                    cnx.Close();
                }
            }
        }
    }
}
