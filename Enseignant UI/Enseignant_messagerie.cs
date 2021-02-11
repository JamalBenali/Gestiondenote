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

namespace PFE
{
    public partial class Enseignant_messagerie : UserControl
    {
        private SqlConnection con;
        private string connectionString = "Server=DESKTOP-SEJ5RM7; DataBase=GestionDeNote; integrated Security = true";
        private SqlDataAdapter da;
        private DataSet ds;
        private BindingSource bs;

        public Enseignant_messagerie()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Enseignant_messagerie_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectionString);
            string Destinataire = "E497141";//CIN of the receiver
            string Query = "SELECT CIN, Sujet, Message FROM Messagerie WHERE Destinataire = '"+Destinataire+"'";
            da = new SqlDataAdapter(Query, con);
            ds = new DataSet();
            bs = new BindingSource();
            try
            {
                da.Fill(ds, "Messagerie");
                if (ds.Tables["Messagerie"].Rows.Count != 0)
                {
                    bs.DataSource = ds.Tables["Messagerie"];
                    dataGridView1.DataSource = bs;
                }
                else
                    MessageBox.Show("Aucun message à afficher !");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur ! " + ex.ToString());
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            composer_messagerie1.Visible = true;
            composer_messagerie1.BringToFront();
        }

        private void Inbox_Click(object sender, EventArgs e)
        {
            composer_messagerie1.Visible = false;
            dataGridView1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.BringToFront();
            blue_sidepanel.Height = button1.Height;
            blue_sidepanel.Top = button1.Top;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*blue_sidepanel.Height = button2.Height;
            blue_sidepanel.Top = button2.Top;*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.BringToFront();
            blue_sidepanel.Height = button3.Height;
            blue_sidepanel.Top = button3.Top;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.BringToFront();
            blue_sidepanel.Height = button4.Height;
            blue_sidepanel.Top = button4.Top;
        }

        private void Inbox_Click_1(object sender, EventArgs e)
        {
            dataGridView1.BringToFront();
            blue_sidepanel.Height = Inbox.Height;
            blue_sidepanel.Top = Inbox.Top;
        }

        private void composer_messagerie1_Load(object sender, EventArgs e)
        {

        }
    }
}
