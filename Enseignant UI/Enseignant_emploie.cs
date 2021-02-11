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
    public partial class Enseignant_emploie : UserControl
    {
        SqlConnection cn = new SqlConnection(@"Server=DESKTOP-SEJ5RM7; DataBase=GestionDeNote; integrated Security = true");
        SqlCommand cmd;
        SqlDataReader dr;
        public _Enseignant Ens;
        public Enseignant_emploie()
        {
            InitializeComponent();
        }

        private void g(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Enseignant_emploie_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Lundi");
            dataGridView1.Rows.Add("Mardi");
            dataGridView1.Rows.Add("Mercredi");
            dataGridView1.Rows.Add("Jeudi");
            dataGridView1.Rows.Add("Vendredi");
            dataGridView1.Rows.Add("Samedi");
            cmd = new SqlCommand("select el.disignation, en.jour,en.heure from Enseigne en, Element el where en.CIN='" + Ens.gsCin + "' and  en.id_Element=el.id_Element", cn);
            cn.Open();
            dr = cmd.ExecuteReader();
            string[] jours = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi" };
            string[] heures = new string[] { "jour/heure", "8h00 - 9h30", "9h45 - 11h15", "11h30 - 13h", "14h00 - 15h30", "15h45 - 17h15", "17h30 - 19h" };
            while (dr.Read())
            {
                for (int i = 0; i < jours.Length; i++)
                {
                    if (jours[i] == dr[1].ToString())
                    {
                        for (int j = 1; j < heures.Length; j++)
                            if (heures[j] == dr[2].ToString())
                                dataGridView1.Rows[i].Cells[j].Value = dr[0].ToString();
                    }
                }
            }
            dr.Close();
            cn.Close();
        }
    }
}
