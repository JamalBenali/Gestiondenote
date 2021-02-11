namespace PFE.Enseignant_UI
{
    partial class Ens_abscence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ens_abscence));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dropdown = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Settings_btn = new System.Windows.Forms.Button();
            this.Settings_btn2 = new System.Windows.Forms.Button();
            this.students_liste = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridView1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.nouvelleAbs1 = new PFE.Enseignant_UI.NouvelleAbs();
            this.dropdown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dropdown
            // 
            this.dropdown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dropdown.BackgroundImage")));
            this.dropdown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dropdown.Controls.Add(this.panel2);
            this.dropdown.Controls.Add(this.button4);
            this.dropdown.Controls.Add(this.button3);
            this.dropdown.Location = new System.Drawing.Point(628, 60);
            this.dropdown.Name = "dropdown";
            this.dropdown.Size = new System.Drawing.Size(143, 80);
            this.dropdown.TabIndex = 14;
            this.dropdown.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(7, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(132, 1);
            this.panel2.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(7, 44);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 32);
            this.button4.TabIndex = 1;
            this.button4.Text = "Option";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(7, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 32);
            this.button3.TabIndex = 0;
            this.button3.Text = "Nouvelle abscence";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Settings_btn
            // 
            this.Settings_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Settings_btn.BackgroundImage")));
            this.Settings_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Settings_btn.FlatAppearance.BorderSize = 0;
            this.Settings_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings_btn.Location = new System.Drawing.Point(720, 21);
            this.Settings_btn.Name = "Settings_btn";
            this.Settings_btn.Size = new System.Drawing.Size(30, 30);
            this.Settings_btn.TabIndex = 13;
            this.Settings_btn.UseVisualStyleBackColor = true;
            // 
            // Settings_btn2
            // 
            this.Settings_btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Settings_btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings_btn2.FlatAppearance.BorderSize = 0;
            this.Settings_btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings_btn2.Image = ((System.Drawing.Image)(resources.GetObject("Settings_btn2.Image")));
            this.Settings_btn2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Settings_btn2.Location = new System.Drawing.Point(714, 19);
            this.Settings_btn2.Name = "Settings_btn2";
            this.Settings_btn2.Size = new System.Drawing.Size(67, 35);
            this.Settings_btn2.TabIndex = 12;
            this.Settings_btn2.UseVisualStyleBackColor = true;
            this.Settings_btn2.Click += new System.EventHandler(this.button1_Click);
            // 
            // students_liste
            // 
            this.students_liste.BackColor = System.Drawing.Color.Transparent;
            this.students_liste.BorderRadius = 3;
            this.students_liste.ForeColor = System.Drawing.Color.Black;
            this.students_liste.Items = new string[0];
            this.students_liste.Location = new System.Drawing.Point(3, 16);
            this.students_liste.Name = "students_liste";
            this.students_liste.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.students_liste.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.students_liste.selectedIndex = -1;
            this.students_liste.Size = new System.Drawing.Size(163, 35);
            this.students_liste.TabIndex = 11;
            this.students_liste.onItemSelected += new System.EventHandler(this.students_liste_onItemSelected);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 5;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(126)))), ((int)(((byte)(243)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(126)))), ((int)(((byte)(243)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Afficher";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 5;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(126)))), ((int)(((byte)(243)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.Location = new System.Drawing.Point(174, 12);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(105, 42);
            this.bunifuThinButton21.TabIndex = 10;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(126)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DoubleBuffered = true;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(126)))), ((int)(((byte)(243)))));
            this.dataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(3, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(5);
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(778, 385);
            this.dataGridView1.TabIndex = 9;
            // 
            // nouvelleAbs1
            // 
            this.nouvelleAbs1.BackColor = System.Drawing.Color.White;
            this.nouvelleAbs1.Location = new System.Drawing.Point(3, 71);
            this.nouvelleAbs1.Name = "nouvelleAbs1";
            this.nouvelleAbs1.Size = new System.Drawing.Size(778, 385);
            this.nouvelleAbs1.TabIndex = 15;
            this.nouvelleAbs1.Visible = false;
            // 
            // Ens_abscence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.dropdown);
            this.Controls.Add(this.Settings_btn);
            this.Controls.Add(this.Settings_btn2);
            this.Controls.Add(this.students_liste);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.nouvelleAbs1);
            this.Name = "Ens_abscence";
            this.Size = new System.Drawing.Size(784, 469);
            this.Load += new System.EventHandler(this.Ens_abscence_Load);
            this.Click += new System.EventHandler(this.Ens_abscence_Click);
            this.dropdown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dropdown;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Settings_btn;
        private System.Windows.Forms.Button Settings_btn2;
        private Bunifu.Framework.UI.BunifuDropdown students_liste;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridView1;
        private NouvelleAbs nouvelleAbs1;
    }
}
