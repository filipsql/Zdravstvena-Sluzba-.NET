namespace ZS_Zdravstvena_sluzba
{
    partial class DodajZaposlenogForma
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtIDzu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxTip = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbOdmor = new System.Windows.Forms.CheckBox();
            this.rbPrva = new System.Windows.Forms.RadioButton();
            this.rbDruga = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "JMBG:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Zeljeno korisnicko ime:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID zdravstvene ustanove:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Prezime:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sifra:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(204, 25);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(133, 20);
            this.txtIme.TabIndex = 8;
            this.txtIme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIme_KeyPress);
            this.txtIme.Leave += new System.EventHandler(this.txtIme_Leave);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(204, 66);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(133, 20);
            this.txtPrezime.TabIndex = 9;
            this.txtPrezime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrezime_KeyPress);
            this.txtPrezime.Leave += new System.EventHandler(this.txtPrezime_Leave);
            // 
            // txtJMBG
            // 
            this.txtJMBG.Location = new System.Drawing.Point(204, 108);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(133, 20);
            this.txtJMBG.TabIndex = 10;
            this.txtJMBG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJMBG_KeyPress);
            this.txtJMBG.Leave += new System.EventHandler(this.txtJMBG_Leave);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(204, 149);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(133, 20);
            this.txtUsername.TabIndex = 11;
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(204, 189);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(133, 20);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtIDzu
            // 
            this.txtIDzu.Location = new System.Drawing.Point(204, 229);
            this.txtIDzu.Name = "txtIDzu";
            this.txtIDzu.Size = new System.Drawing.Size(133, 20);
            this.txtIDzu.TabIndex = 13;
            this.txtIDzu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDzu_KeyPress);
            this.txtIDzu.Leave += new System.EventHandler(this.txtIDzu_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(90, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tip zaposlenog:";
            // 
            // cbxTip
            // 
            this.cbxTip.FormattingEnabled = true;
            this.cbxTip.Items.AddRange(new object[] {
            "pomocno",
            "lekar_opste_prakse",
            "hirurg",
            "ortoped",
            "urolog",
            "dermatolog",
            "stomatolog",
            "ginekolog",
            "otorinolaringolog",
            "oftamolog",
            "internista",
            "pedijatar",
            "psihijatar",
            "onkolog",
            "neurolog",
            "pulmolog"});
            this.cbxTip.Location = new System.Drawing.Point(204, 270);
            this.cbxTip.Name = "cbxTip";
            this.cbxTip.Size = new System.Drawing.Size(133, 21);
            this.cbxTip.TabIndex = 15;
            this.cbxTip.Leave += new System.EventHandler(this.cbxTip_Leave);
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(128, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 45);
            this.button1.TabIndex = 16;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbOdmor
            // 
            this.cbOdmor.AutoSize = true;
            this.cbOdmor.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbOdmor.Location = new System.Drawing.Point(61, 314);
            this.cbOdmor.Name = "cbOdmor";
            this.cbOdmor.Size = new System.Drawing.Size(111, 17);
            this.cbOdmor.TabIndex = 19;
            this.cbOdmor.Text = "Da li je na odmoru";
            this.cbOdmor.UseVisualStyleBackColor = true;
            // 
            // rbPrva
            // 
            this.rbPrva.AutoSize = true;
            this.rbPrva.Location = new System.Drawing.Point(204, 313);
            this.rbPrva.Name = "rbPrva";
            this.rbPrva.Size = new System.Drawing.Size(62, 17);
            this.rbPrva.TabIndex = 20;
            this.rbPrva.TabStop = true;
            this.rbPrva.Text = "I smena";
            this.rbPrva.UseVisualStyleBackColor = true;
            this.rbPrva.Click += new System.EventHandler(this.rbPrva_Click);
            // 
            // rbDruga
            // 
            this.rbDruga.AutoSize = true;
            this.rbDruga.Location = new System.Drawing.Point(272, 313);
            this.rbDruga.Name = "rbDruga";
            this.rbDruga.Size = new System.Drawing.Size(65, 17);
            this.rbDruga.TabIndex = 21;
            this.rbDruga.TabStop = true;
            this.rbDruga.Text = "II smena";
            this.rbDruga.UseVisualStyleBackColor = true;
            this.rbDruga.Click += new System.EventHandler(this.rbDruga_Click);
            // 
            // DodajZaposlenogForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(408, 425);
            this.Controls.Add(this.rbDruga);
            this.Controls.Add(this.rbPrva);
            this.Controls.Add(this.cbOdmor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxTip);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIDzu);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtJMBG);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "DodajZaposlenogForma";
            this.Load += new System.EventHandler(this.DodajZaposlenogForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtIDzu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxTip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbOdmor;
        private System.Windows.Forms.RadioButton rbPrva;
        private System.Windows.Forms.RadioButton rbDruga;
    }
}