namespace PFE
{
    partial class AdminPanel
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.sidebar = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.navbtn = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.profile_avatar = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Minus = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.adminDashboard1 = new PFE.Admin.AdminDashboard();
            this.enseignant_messagerie1 = new PFE.Enseignant_messagerie();
            this.gestionDesEnseignants1 = new PFE.Admin.GestionDesEnseignants();
            this.gestionDesFilieres1 = new PFE.Admin.GestionDesFilieres();
            this.gestionDesNotes1 = new PFE.Admin.GestionDesNotes();
            this.adminProfile1 = new PFE.Admin.AdminProfile();
            this.gestionDesEtudiants1 = new PFE.Admin.GestionDesEtudiants();
            this.sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_avatar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(126)))), ((int)(((byte)(243)))));
            this.sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sidebar.Controls.Add(this.button9);
            this.sidebar.Controls.Add(this.button1);
            this.sidebar.Controls.Add(this.name);
            this.sidebar.Controls.Add(this.navbtn);
            this.sidebar.Controls.Add(this.button7);
            this.sidebar.Controls.Add(this.button8);
            this.sidebar.Controls.Add(this.profile_avatar);
            this.sidebar.Controls.Add(this.button6);
            this.sidebar.Controls.Add(this.button5);
            this.sidebar.Controls.Add(this.button4);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.sidebar.Size = new System.Drawing.Size(60, 573);
            this.sidebar.TabIndex = 2;
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Lato Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(-2, 433);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(229, 46);
            this.button9.TabIndex = 27;
            this.button9.Text = "             Messagerie";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1, 484);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(229, 46);
            this.button1.TabIndex = 26;
            this.button1.Text = "            Déconnexion";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(62, 131);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(116, 17);
            this.name.TabIndex = 7;
            this.name.Text = "Monsieur l\'Admin";
            // 
            // navbtn
            // 
            this.navbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.navbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navbtn.FlatAppearance.BorderSize = 0;
            this.navbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navbtn.Font = new System.Drawing.Font("Lato Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navbtn.ForeColor = System.Drawing.Color.White;
            this.navbtn.Image = ((System.Drawing.Image)(resources.GetObject("navbtn.Image")));
            this.navbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navbtn.Location = new System.Drawing.Point(1, 19);
            this.navbtn.Name = "navbtn";
            this.navbtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.navbtn.Size = new System.Drawing.Size(60, 56);
            this.navbtn.TabIndex = 6;
            this.navbtn.UseVisualStyleBackColor = true;
            this.navbtn.Click += new System.EventHandler(this.navbtn_Click);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Lato Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(1, 178);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(229, 46);
            this.button7.TabIndex = 4;
            this.button7.Text = "             Dashboard\r\n";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Lato Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(2, 229);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(229, 46);
            this.button8.TabIndex = 5;
            this.button8.Text = "             Etudiants\r\n";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // profile_avatar
            // 
            this.profile_avatar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profile_avatar.BackgroundImage")));
            this.profile_avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profile_avatar.Location = new System.Drawing.Point(86, 50);
            this.profile_avatar.Name = "profile_avatar";
            this.profile_avatar.Size = new System.Drawing.Size(66, 68);
            this.profile_avatar.TabIndex = 4;
            this.profile_avatar.TabStop = false;
            this.profile_avatar.Click += new System.EventHandler(this.profile_avatar_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Lato Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(-1, 331);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(229, 46);
            this.button6.TabIndex = 3;
            this.button6.Text = "             Filiéres\r\n";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Lato Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(-2, 382);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(229, 46);
            this.button5.TabIndex = 2;
            this.button5.Text = "             Notes";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Lato Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(1, 280);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(229, 46);
            this.button4.TabIndex = 1;
            this.button4.Text = "             Enseignants";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Minus);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(260, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 36);
            this.panel1.TabIndex = 9;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topbar_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topbar_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topbar_MouseUp);
            // 
            // Minus
            // 
            this.Minus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Minus.BackgroundImage")));
            this.Minus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Minus.FlatAppearance.BorderSize = 0;
            this.Minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minus.Location = new System.Drawing.Point(699, 0);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(47, 25);
            this.Minus.TabIndex = 16;
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(443, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 26);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete.BackgroundImage")));
            this.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Location = new System.Drawing.Point(752, 0);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(41, 25);
            this.delete.TabIndex = 15;
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(478, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 26);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // adminDashboard1
            // 
            this.adminDashboard1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.adminDashboard1.Location = new System.Drawing.Point(174, 73);
            this.adminDashboard1.Name = "adminDashboard1";
            this.adminDashboard1.Size = new System.Drawing.Size(786, 488);
            this.adminDashboard1.TabIndex = 10;
            this.adminDashboard1.Load += new System.EventHandler(this.adminDashboard1_Load);
            // 
            // enseignant_messagerie1
            // 
            this.enseignant_messagerie1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.enseignant_messagerie1.Location = new System.Drawing.Point(174, 73);
            this.enseignant_messagerie1.Name = "enseignant_messagerie1";
            this.enseignant_messagerie1.Size = new System.Drawing.Size(784, 469);
            this.enseignant_messagerie1.TabIndex = 15;
            // 
            // gestionDesEnseignants1
            // 
            this.gestionDesEnseignants1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gestionDesEnseignants1.Location = new System.Drawing.Point(174, 73);
            this.gestionDesEnseignants1.Name = "gestionDesEnseignants1";
            this.gestionDesEnseignants1.Size = new System.Drawing.Size(786, 488);
            this.gestionDesEnseignants1.TabIndex = 14;
            // 
            // gestionDesFilieres1
            // 
            this.gestionDesFilieres1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gestionDesFilieres1.Location = new System.Drawing.Point(174, 73);
            this.gestionDesFilieres1.Name = "gestionDesFilieres1";
            this.gestionDesFilieres1.Size = new System.Drawing.Size(786, 488);
            this.gestionDesFilieres1.TabIndex = 12;
            // 
            // gestionDesNotes1
            // 
            this.gestionDesNotes1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gestionDesNotes1.Location = new System.Drawing.Point(174, 73);
            this.gestionDesNotes1.Name = "gestionDesNotes1";
            this.gestionDesNotes1.Size = new System.Drawing.Size(786, 488);
            this.gestionDesNotes1.TabIndex = 11;
            // 
            // adminProfile1
            // 
            this.adminProfile1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.adminProfile1.Location = new System.Drawing.Point(174, 73);
            this.adminProfile1.Name = "adminProfile1";
            this.adminProfile1.Size = new System.Drawing.Size(810, 488);
            this.adminProfile1.TabIndex = 16;
            // 
            // gestionDesEtudiants1
            // 
            this.gestionDesEtudiants1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gestionDesEtudiants1.Location = new System.Drawing.Point(184, 73);
            this.gestionDesEtudiants1.Name = "gestionDesEtudiants1";
            this.gestionDesEtudiants1.Size = new System.Drawing.Size(786, 488);
            this.gestionDesEtudiants1.TabIndex = 17;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1052, 573);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.adminDashboard1);
            this.Controls.Add(this.enseignant_messagerie1);
            this.Controls.Add(this.gestionDesEnseignants1);
            this.Controls.Add(this.gestionDesFilieres1);
            this.Controls.Add(this.gestionDesNotes1);
            this.Controls.Add(this.adminProfile1);
            this.Controls.Add(this.gestionDesEtudiants1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_avatar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button navbtn;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox profile_avatar;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button9;
        private Admin.AdminDashboard adminDashboard1;
        private Admin.GestionDesNotes gestionDesNotes1;
        private Admin.GestionDesFilieres gestionDesFilieres1;
        private Admin.GestionDesEnseignants gestionDesEnseignants1;
        private Enseignant_messagerie enseignant_messagerie1;
        private Admin.AdminProfile adminProfile1;
        private Admin.GestionDesEtudiants gestionDesEtudiants1;
    }
}