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
    public partial class GestionDesNotes : UserControl
    {
        private SqlDataAdapter adapter_filiere;
        DataSet ds = new DataSet();
        SqlConnection cnx = new SqlConnection(@"Server=DESKTOP-SEJ5RM7;DataBase=GestionDeNote;Integrated Security=true;");
        List<int> filierelist = new List<int>();
        List<int> elementlist = new List<int>();
        List<int> modulelist = new List<int>();
        SqlDataAdapter Da;
        SqlCommandBuilder cmdb;
        DataTable Dt = new DataTable();
        bool premierf = true;
        bool premierm = true;
        bool premiere = true;
        private SqlDataAdapter da;
        public _Etudiant Etd;
        public DataTable Notes = new DataTable();
        DataRow r;
        List<string> Sem = new List<string>();
        public GestionDesNotes()
        {
            InitializeComponent();
            adapter_filiere = new SqlDataAdapter("select id_filiere,disignation from filiere", cnx);
            adapter_filiere.Fill(ds, "filiere");
            int i;
            for (i = 0; i < ds.Tables["filiere"].Rows.Count; i++)
            {
                Filiere.AddItem(ds.Tables["filiere"].Rows[i][1].ToString());
                filierelist.Add(Convert.ToInt32(ds.Tables["filiere"].Rows[i][0].ToString()));
            }
        }

        private void Filiere_onItemSelected(object sender, EventArgs e)
        {
            module.Clear();
            element.Clear();
            modulelist.Clear();
            elementlist.Clear();//on efface la liste des elements pour qu'il soit prete pour recevoir des nouveaux elements d'un autre module
            adapter_filiere = new SqlDataAdapter("select m.id_module,m.disignation from module m,filiere f,filiere_module fm where f.disignation='" + Filiere.selectedValue.ToString() + "' and f.id_filiere=fm.id_filiere and fm.id_module=m.id_module", cnx);
            adapter_filiere.Fill(ds, "module");
            for (int i = 0; i < ds.Tables["module"].Rows.Count; i++) { 
                module.AddItem(ds.Tables["module"].Rows[i][1].ToString());
                modulelist.Add(Convert.ToInt32(ds.Tables["module"].Rows[i][0].ToString()));
            }
            ds.Tables["module"].Clear();
        }

        private void module_onItemSelected(object sender, EventArgs e)
        {
            element.Clear();
            elementlist.Clear();
            adapter_filiere = new SqlDataAdapter("select e.id_element,e.disignation from module m, element e, Module_element em where m.disignation='" + module.selectedValue.ToString() + "' and m.id_module= em.id_module and em.id_Element= e.id_Element", cnx);
            adapter_filiere.Fill(ds, "elementE");
            for (int i = 0; i < ds.Tables["elementE"].Rows.Count; i++)
            {
                element.AddItem(ds.Tables["elementE"].Rows[i][1].ToString());
                elementlist.Add(Convert.ToInt32(ds.Tables["elementE"].Rows[i][0].ToString()));
            }
            ds.Tables["elementE"].Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (Filiere.selectedIndex!=-1 && module.selectedIndex == -1 && element.selectedIndex == -1) {
                if (premierf == false) ds.Tables["noteannee"].Clear();
                Da = new SqlDataAdapter("select e.CNE,e.nom,e.prenom,f.disignation as 'filière' from etudiant e,inscription i,filiere f where i.CNE=e.CNE and f.id_filiere=i.id_filiere and i.id_filiere=" + Convert.ToInt32(filierelist.ElementAt(Filiere.selectedIndex)), cnx);
            cmdb = new SqlCommandBuilder(Da);
            Da.Fill(ds,"noteannee");
            dataGridView1.DataSource = ds.Tables["noteannee"];
                premierf = false;
            }
            else if(Filiere.selectedIndex != -1 && module.selectedIndex != -1 && element.selectedIndex == -1)
            {
                if (premierm == false) ds.Tables["notemodule"].Clear();
                Da = new SqlDataAdapter("select e.CNE,e.nom,e.prenom,f.disignation as 'filière',module='" + module.selectedValue+"' from etudiant e,inscription i,filiere f where i.CNE=e.CNE and f.id_filiere=i.id_filiere and i.id_filiere=" + Convert.ToInt32(filierelist.ElementAt(Filiere.selectedIndex)), cnx);
                cmdb = new SqlCommandBuilder(Da);
                Da.Fill(ds,"notemodule");
                dataGridView1.DataSource = ds.Tables["notemodule"];
                premierm = false;
            }
            else if (Filiere.selectedIndex != -1 && module.selectedIndex != -1 && element.selectedIndex != -1)
            {
                if (premiere == false) ds.Tables["noteElement"].Clear();
                Da = new SqlDataAdapter("select e.CNE,e.nom,e.prenom,f.disignation as 'filière',module = '" + module.selectedValue + "',élément ='" + element.selectedValue + "',n.note from etudiant e, filiere f,notes n where f.id_filiere = " + Convert.ToInt32(filierelist.ElementAt(Filiere.selectedIndex)) + " and n.CNE = e.CNE and n.id_element =" + elementlist.ElementAt(element.selectedIndex)+" order by e.nom", cnx);
                cmdb = new SqlCommandBuilder(Da);
                Da.Fill(ds,"noteElement");
                dataGridView1.DataSource = ds.Tables["noteElement"];
                premiere = false;
            }
        }
        private void Etudiant_parcours_Load(object sender, EventArgs e)
        {
            /*Sem = Semestre_Avec_Notes();*/
            Notes.Columns.Add("Semestre");
            Notes.Columns.Add("Moyenne");
            for (int i = 0; i < Sem.Count; i++)
            {
                Dt.Reset();
                da = new SqlDataAdapter("select S.designation, CAST(AVG(NM.Note) AS DECIMAL(10,2)) from F_NotesModules ('" + Etd.gsCNE + "') NM,Semestre_Module SM, Semestre S where SM.id_Module = NM.id_Module and S.id_Semestre = SM.id_Semestre and S.designation = '" + Sem.ElementAt(i) + "' group by S.designation", cnx);
                cmdb = new SqlCommandBuilder(da);
                da.Fill(Dt);
                r = Notes.NewRow();
                r[0] = Dt.Rows[0][0];
                r[1] = Dt.Rows[0][1];
                Notes.Rows.Add(r);
            }

            dataGridView1.DataSource = Notes;
        }
        /*private List<string> Semestre_Avec_Notes()
        {
            List<string> S = new List<string>();
            Boolean V;
            DataTable dt = new DataTable();

            for (int i = 0; i < Etd.gsSemestre.Count; i++)
            {
                V = false;
                List<int> Module = module_in_semestre(Etd.gsSemestre.ElementAt(i));
                for (int k = 0; k < Module.Count; k++)
                {
                    List<int> Element = element_in_module(Module.ElementAt(k));
                    for (int m = 0; m < Element.Count; m++)
                    {
                        V = note_in_Element(Element.ElementAt(m));
                    }
                }
                if (!V)
                    S.Add(Etd.gsSemestre.ElementAt(i));
            }
            return S;
        }*/
        private List<int> module_in_semestre(string Semi)
        {
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select M.id_Module from Module M,Semestre_Module SM,Filiere_Module FM,Semestre S where M.id_Module = SM.id_Module and M.id_Module = FM.id_Module and SM.id_Semestre = S.id_Semestre and id_Filiere = " + Etd.gsFiliere + " and S.designation = '" + Semi + "'", cnx);
            cmdb = new SqlCommandBuilder(da);
            da.Fill(dt);
            List<int> Module = new List<int>();
            for (int j = 0; j < dt.Rows.Count; j++)
                Module.Add(Convert.ToInt32(dt.Rows[j][0].ToString()));
            dt.Reset();
            return Module;
        }
        private List<int> element_in_module(int module)
        {
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select id_element from Module_Element where id_Module  = " + module, cnx);
            cmdb = new SqlCommandBuilder(da);
            da.Fill(dt);
            List<int> Element = new List<int>();
            for (int l = 0; l < dt.Rows.Count; l++)
                Element.Add(Convert.ToInt32(dt.Rows[l][0].ToString()));
            dt.Reset();
            return Element;
        }
        private Boolean note_in_Element(int elem)
        {
            DataTable dt = new DataTable();
            Boolean V = false;
            da = new SqlDataAdapter("select note from notes where id_Element  = " + elem + " and CNE = '" + Etd.gsCNE + "'", cnx);
            cmdb = new SqlCommandBuilder(da); da.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                V = true;
            }
            dt.Reset();
            return V;
        }
    }
}
