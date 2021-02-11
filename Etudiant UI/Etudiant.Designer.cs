using PFE.Etudiant_UI;

namespace PFE
{
    partial class Etudiant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Etudiant));
            this.sidebar = new System.Windows.Forms.Panel();
            this.name = new System.Windows.Forms.Label();
            this.navbtn = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.profile_avatar = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Minus = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.accueil1 = new PFE.Accueil();
            this.etudiant_abscence1 = new PFE.Etudiant_UI.Etudiant_abscence();
            this.etudiant_Notes1 = new PFE.Etudiant_Notes();
            this.profile1 = new PFE.Profile();
            this.etudiant_parcours1 = new PFE.Etudiant_UI.Etudiant_parcours();
            this.button1 = new System.Windows.Forms.Button();
            this.sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_avatar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(126)))), ((int)(((byte)(243)))));
            this.sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sidebar.Controls.Add(this.button1);
            this.sidebar.Controls.Add(this.name);
            this.sidebar.Controls.Add(this.navbtn);
            this.sidebar.Controls.Add(this.button8);
            this.sidebar.Controls.Add(this.button7);
            this.sidebar.Controls.Add(this.profile_avatar);
            this.sidebar.Controls.Add(this.button5);
            this.sidebar.Controls.Add(this.button4);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.sidebar.Size = new System.Drawing.Size(56, 573);
            this.sidebar.TabIndex = 1;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(62, 147);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(72, 17);
            this.name.TabIndex = 7;
            this.name.Text = "Full Name";
            // 
            // navbtn
            // 
            this.navbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.navbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navbtn.FlatAppearance.BorderSize = 0;
            this.navbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navbtn.ForeColor = System.Drawing.Color.White;
            this.navbtn.Image = ((System.Drawing.Image)(resources.GetObject("navbtn.Image")));
            this.navbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navbtn.Location = new System.Drawing.Point(1, 19);
            this.navbtn.Name = "navbtn";
            this.navbtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.navbtn.Size = new System.Drawing.Size(60, 56);
            this.navbtn.TabIndex = 6;
            this.navbtn.UseVisualStyleBackColor = true;
            this.navbtn.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(0, 190);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(229, 56);
            this.button8.TabIndex = 5;
            this.button8.Text = "             Infos Personnelles";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(-4, 362);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(229, 56);
            this.button7.TabIndex = 4;
            this.button7.Text = "             Abscences";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // profile_avatar
            // 
            this.profile_avatar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profile_avatar.BackgroundImage")));
            this.profile_avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profile_avatar.Location = new System.Drawing.Point(86, 64);
            this.profile_avatar.Name = "profile_avatar";
            this.profile_avatar.Size = new System.Drawing.Size(66, 68);
            this.profile_avatar.TabIndex = 4;
            this.profile_avatar.TabStop = false;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(-2, 300);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(229, 56);
            this.button5.TabIndex = 2;
            this.button5.Text = "             Mes Notes";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-1, 245);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(229, 56);
            this.button4.TabIndex = 1;
            this.button4.Text = "             Parcours Scolaire";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.Minus);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(260, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 36);
            this.panel1.TabIndex = 8;
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
            this.Minus.Location = new System.Drawing.Point(698, 0);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(47, 25);
            this.Minus.TabIndex = 16;
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click_1);
            // 
            // delete
            // 
            this.delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete.BackgroundImage")));
            this.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Location = new System.Drawing.Point(751, 0);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(41, 25);
            this.delete.TabIndex = 15;
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click_1);
            // 
            // accueil1
            // 
            this.accueil1.BackColor = System.Drawing.Color.White;
            this.accueil1.Location = new System.Drawing.Point(161, 52);
            this.accueil1.Name = "accueil1";
            this.accueil1.Size = new System.Drawing.Size(800, 509);
            this.accueil1.TabIndex = 9;
            // 
            // etudiant_abscence1
            // 
            this.etudiant_abscence1.BackColor = System.Drawing.Color.White;
            this.etudiant_abscence1.Location = new System.Drawing.Point(161, 64);
            this.etudiant_abscence1.Name = "etudiant_abscence1";
            this.etudiant_abscence1.Size = new System.Drawing.Size(784, 469);
            this.etudiant_abscence1.TabIndex = 13;
            // 
            // etudiant_Notes1
            // 
            this.etudiant_Notes1.BackColor = System.Drawing.Color.White;
            this.etudiant_Notes1.Location = new System.Drawing.Point(158, 64);
            this.etudiant_Notes1.Name = "etudiant_Notes1";
            this.etudiant_Notes1.Size = new System.Drawing.Size(784, 469);
            this.etudiant_Notes1.TabIndex = 12;
            // 
            // profile1
            // 
            this.profile1.BackColor = System.Drawing.Color.White;
            this.profile1.Location = new System.Drawing.Point(197, 64);
            this.profile1.Name = "profile1";
            this.profile1.Size = new System.Drawing.Size(728, 469);
            this.profile1.TabIndex = 11;
            // 
            // etudiant_parcours1
            // 
            this.etudiant_parcours1.BackColor = System.Drawing.Color.White;
            this.etudiant_parcours1.Location = new System.Drawing.Point(158, 64);
            this.etudiant_parcours1.Name = "etudiant_parcours1";
            this.etudiant_parcours1.Size = new System.Drawing.Size(784, 469);
            this.etudiant_parcours1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1, 424);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(228, 56);
            this.button1.TabIndex = 26;
            this.button1.Text = "            Déconnexion";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Etudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1052, 573);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.accueil1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.etudiant_abscence1);
            this.Controls.Add(this.etudiant_Notes1);
            this.Controls.Add(this.profile1);
            this.Controls.Add(this.etudiant_parcours1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Etudiant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etudiant";
            this.Load += new System.EventHandler(this.Etudiant_Load);
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_avatar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.PictureBox profile_avatar;
        private System.Windows.Forms.Button navbtn;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        //private Etudiant_Notes etudiant_Notes2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button delete;
        private Accueil accueil1;
        private Etudiant_UI.Etudiant_parcours etudiant_parcours1;
        private Profile profile1;
        private Etudiant_Notes etudiant_Notes1;
        private Etudiant_abscence etudiant_abscence1;
        private System.Windows.Forms.Button button1;
    }
}