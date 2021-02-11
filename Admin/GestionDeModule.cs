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
    public partial class GestionDeModule : UserControl
    {
        private SqlDataAdapter adapter_filiere;
        private SqlDataAdapter adapter_module;
        SqlConnection cnx = new SqlConnection(@"Server=.\SQLEXPRESS;DataBase=GestionDeNote;Integrated Security=true;");
        DataSet ds = new DataSet();
        private SqlCommandBuilder builder_module;
        SqlCommand cmd;
        SqlDataReader dr;
        public GestionDeModule()
        {
            InitializeComponent();
            adapter_filiere = new SqlDataAdapter("select disignation from filiere", cnx);
            adapter_filiere.Fill(ds, "filiere");
            int i;
            for (i = 0; i < ds.Tables["filiere"].Rows.Count; i++)
            {
                Majoutf.AddItem(ds.Tables["filiere"].Rows[i][0].ToString());
                MmodifierF.AddItem(ds.Tables["filiere"].Rows[i][0].ToString());
                MSuppF.AddItem(ds.Tables["filiere"].Rows[i][0].ToString());
            }
            int a;
            cmd = new SqlCommand("select max(id_module) from module", cnx);
            cnx.Open();
            dr = cmd.ExecuteReader();
            dr.Read();
            a = Convert.ToInt32(dr[0].ToString());
            a++;
            textBox4.Text = a.ToString();
            dr.Close();
            cnx.Close();
        }

        private void MmodifierF_onItemSelected(object sender, EventArgs e)
        {
            MmodifierM.Clear();
            adapter_module = new SqlDataAdapter("select m.disignation from module m,filiere f,filiere_module fm where f.disignation='" + MmodifierF.selectedValue.ToString() + "' and f.id_filiere=fm.id_filiere and fm.id_module=m.id_module", cnx);
            adapter_module.Fill(ds, "modif_module");
            for (int i = 0; i < ds.Tables["modif_module"].Rows.Count; i++)
                MmodifierM.AddItem(ds.Tables["modif_module"].Rows[i][0].ToString());
            ds.Tables["modif_module"].Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (MmodifierF.selectedIndex == 0 || MmodifierM.selectedIndex == -1) MessageBox.Show("veuillez entrez les champs vides", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    cmd = new SqlCommand("select * from module where id_module in (select m.id_module from module m,filiere_module fm, filiere f where m.disignation='" + MmodifierM.selectedValue.ToString() + "' and f.disignation='" + MmodifierF.selectedValue.ToString() + "' and m.id_module=fm.id_module and f.id_filiere=fm.id_filiere)", cnx);
                    cnx.Open();
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    textBox6.Text = dr["id_module"].ToString();
                    textBox5.Text = dr["disignation"].ToString();
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

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "" || MmodifierF.selectedIndex == -1 || MmodifierM.selectedIndex == -1) MessageBox.Show("veuillez entrez les champs vides", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    cmd = new SqlCommand("update module set disignation='" + textBox5.Text.ToString() + "' where id_module=" + Convert.ToInt32(textBox6.Text.ToString()), cnx);
                    cnx.Open();
                    cmd.ExecuteNonQuery();
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

        private void button8_Click(object sender, EventArgs e)
        {
            if (Majoutf.selectedValue.ToString() == " " || textBox3.Text == "") MessageBox.Show("veuillez entrez les champs vides", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    adapter_module = new SqlDataAdapter("select * from module", cnx);
                    builder_module = new SqlCommandBuilder(adapter_module);
                    adapter_module.Fill(ds, "Allmodule");
                    DataRow r;
                    r = ds.Tables["Allmodule"].NewRow();
                    r[0] = textBox4.Text.ToString();
                    r[1] = textBox3.Text.ToString();
                    ds.Tables["Allmodule"].Rows.Add(r);
                    adapter_module.Update(ds, "Allmodule");
                    ds.Tables["Allmodule"].AcceptChanges();
                    MessageBox.Show(r[1].ToString(), "Ajout", MessageBoxButtons.OK);
                    int a = Convert.ToInt32(textBox4.Text.Trim()) + 1;
                    textBox4.Text = a.ToString();
                    try
                    {
                        adapter_module = new SqlDataAdapter("select * from filiere_module", cnx);
                        builder_module = new SqlCommandBuilder(adapter_module);
                        adapter_module.Fill(ds, "Allfiliere_module");
                        DataRow rr;
                        rr = ds.Tables["Allfiliere_module"].NewRow();
                        rr[0] = Majoutf.selectedIndex+1;
                        rr[1] = Convert.ToInt32(textBox4.Text.ToString())-1;
                        ds.Tables["Allfiliere_module"].Rows.Add(rr);
                        adapter_module.Update(ds, "Allfiliere_module");
                        ds.Tables["Allfiliere_module"].AcceptChanges();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error : " + ex.Message);
                    }
                    try
                    {
                        adapter_module = new SqlDataAdapter("select * from Semestre_module", cnx);
                        builder_module = new SqlCommandBuilder(adapter_module);
                        adapter_module.Fill(ds, "s_module");
                        DataRow rr;
                        rr = ds.Tables["s_module"].NewRow();
                        rr[0] = Semestre.selectedIndex + 1;
                        rr[1] = Convert.ToInt32(textBox4.Text.ToString()) - 1;
                        ds.Tables["s_module"].Rows.Add(rr);
                        adapter_module.Update(ds, "s_module");
                        ds.Tables["s_module"].AcceptChanges();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error : " + ex.Message);
                    }
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

        private void MSuppF_onItemSelected(object sender, EventArgs e)
        {
            MsuppM.Clear();
            adapter_module = new SqlDataAdapter("select m.disignation from module m,filiere f,filiere_module fm where f.disignation='" + MSuppF.selectedValue.ToString() + "' and f.id_filiere=fm.id_filiere and fm.id_module=m.id_module", cnx);
            adapter_module.Fill(ds, "supp_module");
            for (int i = 0; i < ds.Tables["supp_module"].Rows.Count; i++)
                MsuppM.AddItem(ds.Tables["supp_module"].Rows[i][0].ToString());
            ds.Tables["supp_module"].Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (MSuppF.selectedIndex == 0 || MsuppM.selectedIndex == -1) MessageBox.Show("veuillez entrez les champs vides", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    cmd = new SqlCommand("select id_module from module where id_module in (select m.id_module from module m,filiere_module fm, filiere f where m.disignation='" + MsuppM.selectedValue.ToString() + "' and f.disignation='" + MSuppF.selectedValue.ToString() + "' and m.id_module=fm.id_module and f.id_filiere=fm.id_filiere)", cnx);
                    cnx.Open();
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    int a = Convert.ToInt32(dr["id_module"].ToString());
                    cnx.Close();
                    cmd = new SqlCommand("suppModulep", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter param = new SqlParameter();
                    param = new SqlParameter("@id", SqlDbType.Int);
                    param.Value = a;
                    cmd.Parameters.Add(param);
                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                    int b = Convert.ToInt32(textBox4.Text.Trim()) - 1;
                    textBox4.Text = b.ToString();
                    MessageBox.Show("module supprimé");
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
    }
}
