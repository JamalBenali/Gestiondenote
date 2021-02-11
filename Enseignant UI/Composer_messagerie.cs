using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;

namespace PFE.Enseignant_UI
{
    public partial class Composer_messagerie : UserControl
    {
        private string connectionString = "Server=DESKTOP-SEJ5RM7; DataBase=GestionDeNote; integrated Security = true";
        private SqlConnection con;
        private SqlDataAdapter da, da_getEmail;
        private DataSet ds;
        private static string esta_email = "estagadir2019@gmail.com";
        private static string esta_password = "ESTagadir2019";

        public Composer_messagerie()
        {
            InitializeComponent();
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
            email_body.SelectionFont = new Font(Convert.ToString(bunifuDropdown1.selectedValue), Convert.ToInt16(text_size.selectedValue));
        }

        private void Composer_messagerie_Load(object sender, EventArgs e)
        {
            //Loading Fonts into the Combo Box
            List<string> fonts = new List<string>();

            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                fonts.Add(font.Name);
            }
            bunifuDropdown1.Items = fonts.ToArray();
            bunifuDropdown1.selectedIndex = 1;
            //Loading Teachers into the Combo Box
            con = new SqlConnection(connectionString);
            da = new SqlDataAdapter("SELECT Nom, Prenom From Enseignant", con);
            ds = new DataSet();
            List<string> Enseignants = new List<string>();
            try
            {
                da.Fill(ds, "Enseignants");
                if (ds.Tables["Enseignants"].Rows.Count != 0)
                {
                    foreach (DataRow ens in ds.Tables["Enseignants"].Rows)
                    {
                        Enseignants.Add(ens["Nom"] + " " + ens["Prenom"]);
                    }
                }
                else
                    Enseignants.Add("Pas de données à afficher");
                this.esta_destination.Items = Enseignants.ToArray();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur ! \nPlus de détails : " + ex.ToString());
            }
        }

        private void text_color_onItemSelected(object sender, EventArgs e)
        {


        }

        private void bunifuDropdown3_onItemSelected(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string destination_nom = esta_destination.selectedValue;
            string Query = "SELECT Email FROM Enseignant WHERE ( Nom + ' ' + prenom) = '" + esta_destination.selectedValue + "'";
            con = new SqlConnection(connectionString);
            da_getEmail = new SqlDataAdapter(Query, con);
            ds = new DataSet();
            try
            {
                da_getEmail.Fill(ds, "destination");
                if(ds.Tables["destination"].Rows.Count != 0)
                {
                    string destination = ds.Tables["destination"].Rows[0]["email"].ToString();
                    //Traitement
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                    //Email informations
                    mail.From = new MailAddress(esta_email);
                    mail.To.Add(destination);
                    mail.Subject = email_sujet.Text;
                    mail.Body = email_body.Text;
                    //SMTP (Simple Mail Transfer Protocole) Settings
                    SmtpServer.Port = 587;
                    SmtpServer.UseDefaultCredentials = true;
                    SmtpServer.Credentials = new NetworkCredential(esta_email, esta_password);
                    SmtpServer.EnableSsl = true;
                    //Sending the email
                    SmtpServer.Send(mail);
                    MessageBox.Show("Email Envoyé Avec Succes ");
                    this.Hide();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur ! \nPlus de détails : " + ex.ToString());
            }
        }

        private void esta_destination_onItemSelected(object sender, EventArgs e)
        {

        }

        private void text_bold_Click(object sender, EventArgs e)
        {
            email_body.Font = new Font(Convert.ToString(bunifuDropdown1.selectedValue), Convert.ToInt16(text_size.selectedValue), FontStyle.Bold);
        }

        private void text_italic_Click(object sender, EventArgs e)
        {
            email_body.Font = new Font(Convert.ToString(bunifuDropdown1.selectedValue), Convert.ToInt16(text_size.selectedValue), FontStyle.Italic);
        }

        private void text_underlined_Click(object sender, EventArgs e)
        {
            email_body.Font = new Font(Convert.ToString(bunifuDropdown1.selectedValue), Convert.ToInt16(text_size.selectedValue), FontStyle.Underline);
        }

        private void text_size_onItemSelected(object sender, EventArgs e)
        {
            email_body.Font = new Font(Convert.ToString(bunifuDropdown1.selectedValue), Convert.ToInt16(text_size.selectedValue));
        }

        private void bunifuDropdown2_Click(object sender, EventArgs e)
        {
            DialogResult res = colorDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                email_body.ForeColor = colorDialog1.Color;
            }
        }
    }
}
