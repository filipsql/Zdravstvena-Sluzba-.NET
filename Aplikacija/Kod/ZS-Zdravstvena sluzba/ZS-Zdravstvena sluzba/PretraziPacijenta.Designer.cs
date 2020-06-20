namespace ZS_Zdravstvena_sluzba
{
    partial class PretraziPacijenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PretraziPacijenta));
            this.txtTrazi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtJBMG = new System.Windows.Forms.TextBox();
            this.txtIDLek = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTrazi
            // 
            this.txtTrazi.Location = new System.Drawing.Point(26, 26);
            this.txtTrazi.Name = "txtTrazi";
            this.txtTrazi.Size = new System.Drawing.Size(156, 20);
            this.txtTrazi.TabIndex = 0;
            this.txtTrazi.TextChanged += new System.EventHandler(this.txtTrazi_TextChanged);
            this.txtTrazi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrazi_KeyPress);
            this.txtTrazi.Leave += new System.EventHandler(this.txtTrazi_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesite JMBG pacijenta:";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.Silver;
            this.btnPretrazi.Image = ((System.Drawing.Image)(resources.GetObject("btnPretrazi.Image")));
            this.btnPretrazi.Location = new System.Drawing.Point(207, 17);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(36, 34);
            this.btnPretrazi.TabIndex = 1;
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(143, 74);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 2;
            this.txtIme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIme_KeyPress);
            this.txtIme.Leave += new System.EventHandler(this.txtIme_Leave);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(143, 110);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 3;
            this.txtPrezime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrezime_KeyPress);
            this.txtPrezime.Leave += new System.EventHandler(this.txtPrezime_Leave);
            // 
            // txtJBMG
            // 
            this.txtJBMG.Location = new System.Drawing.Point(143, 148);
            this.txtJBMG.Name = "txtJBMG";
            this.txtJBMG.Size = new System.Drawing.Size(100, 20);
            this.txtJBMG.TabIndex = 4;
            this.txtJBMG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJBMG_KeyPress);
            this.txtJBMG.Leave += new System.EventHandler(this.txtJBMG_Leave);
            // 
            // txtIDLek
            // 
            this.txtIDLek.Location = new System.Drawing.Point(143, 184);
            this.txtIDLek.Name = "txtIDLek";
            this.txtIDLek.Size = new System.Drawing.Size(100, 20);
            this.txtIDLek.TabIndex = 5;
            this.txtIDLek.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDLek_KeyPress);
            this.txtIDLek.Leave += new System.EventHandler(this.txtIDLek_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prezime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "JMBG:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID izabranog lekara:";
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Image = ((System.Drawing.Image)(resources.GetObject("btnAzuriraj.Image")));
            this.btnAzuriraj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAzuriraj.Location = new System.Drawing.Point(12, 236);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(114, 37);
            this.btnAzuriraj.TabIndex = 6;
            this.btnAzuriraj.Text = "Azuriraj podatke";
            this.btnAzuriraj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Image = ((System.Drawing.Image)(resources.GetObject("btnObrisi.Image")));
            this.btnObrisi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnObrisi.Location = new System.Drawing.Point(143, 236);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(113, 37);
            this.btnObrisi.TabIndex = 7;
            this.btnObrisi.Text = "Obrisi pacijenta";
            this.btnObrisi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // PretraziPacijenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(284, 296);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDLek);
            this.Controls.Add(this.txtJBMG);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTrazi);
            this.Name = "PretraziPacijenta";
            this.Text = "Pretrazi pacijente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTrazi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtJBMG;
        private System.Windows.Forms.TextBox txtIDLek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnObrisi;
    }
}