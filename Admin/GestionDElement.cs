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
    public partial class GestionDElement : UserControl
    {
        private SqlDataAdapter adapter_filiere;
        private SqlDataAdapter adapter_module;
        private SqlDataAdapter adapter_element;
        SqlConnection cnx = new SqlConnection(@"Server=DESKTOP-SEJ5RM7;DataBase=GestionDeNote;Integrated Security=true;");
        DataSet ds = new DataSet();
        private SqlCommandBuilder builder_element;
        SqlCommand cmd;
        SqlDataReader dr;
        public GestionDElement()
        {
            InitializeComponent();
            adapter_filiere = new SqlDataAdapter("select disignation from filiere", cnx);
            adapter_filiere.Fill(ds, "filiere");
            int i;
            for (i = 0; i < ds.Tables["filiere"].Rows.Count; i++)
            {
                EajoutF.AddItem(ds.Tables["filiere"].Rows[i][0].ToString());
                EModifierF.AddItem(ds.Tables["filiere"].Rows[i][0].ToString());
                ESuppF.AddItem(ds.Tables["filiere"].Rows[i][0].ToString());
            }
            cmd = new SqlCommand("select max(id_element) from element", cnx);
            cnx.Open();
            int a;
            dr = cmd.ExecuteReader();
            dr.Read();
            a = Convert.ToInt32(dr[0].ToString());
            a++;
            textBox8.Text = a.ToString();
            dr.Close();
            cnx.Close();
        }

        private void EajoutF_onItemSelected(object sender, EventArgs e)
        {
            EajoutM.Clear();
            adapter_module = new SqlDataAdapter("select m.disignation from module m,filiere f,filiere_module fm where f.disignation='" + EajoutF.selectedValue.ToString() + "' and f.id_filiere=fm.id_filiere and fm.id_module=m.id_module", cnx);
            adapter_module.Fill(ds, "ajout_elementM");
            for (int i = 0; i < ds.Tables["ajout_elementM"].Rows.Count; i++)
                EajoutM.AddItem(ds.Tables["ajout_elementM"].Rows[i][0].ToString());
            ds.Tables["ajout_elementM"].Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "" || EajoutF.selectedIndex == 0 || EajoutM.selectedIndex == -1) MessageBox.Show("veuillez entrez les champs vides", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    adapter_element = new SqlDataAdapter("select * from element", cnx);
                    builder_element = new SqlCommandBuilder(adapter_element);
                    adapter_element.Fill(ds, "Allelement");
                    DataRow r;
                    r = ds.Tables["Allelement"].NewRow();
                    r[0] = textBox8.Text.ToString();
                    r[1] = textBox7.Text.ToString();
                    ds.Tables["Allelement"].Rows.Add(r);
                    adapter_element.Update(ds, "Allelement");
                    ds.Tables["Allelement"].AcceptChanges();
                    MessageBox.Show(r[1].ToString(), "Add element", MessageBoxButtons.OK);
                    int a = Convert.ToInt32(textBox8.Text.Trim()) + 1;
                    textBox8.Text = a.ToString();
                    try
                    {
                        adapter_element = new SqlDataAdapter("select * from Module_Element", cnx);
                        builder_element = new SqlCommandBuilder(adapter_element);
                        adapter_element.Fill(ds, "Allmodule_element");
                        cmd = new SqlCommand("select id_module from module where id_module in (select m.id_module from module m,filiere_module fm, filiere f where m.disignation='" + EajoutM.selectedValue.ToString() + "' and f.disignation='" + EajoutF.selectedValue.ToString() + "' and m.id_module=fm.id_module and f.id_filiere=fm.id_filiere)", cnx);
                        cnx.Open();
                        dr = cmd.ExecuteReader();
                        dr.Read();
                        DataRow rr;
                        rr = ds.Tables["Allmodule_element"].NewRow();
                        rr[0] = dr[0].ToString();
                        dr.Close();
                        rr[1] = Convert.ToInt32(textBox8.Text.ToString()) - 1;
                        ds.Tables["Allmodule_element"].Rows.Add(rr);
                        adapter_element.Update(ds, "Allmodule_element");
                        ds.Tables["Allmodule_element"].AcceptChanges();
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

        private void EModifierF_onItemSelected(object sender, EventArgs e)
        {
            EmodifierM.Clear();
            adapter_module = new SqlDataAdapter("select m.disignation from module m,filiere f,filiere_module fm where f.disignation='" + EModifierF.selectedValue.ToString() + "' and f.id_filiere=fm.id_filiere and fm.id_module=m.id_module", cnx);
            adapter_module.Fill(ds, "modifier_elementM");
            for (int i = 0; i < ds.Tables["modifier_elementM"].Rows.Count; i++)
                EmodifierM.AddItem(ds.Tables["modifier_elementM"].Rows[i][0].ToString());
            ds.Tables["modifier_elementM"].Clear();
        }

        private void EmodifierM_onItemSelected(object sender, EventArgs e)
        {
            EmodifierE.Clear();
            adapter_module = new SqlDataAdapter("select e.disignation from module m, element e, Module_element em where m.disignation='" + EmodifierM.selectedValue.ToString() + "' and m.id_module= em.id_module and em.id_Element= e.id_Element", cnx);
            adapter_module.Fill(ds, "modifier_elementE");
            for (int i = 0; i < ds.Tables["modifier_elementE"].Rows.Count; i++)
                EmodifierE.AddItem(ds.Tables["modifier_elementE"].Rows[i][0].ToString());
            ds.Tables["modifier_elementE"].Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (EModifierF.selectedIndex == 0 || EmodifierM.selectedIndex == -1 || EmodifierE.selectedIndex == -1) MessageBox.Show("veuillez entrez les champs vides", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    cmd = new SqlCommand("select * from element where id_element in (select e.id_element from element e,module_element me, module m where e.disignation='" + EmodifierE.selectedValue.ToString() + "' and m.disignation='" + EmodifierM.selectedValue.ToString() + "' and e.id_element=me.id_element and m.id_module=me.id_module)", cnx);
                    cnx.Open();
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    textBox10.Text = dr["id_element"].ToString();
                    textBox9.Text = dr["disignation"].ToString();
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

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox9.Text == "" || EModifierF.selectedIndex == -1 || EmodifierM.selectedIndex == -1 || EmodifierE.selectedIndex == -1) MessageBox.Show("veuillez entrez les champs vides", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    cmd = new SqlCommand("update element set disignation='" + textBox9.Text.ToString() + "' where id_element=" + Convert.ToInt32(textBox10.Text.ToString()), cnx);
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

        private void ESuppF_onItemSelected(object sender, EventArgs e)
        {
            EsuppM.Clear();
            adapter_module = new SqlDataAdapter("select m.disignation from module m,filiere f,filiere_module fm where f.disignation='" + ESuppF.selectedValue.ToString() + "' and f.id_filiere=fm.id_filiere and fm.id_module=m.id_module", cnx);
            adapter_module.Fill(ds, "supp_elementM");
            for (int i = 0; i < ds.Tables["supp_elementM"].Rows.Count; i++)
                EsuppM.AddItem(ds.Tables["supp_elementM"].Rows[i][0].ToString());
            ds.Tables["supp_elementM"].Clear();
        }

        private void EsuppM_onItemSelected(object sender, EventArgs e)
        {
            EsuppE.Clear();
            adapter_module = new SqlDataAdapter("select e.disignation from module m, element e, Module_element em where m.disignation='" + EsuppM.selectedValue.ToString() + "' and m.id_module= em.id_module and em.id_Element= e.id_Element", cnx);
            adapter_module.Fill(ds, "supp_elementE");
            for (int i = 0; i < ds.Tables["supp_elementE"].Rows.Count; i++)
                EsuppE.AddItem(ds.Tables["supp_elementE"].Rows[i][0].ToString());
            ds.Tables["supp_elementE"].Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (ESuppF.selectedIndex == -1 || EsuppM.selectedIndex == -1 || EsuppE.selectedIndex == -1) MessageBox.Show("veuillez entrez les champs vides", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    cmd = new SqlCommand("delete from element where id_element in (select e.id_element from element e,module_element me, module m where e.disignation='" + EsuppE.selectedValue.ToString() + "' and m.disignation='" + EsuppM.selectedValue.ToString() + "' and e.id_element=me.id_element and m.id_module=me.id_module)", cnx);
                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    int a = Convert.ToInt32(textBox8.Text.Trim()) - 1;
                    textBox8.Text = a.ToString();
                    MessageBox.Show("element supprimé");
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
