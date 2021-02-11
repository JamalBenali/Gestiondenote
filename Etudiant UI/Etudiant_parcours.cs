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

namespace PFE.Etudiant_UI
{
    public partial class Etudiant_parcours : UserControl
    {
        private SqlConnection con;
        private string connectionString = "Server=DESKTOP-SEJ5RM7; DataBase=GestionDeNote; integrated Security = true";
        private SqlDataAdapter da;
        private DataSet ds;
        private BindingSource bs;
        public _Etudiant Etd;
        public Etudiant_parcours()
        {
            InitializeComponent();
        }

        private void Etudiant_parcours_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            da = new SqlDataAdapter("SELECT designation as 'Semestre', AVG(note) as 'Note' FROM Semestre, dbo.F_NotesModules('"+Etd.gsCNE+"') WHERE id_Module in (SELECT id_Module FROM Semestre_Module WHERE id_Semestre=Semestre.id_Semestre ) GROUP BY Semestre.designation", con);
            ds = new DataSet();
            bs = new BindingSource();
            da.Fill(ds, "Parcours");
            try
            {
                bs.DataSource = ds.Tables["Parcours"];
                dataGridView1.DataSource = bs;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur !\n " + ex.ToString());
            }
        }
    }
}
