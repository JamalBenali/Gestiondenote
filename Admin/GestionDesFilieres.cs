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
    public partial class GestionDesFilieres : UserControl
    {
        private SqlDataAdapter adapter_filiere;
        private SqlCommandBuilder builder_filiere; // assurer l'ajout, modif,sup vers la bd
        DataSet ds = new DataSet();
        SqlConnection cnx = new SqlConnection(@"Server=DESKTOP-SEJ5RM7;DataBase=GestionDeNote;Integrated Security=true;");
        SqlCommand cmd;
        SqlDataReader dr;
        public GestionDesFilieres()
        {
            InitializeComponent();
            Settings_btn.FlatAppearance.MouseOverBackColor = Settings_btn.BackColor;
            Settings_btn.BackColorChanged += (s, e) =>
            {
                Settings_btn.FlatAppearance.MouseOverBackColor = Settings_btn.BackColor;
            };
            //==
            Settings_btn2.FlatAppearance.MouseOverBackColor = Settings_btn2.BackColor;
            Settings_btn2.BackColorChanged += (s, e) =>
            {
                Settings_btn.FlatAppearance.MouseOverBackColor = Settings_btn2.BackColor;
            };
            gestionDeFiliere1.Visible = true;
            gestionDeModule1.Visible = true;
            gestionDElement1.Visible = true;
            gestionDeFiliere1.BringToFront();
            gestionDElement1.SendToBack();
            gestionDeModule1.SendToBack();
        }
        public void updateFiliere()
        {
            gestionDeModule1.Majoutf.Clear();
            gestionDeModule1.MmodifierF.Clear();
            gestionDeModule1.MSuppF.Clear();
            gestionDElement1.EajoutF.Clear();
            gestionDElement1.EModifierF.Clear();
            gestionDElement1.ESuppF.Clear(); 
            adapter_filiere = new SqlDataAdapter("select disignation from filiere", cnx);
            adapter_filiere.Fill(ds, "filiere");
            for (int i = 0; i < ds.Tables["filiere"].Rows.Count; i++)
            {
                gestionDeModule1.Majoutf.AddItem(ds.Tables["filiere"].Rows[i][0].ToString());
                gestionDeModule1.MmodifierF.AddItem(ds.Tables["filiere"].Rows[i][0].ToString());
                gestionDeModule1.MSuppF.AddItem(ds.Tables["filiere"].Rows[i][0].ToString());
                gestionDElement1.EajoutF.AddItem(ds.Tables["filiere"].Rows[i][0].ToString());
                gestionDElement1.EModifierF.AddItem(ds.Tables["filiere"].Rows[i][0].ToString());
                gestionDElement1.ESuppF.AddItem(ds.Tables["filiere"].Rows[i][0].ToString());
            }
            ds.Tables["filiere"].Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            dropdown.Visible = false;
            gestionDeFiliere1.BringToFront();
            gestionDElement1.SendToBack();
            gestionDeModule1.SendToBack();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select max(id_element) from element", cnx);
            cnx.Open();
            dr = cmd.ExecuteReader();
            dr.Read();
            int a = Convert.ToInt32(dr[0].ToString());
            a++;
            gestionDElement1.textBox8.Text = a.ToString();
            dr.Close();
            cnx.Close();
            updateFiliere();
            dropdown.Visible = false;
            gestionDElement1.BringToFront();
            gestionDeModule1.SendToBack();
            gestionDeFiliere1.SendToBack();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select max(id_module) from module", cnx);
            cnx.Open();
            dr = cmd.ExecuteReader();
            dr.Read();
            int a = Convert.ToInt32(dr[0].ToString());
            a++;
            gestionDeModule1.textBox4.Text = a.ToString();
            dr.Close();
            cnx.Close();
            updateFiliere();
            dropdown.Visible = false;
            gestionDeModule1.BringToFront();
            gestionDElement1.SendToBack();
            gestionDeFiliere1.SendToBack();
        }

        private void Settings_btn2_Click(object sender, EventArgs e)
        {
            if (!dropdown.Visible)
            {
                
                dropdown.Visible = true;
                dropdown.BringToFront();
            }
            else
            {
                dropdown.Visible = false;
                dropdown.SendToBack();
            }
        }

        private void GestionDesFilieres_Load(object sender, EventArgs e)
        {

        }
    }
}
