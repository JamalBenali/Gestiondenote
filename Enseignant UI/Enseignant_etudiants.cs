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
    public partial class Enseignant_etudiants : UserControl
    {
        SqlConnection con;
        string connectionString = "Server=DESKTOP-SEJ5RM7; DataBase=GestionDeNote; integrated Security = true";
        SqlDataAdapter da;
        DataSet ds;
        public _Enseignant Ens = new _Enseignant();
        public Enseignant_etudiants()
        {
            InitializeComponent();
        }

        private void Enseignant_etudiants_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            da = new SqlDataAdapter("SELECT * FROM Etudiant", con);
            ds = new DataSet();
            BindingSource bs = new BindingSource();
            try
            {
                da.Fill(ds, "Etudiants");
                bs.DataSource = ds.Tables["Etudiants"];
                dataGridView1.DataSource = bs;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur d'affichage ! \n plus de détails : " + ex.ToString());
            }
            //Modifier le bouton de statistiques
            Statistiques.Width = 100;
            //Deplacer le bouton de statistiques à la fin
                DataGridViewColumnCollection columnCollection = dataGridView1.Columns;

                DataGridViewColumn firstVisibleColumn =
                    columnCollection.GetFirstColumn(DataGridViewElementStates.Visible);
                DataGridViewColumn lastVisibleColumn =
                    columnCollection.GetLastColumn(
                        DataGridViewElementStates.Visible, DataGridViewElementStates.None);

                int firstColumn_sIndex = firstVisibleColumn.DisplayIndex;
                firstVisibleColumn.DisplayIndex = lastVisibleColumn.DisplayIndex;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
