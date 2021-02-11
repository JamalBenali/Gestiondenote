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
    public partial class Etudiant_Notes : UserControl
    {
        SqlConnection cn = new SqlConnection(@"Server=DESKTOP-SEJ5RM7; DataBase=GestionDeNote; integrated Security = true");
        SqlDataAdapter Da;
        SqlCommandBuilder cmdb;
        DataTable Dt = new DataTable();
        DataSet ds = new DataSet();
        public _Etudiant Etd = new _Etudiant();
        public Etudiant_Notes()
        {
            InitializeComponent();
        }

        private void bunifuDropdown2_onItemSelected(object sender, EventArgs e)
        {
            Dt.Clear();
            Da = new SqlDataAdapter("select m.disignation as Module,e.disignation as Element,n.note as Note,n.date as Date from Module m, Element e, Notes n, semestre s, Semestre_Module sm, Module_Element me where n.CNE = '" + Etd.gsCNE + "' and n.id_Element = e.id_Element and e.id_Element = me.id_Element and me.id_Module = m.id_Module and m.id_Module = sm.id_Module and sm.id_Semestre = s.id_Semestre and s.designation = '" + bunifuDropdown2.selectedValue.ToString() + "'", cn);
            cmdb = new SqlCommandBuilder(Da);
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
            dataGridView1.Visible = true;
        }

        private void Etudiant_Notes_Load(object sender, EventArgs e)
        {
            Dt.Clear();
            Da = new SqlDataAdapter("select S.designation from Semestre S,inscription I where S.id_Semestre = I.id_Semestre and I.CNE = '"+Etd.gsCNE+"'", cn);
            cmdb = new SqlCommandBuilder(Da);
            Da.Fill(Dt);
            for (int i = 0; i < Dt.Rows.Count; i++)
                bunifuDropdown2.AddItem(Dt.Rows[i][0].ToString());
            Dt.Reset();
            bunifuDropdown2.selectedIndex = 1;
            Dt.Clear();
            Da = new SqlDataAdapter("select m.disignation as Module,e.disignation as Element,n.note as Note,n.date as Date from Module m, Element e, Notes n, semestre s, Semestre_Module sm, Module_Element me where n.CNE = '" + Etd.gsCNE + "' and n.id_Element = e.id_Element and e.id_Element = me.id_Element and me.id_Module = m.id_Module and m.id_Module = sm.id_Module and sm.id_Semestre = s.id_Semestre and s.designation = '" + bunifuDropdown2.selectedValue.ToString() + "'", cn);
            cmdb = new SqlCommandBuilder(Da);
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
            dataGridView1.Visible = true;
        }
        
    }
}
