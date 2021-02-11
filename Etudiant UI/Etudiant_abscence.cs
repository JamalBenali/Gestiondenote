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
    public partial class Etudiant_abscence : UserControl
    {
        SqlConnection cn = new SqlConnection(@"Server=DESKTOP-SEJ5RM7; DataBase=GestionDeNote; integrated Security = true");
        SqlDataAdapter Da;
        SqlCommandBuilder cmdb;
        DataTable Dt = new DataTable();
        DataSet ds = new DataSet();
        public _Etudiant Etd = new _Etudiant();

        public Etudiant_abscence()
        {
            InitializeComponent();
        }

        private void Etudiant_abscence_Load(object sender, EventArgs e)
        {
            Dt.Clear();
            Da = new SqlDataAdapter("select A.Date,A.Heure,E.disignation as Matiere,A.justifier_NonJustifier as Justification from abscence A,Element E where A.id_Element = E.id_Element and A.CNE='" + Etd.gsCNE + "'", cn);
            cmdb = new SqlCommandBuilder(Da);
            Da.Fill(Dt);
            absenceGridView.DataSource = Dt;

            absenceGridView.BorderStyle = BorderStyle.None;
            absenceGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            absenceGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            absenceGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            absenceGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            absenceGridView.BackgroundColor = Color.White;
            absenceGridView.EnableHeadersVisualStyles = false;
            absenceGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            absenceGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            absenceGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void absenceGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in absenceGridView.Rows)
            {
                if (row.Cells[3].Value.Equals("+"))
                {
                    row.Cells[3].Style.BackColor = Color.FromArgb(137,224,141);
                }else if (row.Cells[3].Value.Equals("-"))
                {
                    row.Cells[3].Style.BackColor = Color.FromArgb(255,85,85);
                }
            }
        }
    }
}
