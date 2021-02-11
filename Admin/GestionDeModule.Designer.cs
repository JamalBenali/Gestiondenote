namespace PFE.Admin
{
    partial class GestionDeModule
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Module = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Majoutf = new Bunifu.Framework.UI.BunifuDropdown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.MsuppM = new Bunifu.Framework.UI.BunifuDropdown();
            this.MSuppF = new Bunifu.Framework.UI.BunifuDropdown();
            this.label8 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.MmodifierM = new Bunifu.Framework.UI.BunifuDropdown();
            this.MmodifierF = new Bunifu.Framework.UI.BunifuDropdown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Semestre = new Bunifu.Framework.UI.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.Module.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Module
            // 
            this.Module.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Module.Controls.Add(this.panel5);
            this.Module.Controls.Add(this.groupBox4);
            this.Module.Controls.Add(this.groupBox5);
            this.Module.Controls.Add(this.groupBox6);
            this.Module.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Module.Location = new System.Drawing.Point(0, 0);
            this.Module.Name = "Module";
            this.Module.Size = new System.Drawing.Size(757, 388);
            this.Module.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(222)))), ((int)(((byte)(49)))));
            this.panel5.Location = new System.Drawing.Point(1, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(756, 10);
            this.panel5.TabIndex = 24;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.Semestre);
            this.groupBox4.Controls.Add(this.Majoutf);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Location = new System.Drawing.Point(15, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(352, 205);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ajouter Module";
            // 
            // Majoutf
            // 
            this.Majoutf.BackColor = System.Drawing.Color.Transparent;
            this.Majoutf.BorderRadius = 3;
            this.Majoutf.ForeColor = System.Drawing.Color.White;
            this.Majoutf.Items = new string[] {
        " "};
            this.Majoutf.Location = new System.Drawing.Point(113, 24);
            this.Majoutf.Name = "Majoutf";
            this.Majoutf.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(126)))), ((int)(((byte)(243)))));
            this.Majoutf.onHoverColor = System.Drawing.Color.Blue;
            this.Majoutf.selectedIndex = 0;
            this.Majoutf.Size = new System.Drawing.Size(228, 33);
            this.Majoutf.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Filière :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Désignation :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Id module :";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(170)))), ((int)(((byte)(236)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button8.Location = new System.Drawing.Point(113, 163);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(229, 31);
            this.button8.TabIndex = 18;
            this.button8.Text = "Ajouter";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(113, 129);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(229, 23);
            this.textBox3.TabIndex = 20;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(113, 63);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(228, 23);
            this.textBox4.TabIndex = 19;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.MsuppM);
            this.groupBox5.Controls.Add(this.MSuppF);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.button9);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(15, 232);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(352, 138);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Supprimer Module";
            // 
            // MsuppM
            // 
            this.MsuppM.BackColor = System.Drawing.Color.Transparent;
            this.MsuppM.BorderRadius = 3;
            this.MsuppM.ForeColor = System.Drawing.Color.White;
            this.MsuppM.Items = new string[] {
        " "};
            this.MsuppM.Location = new System.Drawing.Point(97, 59);
            this.MsuppM.Name = "MsuppM";
            this.MsuppM.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(126)))), ((int)(((byte)(243)))));
            this.MsuppM.onHoverColor = System.Drawing.Color.Blue;
            this.MsuppM.selectedIndex = 0;
            this.MsuppM.Size = new System.Drawing.Size(230, 30);
            this.MsuppM.TabIndex = 27;
            // 
            // MSuppF
            // 
            this.MSuppF.BackColor = System.Drawing.Color.Transparent;
            this.MSuppF.BorderRadius = 3;
            this.MSuppF.ForeColor = System.Drawing.Color.White;
            this.MSuppF.Items = new string[] {
        " "};
            this.MSuppF.Location = new System.Drawing.Point(97, 22);
            this.MSuppF.Name = "MSuppF";
            this.MSuppF.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(126)))), ((int)(((byte)(243)))));
            this.MSuppF.onHoverColor = System.Drawing.Color.Blue;
            this.MSuppF.selectedIndex = 0;
            this.MSuppF.Size = new System.Drawing.Size(230, 31);
            this.MSuppF.TabIndex = 28;
            this.MSuppF.onItemSelected += new System.EventHandler(this.MSuppF_onItemSelected);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Module :";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.OrangeRed;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button9.Location = new System.Drawing.Point(97, 95);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(228, 30);
            this.button9.TabIndex = 4;
            this.button9.Text = "Supprimer";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Filière :";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.MmodifierM);
            this.groupBox6.Controls.Add(this.MmodifierF);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.button10);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.button11);
            this.groupBox6.Controls.Add(this.textBox5);
            this.groupBox6.Controls.Add(this.textBox6);
            this.groupBox6.Location = new System.Drawing.Point(390, 21);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(352, 349);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Modifier Module";
            // 
            // MmodifierM
            // 
            this.MmodifierM.BackColor = System.Drawing.Color.Transparent;
            this.MmodifierM.BorderRadius = 3;
            this.MmodifierM.ForeColor = System.Drawing.Color.White;
            this.MmodifierM.Items = new string[] {
        " "};
            this.MmodifierM.Location = new System.Drawing.Point(109, 100);
            this.MmodifierM.Name = "MmodifierM";
            this.MmodifierM.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(126)))), ((int)(((byte)(243)))));
            this.MmodifierM.onHoverColor = System.Drawing.Color.Blue;
            this.MmodifierM.selectedIndex = 0;
            this.MmodifierM.Size = new System.Drawing.Size(233, 33);
            this.MmodifierM.TabIndex = 24;
            // 
            // MmodifierF
            // 
            this.MmodifierF.BackColor = System.Drawing.Color.Transparent;
            this.MmodifierF.BorderRadius = 3;
            this.MmodifierF.ForeColor = System.Drawing.Color.White;
            this.MmodifierF.Items = new string[] {
        " "};
            this.MmodifierF.Location = new System.Drawing.Point(109, 61);
            this.MmodifierF.Name = "MmodifierF";
            this.MmodifierF.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(126)))), ((int)(((byte)(243)))));
            this.MmodifierF.onHoverColor = System.Drawing.Color.Blue;
            this.MmodifierF.selectedIndex = 0;
            this.MmodifierF.Size = new System.Drawing.Size(233, 33);
            this.MmodifierF.TabIndex = 25;
            this.MmodifierF.onItemSelected += new System.EventHandler(this.MmodifierF_onItemSelected);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 29;
            this.label11.Text = "Module :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Filière :";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(170)))), ((int)(((byte)(236)))));
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button10.Location = new System.Drawing.Point(109, 139);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(233, 30);
            this.button10.TabIndex = 18;
            this.button10.Text = "Rehercher";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 221);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 17);
            this.label13.TabIndex = 3;
            this.label13.Text = "désignation :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 192);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 17);
            this.label14.TabIndex = 1;
            this.label14.Text = "Id Module :";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(183)))), ((int)(((byte)(49)))));
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button11.Location = new System.Drawing.Point(109, 248);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(233, 32);
            this.button11.TabIndex = 1;
            this.button11.Text = "Modifier";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(109, 218);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(233, 23);
            this.textBox5.TabIndex = 2;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(109, 192);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(233, 23);
            this.textBox6.TabIndex = 1;
            // 
            // Semestre
            // 
            this.Semestre.BackColor = System.Drawing.Color.Transparent;
            this.Semestre.BorderRadius = 3;
            this.Semestre.ForeColor = System.Drawing.Color.White;
            this.Semestre.Items = new string[] {
        " S1",
        "S2",
        "S3",
        "S4"};
            this.Semestre.Location = new System.Drawing.Point(113, 89);
            this.Semestre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Semestre.Name = "Semestre";
            this.Semestre.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(126)))), ((int)(((byte)(243)))));
            this.Semestre.onHoverColor = System.Drawing.Color.Blue;
            this.Semestre.selectedIndex = -1;
            this.Semestre.Size = new System.Drawing.Size(229, 33);
            this.Semestre.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Semestre :";
            // 
            // GestionDeModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Module);
            this.Name = "GestionDeModule";
            this.Size = new System.Drawing.Size(756, 389);
            this.Module.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Module;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox4;
        public Bunifu.Framework.UI.BunifuDropdown Majoutf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private Bunifu.Framework.UI.BunifuDropdown MsuppM;
        public Bunifu.Framework.UI.BunifuDropdown MSuppF;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox6;
        private Bunifu.Framework.UI.BunifuDropdown MmodifierM;
        public Bunifu.Framework.UI.BunifuDropdown MmodifierF;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label1;
        public Bunifu.Framework.UI.BunifuDropdown Semestre;
    }
}
