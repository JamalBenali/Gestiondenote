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
    public partial class AdminProfile : UserControl
    {
        SqlConnection cn = new SqlConnection(@"Server=DESKTOP-SEJ5RM7; DataBase=GestionDeNote; integrated Security=true");
        SqlDataAdapter Da;
        SqlCommandBuilder cmdb;
        DataTable Dt = new DataTable();
        DataSet ds = new DataSet();
        public Administrateur admin;

        public AdminProfile()
        {
            InitializeComponent();
        }

        private void AdminProfile_Load(object sender, EventArgs e)
        {
                Dt.Clear();
                Da = new SqlDataAdapter("select Nom,Prenom,DateDeNaissance,lieuDeNaissance,Sexe from Administrateur where CIN='" + admin.gsCin + "'", cn);
                cmdb = new SqlCommandBuilder(Da);
                Da.Fill(Dt);

                label9.Text = Dt.Rows[0][0].ToString();
                label10.Text = Dt.Rows[0][1].ToString();
                label11.Text = Dt.Rows[0][2].ToString().Substring(0, 10);
                label12.Text = Dt.Rows[0][3].ToString();
                label13.Text = Dt.Rows[0][4].ToString();
        }
    }
}
