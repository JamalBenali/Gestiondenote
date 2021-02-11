namespace PFE.Enseignant_UI
{
    partial class Composer_messagerie
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Composer_messagerie));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.email_sujet = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.email_body = new System.Windows.Forms.RichTextBox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuDropdown2 = new Bunifu.Framework.UI.BunifuDropdown();
            this.text_bold = new System.Windows.Forms.Button();
            this.text_italic = new System.Windows.Forms.Button();
            this.text_underlined = new System.Windows.Forms.Button();
            this.text_size = new Bunifu.Framework.UI.BunifuDropdown();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.esta_destination = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(35, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(35, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sujet";
            // 
            // email_sujet
            // 
            this.email_sujet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email_sujet.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.email_sujet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.email_sujet.HintForeColor = System.Drawing.Color.Empty;
            this.email_sujet.HintText = "";
            this.email_sujet.isPassword = false;
            this.email_sujet.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(126)))), ((int)(((byte)(243)))));
            this.email_sujet.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(126)))), ((int)(((byte)(243)))));
            this.email_sujet.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(126)))), ((int)(((byte)(243)))));
            this.email_sujet.LineThickness = 1;
            this.email_sujet.Location = new System.Drawing.Point(95, 45);
            this.email_sujet.Margin = new System.Windows.Forms.Padding(4);
            this.email_sujet.Name = "email_sujet";
            this.email_sujet.Size = new System.Drawing.Size(466, 32);
            this.email_sujet.TabIndex = 2;
            this.email_sujet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // email_body
            // 
            this.email_body.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_body.Location = new System.Drawing.Point(39, 101);
            this.email_body.Name = "email_body";
            this.email_body.Size = new System.Drawing.Size(522, 195);
            this.email_body.TabIndex = 4;
            this.email_body.Text = "";
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 5;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(126)))), ((int)(((byte)(243)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Envoyer";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Honeydew;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 5;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(126)))), ((int)(((byte)(243)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.Location = new System.Drawing.Point(38, 306);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(89, 45);
            this.bunifuThinButton21.TabIndex = 5;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BorderRadius = 10;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown1.Items = new string[0];
            this.bunifuDropdown1.Location = new System.Drawing.Point(134, 311);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.selectedIndex = -1;
            this.bunifuDropdown1.Size = new System.Drawing.Size(186, 35);
            this.bunifuDropdown1.TabIndex = 6;
            this.bunifuDropdown1.onItemSelected += new System.EventHandler(this.bunifuDropdown1_onItemSelected);
            // 
            // bunifuDropdown2
            // 
            this.bunifuDropdown2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown2.BorderRadius = 10;
            this.bunifuDropdown2.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown2.Items = new string[0];
            this.bunifuDropdown2.Location = new System.Drawing.Point(326, 311);
            this.bunifuDropdown2.Name = "bunifuDropdown2";
            this.bunifuDropdown2.NomalColor = System.Drawing.Color.Gray;
            this.bunifuDropdown2.onHoverColor = System.Drawing.Color.Gray;
            this.bunifuDropdown2.selectedIndex = -1;
            this.bunifuDropdown2.Size = new System.Drawing.Size(53, 35);
            this.bunifuDropdown2.TabIndex = 7;
            this.bunifuDropdown2.Click += new System.EventHandler(this.bunifuDropdown2_Click);
            // 
            // text_bold
            // 
            this.text_bold.BackColor = System.Drawing.Color.Gray;
            this.text_bold.FlatAppearance.BorderSize = 0;
            this.text_bold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text_bold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_bold.ForeColor = System.Drawing.Color.White;
            this.text_bold.Location = new System.Drawing.Point(385, 311);
            this.text_bold.Name = "text_bold";
            this.text_bold.Size = new System.Drawing.Size(35, 35);
            this.text_bold.TabIndex = 8;
            this.text_bold.Text = "B";
            this.text_bold.UseVisualStyleBackColor = false;
            this.text_bold.Click += new System.EventHandler(this.text_bold_Click);
            // 
            // text_italic
            // 
            this.text_italic.BackColor = System.Drawing.Color.Gray;
            this.text_italic.FlatAppearance.BorderSize = 0;
            this.text_italic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text_italic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_italic.ForeColor = System.Drawing.Color.White;
            this.text_italic.Location = new System.Drawing.Point(426, 311);
            this.text_italic.Name = "text_italic";
            this.text_italic.Size = new System.Drawing.Size(35, 35);
            this.text_italic.TabIndex = 9;
            this.text_italic.Text = "I";
            this.text_italic.UseVisualStyleBackColor = false;
            this.text_italic.Click += new System.EventHandler(this.text_italic_Click);
            // 
            // text_underlined
            // 
            this.text_underlined.BackColor = System.Drawing.Color.Gray;
            this.text_underlined.FlatAppearance.BorderSize = 0;
            this.text_underlined.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text_underlined.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_underlined.ForeColor = System.Drawing.Color.White;
            this.text_underlined.Location = new System.Drawing.Point(467, 311);
            this.text_underlined.Name = "text_underlined";
            this.text_underlined.Size = new System.Drawing.Size(35, 35);
            this.text_underlined.TabIndex = 10;
            this.text_underlined.Text = "U";
            this.text_underlined.UseVisualStyleBackColor = false;
            this.text_underlined.Click += new System.EventHandler(this.text_underlined_Click);
            // 
            // text_size
            // 
            this.text_size.BackColor = System.Drawing.Color.Transparent;
            this.text_size.BorderRadius = 10;
            this.text_size.ForeColor = System.Drawing.Color.White;
            this.text_size.Items = new string[] {
        "8",
        "10",
        "12",
        "14",
        "16",
        "18",
        "20",
        "22",
        "24",
        "26",
        "28",
        "30",
        "32",
        "34",
        "36",
        "38",
        "40"};
            this.text_size.Location = new System.Drawing.Point(508, 311);
            this.text_size.Name = "text_size";
            this.text_size.NomalColor = System.Drawing.Color.Gray;
            this.text_size.onHoverColor = System.Drawing.Color.Gray;
            this.text_size.selectedIndex = 1;
            this.text_size.Size = new System.Drawing.Size(53, 35);
            this.text_size.TabIndex = 11;
            this.text_size.onItemSelected += new System.EventHandler(this.text_size_onItemSelected);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gray;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(508, 311);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 34);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Gray;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(326, 311);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 34);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // esta_destination
            // 
            this.esta_destination.BackColor = System.Drawing.Color.Transparent;
            this.esta_destination.BorderRadius = 3;
            this.esta_destination.ForeColor = System.Drawing.Color.White;
            this.esta_destination.Items = new string[0];
            this.esta_destination.Location = new System.Drawing.Point(95, 13);
            this.esta_destination.Name = "esta_destination";
            this.esta_destination.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(126)))), ((int)(((byte)(243)))));
            this.esta_destination.onHoverColor = System.Drawing.Color.Blue;
            this.esta_destination.selectedIndex = -1;
            this.esta_destination.Size = new System.Drawing.Size(466, 29);
            this.esta_destination.TabIndex = 16;
            this.esta_destination.onItemSelected += new System.EventHandler(this.esta_destination_onItemSelected);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.email_body;
            // 
            // Composer_messagerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.esta_destination);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.text_size);
            this.Controls.Add(this.text_underlined);
            this.Controls.Add(this.text_italic);
            this.Controls.Add(this.text_bold);
            this.Controls.Add(this.bunifuDropdown2);
            this.Controls.Add(this.bunifuDropdown1);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.email_body);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.email_sujet);
            this.Controls.Add(this.label1);
            this.Name = "Composer_messagerie";
            this.Size = new System.Drawing.Size(587, 371);
            this.Load += new System.EventHandler(this.Composer_messagerie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox email_sujet;
        private System.Windows.Forms.RichTextBox email_body;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown2;
        private System.Windows.Forms.Button text_bold;
        private System.Windows.Forms.Button text_italic;
        private System.Windows.Forms.Button text_underlined;
        private Bunifu.Framework.UI.BunifuDropdown text_size;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuDropdown esta_destination;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
