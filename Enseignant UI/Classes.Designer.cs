namespace PFE.Enseignant_UI
{
    partial class Classes
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CNE1 = new System.Windows.Forms.Panel();
            this.CNE = new System.Windows.Forms.RichTextBox();
            this.Nom1 = new System.Windows.Forms.Panel();
            this.Nom = new System.Windows.Forms.RichTextBox();
            this.Prenom1 = new System.Windows.Forms.Panel();
            this.Prenom = new System.Windows.Forms.RichTextBox();
            this.Note1 = new System.Windows.Forms.Panel();
            this.Note = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.CNE1.SuspendLayout();
            this.Nom1.SuspendLayout();
            this.Prenom1.SuspendLayout();
            this.Note1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 35);
            this.panel1.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Gray;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 35);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(92, 1);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mes Classes";
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BorderRadius = 3;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown1.Items = new string[] {
        "Choisissez un Element"};
            this.bunifuDropdown1.Location = new System.Drawing.Point(8, 58);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(126)))), ((int)(((byte)(243)))));
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.Blue;
            this.bunifuDropdown1.selectedIndex = 0;
            this.bunifuDropdown1.Size = new System.Drawing.Size(188, 27);
            this.bunifuDropdown1.TabIndex = 7;
            this.bunifuDropdown1.onItemSelected += new System.EventHandler(this.bunifuDropdown1_onItemSelected);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeight = 40;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(3, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(436, 368);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // CNE1
            // 
            this.CNE1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CNE1.Controls.Add(this.CNE);
            this.CNE1.Location = new System.Drawing.Point(466, 111);
            this.CNE1.Name = "CNE1";
            this.CNE1.Size = new System.Drawing.Size(259, 45);
            this.CNE1.TabIndex = 14;
            // 
            // CNE
            // 
            this.CNE.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CNE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CNE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CNE.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CNE.Location = new System.Drawing.Point(3, 9);
            this.CNE.Name = "CNE";
            this.CNE.ReadOnly = true;
            this.CNE.Size = new System.Drawing.Size(253, 28);
            this.CNE.TabIndex = 5;
            this.CNE.Text = "CNE";
            // 
            // Nom1
            // 
            this.Nom1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Nom1.Controls.Add(this.Nom);
            this.Nom1.Location = new System.Drawing.Point(466, 162);
            this.Nom1.Name = "Nom1";
            this.Nom1.Size = new System.Drawing.Size(259, 45);
            this.Nom1.TabIndex = 15;
            // 
            // Nom
            // 
            this.Nom.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Nom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Nom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Nom.Location = new System.Drawing.Point(3, 9);
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            this.Nom.Size = new System.Drawing.Size(253, 28);
            this.Nom.TabIndex = 6;
            this.Nom.Text = "Nom";
            // 
            // Prenom1
            // 
            this.Prenom1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Prenom1.Controls.Add(this.Prenom);
            this.Prenom1.Location = new System.Drawing.Point(466, 213);
            this.Prenom1.Name = "Prenom1";
            this.Prenom1.Size = new System.Drawing.Size(259, 45);
            this.Prenom1.TabIndex = 16;
            // 
            // Prenom
            // 
            this.Prenom.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Prenom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Prenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Prenom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prenom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Prenom.Location = new System.Drawing.Point(4, 9);
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            this.Prenom.Size = new System.Drawing.Size(253, 28);
            this.Prenom.TabIndex = 6;
            this.Prenom.Text = "Prenom";
            // 
            // Note1
            // 
            this.Note1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Note1.Controls.Add(this.Note);
            this.Note1.Location = new System.Drawing.Point(466, 264);
            this.Note1.Name = "Note1";
            this.Note1.Size = new System.Drawing.Size(259, 45);
            this.Note1.TabIndex = 17;
            // 
            // Note
            // 
            this.Note.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Note.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Note.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Note.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Note.Location = new System.Drawing.Point(3, 9);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(253, 28);
            this.Note.TabIndex = 6;
            this.Note.Text = "Note";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(170)))), ((int)(((byte)(236)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(509, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 30);
            this.button2.TabIndex = 21;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(183)))), ((int)(((byte)(49)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(320, 55);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 30);
            this.button4.TabIndex = 22;
            this.button4.Text = "Modifier";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(183)))), ((int)(((byte)(49)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(202, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 30);
            this.button3.TabIndex = 23;
            this.button3.Text = "Ajouter Notes";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Classes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Note1);
            this.Controls.Add(this.Prenom1);
            this.Controls.Add(this.Nom1);
            this.Controls.Add(this.CNE1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bunifuDropdown1);
            this.Controls.Add(this.panel1);
            this.Name = "Classes";
            this.Size = new System.Drawing.Size(733, 469);
            this.Load += new System.EventHandler(this.Classes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.CNE1.ResumeLayout(false);
            this.Nom1.ResumeLayout(false);
            this.Prenom1.ResumeLayout(false);
            this.Note1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel CNE1;
        private System.Windows.Forms.RichTextBox CNE;
        private System.Windows.Forms.Panel Nom1;
        private System.Windows.Forms.RichTextBox Nom;
        private System.Windows.Forms.Panel Prenom1;
        private System.Windows.Forms.RichTextBox Prenom;
        private System.Windows.Forms.Panel Note1;
        private System.Windows.Forms.RichTextBox Note;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}
