namespace ZS_Zdravstvena_sluzba
{
    partial class DodavanjePacijentaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodavanjePacijentaForma));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.txtIDLek = new System.Windows.Forms.TextBox();
            this.btnDodajPacijenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "JMBG:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID izabranog lekara:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(157, 27);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(145, 20);
            this.txtIme.TabIndex = 4;
            this.txtIme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIme_KeyPress);
            this.txtIme.Leave += new System.EventHandler(this.txtIme_Leave);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(157, 65);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(145, 20);
            this.txtPrezime.TabIndex = 5;
            this.txtPrezime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrezime_KeyPress);
            this.txtPrezime.Leave += new System.EventHandler(this.txtPrezime_Leave);
            // 
            // txtJMBG
            // 
            this.txtJMBG.Location = new System.Drawing.Point(157, 101);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(145, 20);
            this.txtJMBG.TabIndex = 6;
            this.txtJMBG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJMBG_KeyPress);
            this.txtJMBG.Leave += new System.EventHandler(this.txtJMBG_Leave);
            // 
            // txtIDLek
            // 
            this.txtIDLek.Location = new System.Drawing.Point(157, 138);
            this.txtIDLek.Name = "txtIDLek";
            this.txtIDLek.Size = new System.Drawing.Size(145, 20);
            this.txtIDLek.TabIndex = 7;
            this.txtIDLek.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDLek_KeyPress);
            this.txtIDLek.Leave += new System.EventHandler(this.txtIDLek_Leave);
            // 
            // btnDodajPacijenta
            // 
            this.btnDodajPacijenta.Image = ((System.Drawing.Image)(resources.GetObject("btnDodajPacijenta.Image")));
            this.btnDodajPacijenta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDodajPacijenta.Location = new System.Drawing.Point(104, 194);
            this.btnDodajPacijenta.Name = "btnDodajPacijenta";
            this.btnDodajPacijenta.Size = new System.Drawing.Size(123, 32);
            this.btnDodajPacijenta.TabIndex = 8;
            this.btnDodajPacijenta.Text = "Dodaj pacijenta";
            this.btnDodajPacijenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajPacijenta.UseVisualStyleBackColor = true;
            this.btnDodajPacijenta.Click += new System.EventHandler(this.btnDodajPacijenta_Click);
            // 
            // DodavanjePacijentaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(333, 254);
            this.Controls.Add(this.btnDodajPacijenta);
            this.Controls.Add(this.txtIDLek);
            this.Controls.Add(this.txtJMBG);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DodavanjePacijentaForma";
            this.Text = "Dodavanje pacijenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.TextBox txtIDLek;
        private System.Windows.Forms.Button btnDodajPacijenta;
    }
}