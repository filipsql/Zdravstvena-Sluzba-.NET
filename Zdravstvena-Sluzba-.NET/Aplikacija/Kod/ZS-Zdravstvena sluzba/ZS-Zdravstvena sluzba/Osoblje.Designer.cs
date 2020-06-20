namespace ZS_Zdravstvena_sluzba
{
    partial class Osoblje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Osoblje));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnZakazi = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gbxZakazivanje = new System.Windows.Forms.GroupBox();
            this.btnSatiMinus = new System.Windows.Forms.Button();
            this.cbIzabrani = new System.Windows.Forms.CheckBox();
            this.btnMinutiPlus = new System.Windows.Forms.Button();
            this.btnMinutiMinus = new System.Windows.Forms.Button();
            this.btnSatiPlus = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblJMBG = new System.Windows.Forms.Label();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtPretragaLekara = new System.Windows.Forms.TextBox();
            this.btnPretraziLekare = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.gbxZakazivanje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZakazi
            // 
            this.btnZakazi.ForeColor = System.Drawing.Color.Black;
            this.btnZakazi.Image = ((System.Drawing.Image)(resources.GetObject("btnZakazi.Image")));
            this.btnZakazi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnZakazi.Location = new System.Drawing.Point(279, 382);
            this.btnZakazi.Name = "btnZakazi";
            this.btnZakazi.Size = new System.Drawing.Size(114, 33);
            this.btnZakazi.TabIndex = 4;
            this.btnZakazi.Text = "Zakaži pregled";
            this.btnZakazi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZakazi.UseVisualStyleBackColor = true;
            this.btnZakazi.Click += new System.EventHandler(this.btnZakazi_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AllowDrop = true;
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(69, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(220, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // gbxZakazivanje
            // 
            this.gbxZakazivanje.Controls.Add(this.btnSatiMinus);
            this.gbxZakazivanje.Controls.Add(this.cbIzabrani);
            this.gbxZakazivanje.Controls.Add(this.btnMinutiPlus);
            this.gbxZakazivanje.Controls.Add(this.btnMinutiMinus);
            this.gbxZakazivanje.Controls.Add(this.btnSatiPlus);
            this.gbxZakazivanje.Controls.Add(this.label4);
            this.gbxZakazivanje.Controls.Add(this.label3);
            this.gbxZakazivanje.Controls.Add(this.btnClear);
            this.gbxZakazivanje.Controls.Add(this.label2);
            this.gbxZakazivanje.Controls.Add(this.textBox2);
            this.gbxZakazivanje.Controls.Add(this.textBox1);
            this.gbxZakazivanje.Controls.Add(this.label1);
            this.gbxZakazivanje.Controls.Add(this.button1);
            this.gbxZakazivanje.Controls.Add(this.txtPrezime);
            this.gbxZakazivanje.Controls.Add(this.txtIme);
            this.gbxZakazivanje.Controls.Add(this.btnZakazi);
            this.gbxZakazivanje.Controls.Add(this.lblPrezime);
            this.gbxZakazivanje.Controls.Add(this.lblIme);
            this.gbxZakazivanje.Controls.Add(this.lblJMBG);
            this.gbxZakazivanje.Controls.Add(this.txtJMBG);
            this.gbxZakazivanje.Controls.Add(this.dateTimePicker1);
            this.gbxZakazivanje.Location = new System.Drawing.Point(12, 12);
            this.gbxZakazivanje.Name = "gbxZakazivanje";
            this.gbxZakazivanje.Size = new System.Drawing.Size(437, 432);
            this.gbxZakazivanje.TabIndex = 0;
            this.gbxZakazivanje.TabStop = false;
            this.gbxZakazivanje.Text = "Zakazivanje";
            // 
            // btnSatiMinus
            // 
            this.btnSatiMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSatiMinus.ForeColor = System.Drawing.Color.Black;
            this.btnSatiMinus.Location = new System.Drawing.Point(219, 70);
            this.btnSatiMinus.Name = "btnSatiMinus";
            this.btnSatiMinus.Size = new System.Drawing.Size(24, 24);
            this.btnSatiMinus.TabIndex = 23;
            this.btnSatiMinus.Text = "-";
            this.btnSatiMinus.UseVisualStyleBackColor = true;
            this.btnSatiMinus.Click += new System.EventHandler(this.btnSatiMinus_Click_1);
            // 
            // cbIzabrani
            // 
            this.cbIzabrani.AutoSize = true;
            this.cbIzabrani.ForeColor = System.Drawing.Color.Black;
            this.cbIzabrani.Location = new System.Drawing.Point(169, 349);
            this.cbIzabrani.Name = "cbIzabrani";
            this.cbIzabrani.Size = new System.Drawing.Size(164, 17);
            this.cbIzabrani.TabIndex = 22;
            this.cbIzabrani.Text = "Pregled kod izabranog lekara";
            this.cbIzabrani.UseVisualStyleBackColor = true;
            this.cbIzabrani.CheckedChanged += new System.EventHandler(this.cbIzabrani_CheckedChanged);
            // 
            // btnMinutiPlus
            // 
            this.btnMinutiPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinutiPlus.ForeColor = System.Drawing.Color.Black;
            this.btnMinutiPlus.Location = new System.Drawing.Point(265, 105);
            this.btnMinutiPlus.Name = "btnMinutiPlus";
            this.btnMinutiPlus.Size = new System.Drawing.Size(24, 24);
            this.btnMinutiPlus.TabIndex = 21;
            this.btnMinutiPlus.Text = "+";
            this.btnMinutiPlus.UseVisualStyleBackColor = true;
            this.btnMinutiPlus.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnMinutiMinus
            // 
            this.btnMinutiMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinutiMinus.ForeColor = System.Drawing.Color.Black;
            this.btnMinutiMinus.Location = new System.Drawing.Point(219, 105);
            this.btnMinutiMinus.Name = "btnMinutiMinus";
            this.btnMinutiMinus.Size = new System.Drawing.Size(24, 24);
            this.btnMinutiMinus.TabIndex = 20;
            this.btnMinutiMinus.Text = "-";
            this.btnMinutiMinus.UseVisualStyleBackColor = true;
            this.btnMinutiMinus.Click += new System.EventHandler(this.btnMinutiMinus_Click);
            // 
            // btnSatiPlus
            // 
            this.btnSatiPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSatiPlus.ForeColor = System.Drawing.Color.Black;
            this.btnSatiPlus.Location = new System.Drawing.Point(265, 70);
            this.btnSatiPlus.Name = "btnSatiPlus";
            this.btnSatiPlus.Size = new System.Drawing.Size(24, 24);
            this.btnSatiPlus.TabIndex = 19;
            this.btnSatiPlus.Text = "+";
            this.btnSatiPlus.UseVisualStyleBackColor = true;
            this.btnSatiPlus.Click += new System.EventHandler(this.btnSatiPlus_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(66, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Vreme pregleda minuti:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(66, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Vreme pregleda sati:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.Location = new System.Drawing.Point(69, 382);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 33);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Reset";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(29, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Id Izabranog Lekara:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(169, 310);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(146, 20);
            this.textBox2.TabIndex = 12;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(169, 203);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(66, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID Pacijenta:";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(359, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 34);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPrezime
            // 
            this.txtPrezime.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrezime.Location = new System.Drawing.Point(169, 275);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.ReadOnly = true;
            this.txtPrezime.Size = new System.Drawing.Size(146, 20);
            this.txtPrezime.TabIndex = 8;
            // 
            // txtIme
            // 
            this.txtIme.BackColor = System.Drawing.SystemColors.Window;
            this.txtIme.Location = new System.Drawing.Point(169, 239);
            this.txtIme.Name = "txtIme";
            this.txtIme.ReadOnly = true;
            this.txtIme.Size = new System.Drawing.Size(146, 20);
            this.txtIme.TabIndex = 7;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.ForeColor = System.Drawing.Color.Black;
            this.lblPrezime.Location = new System.Drawing.Point(87, 278);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(47, 13);
            this.lblPrezime.TabIndex = 6;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.ForeColor = System.Drawing.Color.Black;
            this.lblIme.Location = new System.Drawing.Point(107, 242);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(27, 13);
            this.lblIme.TabIndex = 5;
            this.lblIme.Text = "Ime:";
            // 
            // lblJMBG
            // 
            this.lblJMBG.AutoSize = true;
            this.lblJMBG.ForeColor = System.Drawing.Color.Black;
            this.lblJMBG.Location = new System.Drawing.Point(66, 153);
            this.lblJMBG.Name = "lblJMBG";
            this.lblJMBG.Size = new System.Drawing.Size(78, 13);
            this.lblJMBG.TabIndex = 6;
            this.lblJMBG.Text = "Unesite JMBG:";
            // 
            // txtJMBG
            // 
            this.txtJMBG.Location = new System.Drawing.Point(169, 150);
            this.txtJMBG.MaxLength = 13;
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(146, 20);
            this.txtJMBG.TabIndex = 1;
            this.txtJMBG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJMBG_KeyPress);
            this.txtJMBG.Leave += new System.EventHandler(this.txtJMBG_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.OldLace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(471, 82);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(389, 362);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtPretragaLekara
            // 
            this.txtPretragaLekara.Location = new System.Drawing.Point(471, 38);
            this.txtPretragaLekara.Name = "txtPretragaLekara";
            this.txtPretragaLekara.Size = new System.Drawing.Size(163, 20);
            this.txtPretragaLekara.TabIndex = 2;
            // 
            // btnPretraziLekare
            // 
            this.btnPretraziLekare.Image = ((System.Drawing.Image)(resources.GetObject("btnPretraziLekare.Image")));
            this.btnPretraziLekare.Location = new System.Drawing.Point(668, 30);
            this.btnPretraziLekare.Name = "btnPretraziLekare";
            this.btnPretraziLekare.Size = new System.Drawing.Size(34, 34);
            this.btnPretraziLekare.TabIndex = 24;
            this.btnPretraziLekare.UseVisualStyleBackColor = true;
            this.btnPretraziLekare.Click += new System.EventHandler(this.btnPretraziLekare_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(468, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Pretrazi lekare:";
            // 
            // Osoblje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 456);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPretraziLekare);
            this.Controls.Add(this.txtPretragaLekara);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbxZakazivanje);
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Osoblje";
            this.Text = "Osoblje";
            this.Load += new System.EventHandler(this.Osoblje_Load);
            this.gbxZakazivanje.ResumeLayout(false);
            this.gbxZakazivanje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZakazi;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox gbxZakazivanje;
        private System.Windows.Forms.Label lblJMBG;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMinutiPlus;
        private System.Windows.Forms.Button btnMinutiMinus;
        private System.Windows.Forms.Button btnSatiPlus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbIzabrani;
        private System.Windows.Forms.Button btnSatiMinus;
        private System.Windows.Forms.TextBox txtPretragaLekara;
        private System.Windows.Forms.Button btnPretraziLekare;
        private System.Windows.Forms.Label label5;
    }
}