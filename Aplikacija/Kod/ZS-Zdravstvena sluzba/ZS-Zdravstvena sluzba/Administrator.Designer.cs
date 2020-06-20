namespace ZS_Zdravstvena_sluzba
{
    partial class Administrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrator));
            this.btnAzuriranjezap = new System.Windows.Forms.Button();
            this.btnDodajZap = new System.Windows.Forms.Button();
            this.btnObrisiZap = new System.Windows.Forms.Button();
            this.btnStatistika = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnDodajPacijenta = new System.Windows.Forms.Button();
            this.btnAzurirajPacijenta = new System.Windows.Forms.Button();
            this.txtPretraziZap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPretraziZap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPretraziBolesti = new System.Windows.Forms.TextBox();
            this.btnPretraziBolesti = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAzuriranjezap
            // 
            this.btnAzuriranjezap.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAzuriranjezap.Image = ((System.Drawing.Image)(resources.GetObject("btnAzuriranjezap.Image")));
            this.btnAzuriranjezap.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAzuriranjezap.Location = new System.Drawing.Point(125, 443);
            this.btnAzuriranjezap.Name = "btnAzuriranjezap";
            this.btnAzuriranjezap.Size = new System.Drawing.Size(107, 39);
            this.btnAzuriranjezap.TabIndex = 1;
            this.btnAzuriranjezap.Text = "Ažuriranje zaposlenih";
            this.btnAzuriranjezap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAzuriranjezap.UseVisualStyleBackColor = true;
            this.btnAzuriranjezap.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDodajZap
            // 
            this.btnDodajZap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDodajZap.Image = ((System.Drawing.Image)(resources.GetObject("btnDodajZap.Image")));
            this.btnDodajZap.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDodajZap.Location = new System.Drawing.Point(12, 443);
            this.btnDodajZap.Name = "btnDodajZap";
            this.btnDodajZap.Size = new System.Drawing.Size(107, 39);
            this.btnDodajZap.TabIndex = 0;
            this.btnDodajZap.Text = "Dodavanje zaposlenih";
            this.btnDodajZap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajZap.UseVisualStyleBackColor = true;
            this.btnDodajZap.Click += new System.EventHandler(this.btnDodajZap_Click);
            // 
            // btnObrisiZap
            // 
            this.btnObrisiZap.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnObrisiZap.Image = ((System.Drawing.Image)(resources.GetObject("btnObrisiZap.Image")));
            this.btnObrisiZap.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnObrisiZap.Location = new System.Drawing.Point(238, 443);
            this.btnObrisiZap.Name = "btnObrisiZap";
            this.btnObrisiZap.Size = new System.Drawing.Size(107, 39);
            this.btnObrisiZap.TabIndex = 2;
            this.btnObrisiZap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObrisiZap.UseVisualStyleBackColor = true;
            this.btnObrisiZap.Click += new System.EventHandler(this.btnObrisiZap_Click);
            // 
            // btnStatistika
            // 
            this.btnStatistika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStatistika.Image = ((System.Drawing.Image)(resources.GetObject("btnStatistika.Image")));
            this.btnStatistika.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStatistika.Location = new System.Drawing.Point(632, 443);
            this.btnStatistika.Name = "btnStatistika";
            this.btnStatistika.Size = new System.Drawing.Size(121, 39);
            this.btnStatistika.TabIndex = 5;
            this.btnStatistika.Text = "Prikaži statistiku";
            this.btnStatistika.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistika.UseVisualStyleBackColor = true;
            this.btnStatistika.Click += new System.EventHandler(this.btnStatistika_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 82);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(559, 342);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.Resize += new System.EventHandler(this.dataGridView1_Resize);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.OldLace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(583, 82);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(224, 342);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btnDodajPacijenta
            // 
            this.btnDodajPacijenta.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDodajPacijenta.Image = ((System.Drawing.Image)(resources.GetObject("btnDodajPacijenta.Image")));
            this.btnDodajPacijenta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDodajPacijenta.Location = new System.Drawing.Point(351, 443);
            this.btnDodajPacijenta.Name = "btnDodajPacijenta";
            this.btnDodajPacijenta.Size = new System.Drawing.Size(107, 39);
            this.btnDodajPacijenta.TabIndex = 3;
            this.btnDodajPacijenta.Text = "Dodavanje pacijenta";
            this.btnDodajPacijenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajPacijenta.UseVisualStyleBackColor = true;
            this.btnDodajPacijenta.Click += new System.EventHandler(this.btnDodajPacijenta_Click);
            // 
            // btnAzurirajPacijenta
            // 
            this.btnAzurirajPacijenta.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAzurirajPacijenta.Location = new System.Drawing.Point(464, 443);
            this.btnAzurirajPacijenta.Name = "btnAzurirajPacijenta";
            this.btnAzurirajPacijenta.Size = new System.Drawing.Size(107, 39);
            this.btnAzurirajPacijenta.TabIndex = 4;
            this.btnAzurirajPacijenta.Text = "Azuriranje i brisanje pacijenta";
            this.btnAzurirajPacijenta.UseVisualStyleBackColor = true;
            this.btnAzurirajPacijenta.Click += new System.EventHandler(this.btnAzurirajPacijenta_Click);
            // 
            // txtPretraziZap
            // 
            this.txtPretraziZap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPretraziZap.Location = new System.Drawing.Point(12, 39);
            this.txtPretraziZap.Name = "txtPretraziZap";
            this.txtPretraziZap.Size = new System.Drawing.Size(179, 20);
            this.txtPretraziZap.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pretrazi zaposlene:";
            // 
            // btnPretraziZap
            // 
            this.btnPretraziZap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPretraziZap.Image = ((System.Drawing.Image)(resources.GetObject("btnPretraziZap.Image")));
            this.btnPretraziZap.Location = new System.Drawing.Point(163, 6);
            this.btnPretraziZap.Name = "btnPretraziZap";
            this.btnPretraziZap.Size = new System.Drawing.Size(28, 29);
            this.btnPretraziZap.TabIndex = 10;
            this.btnPretraziZap.UseVisualStyleBackColor = true;
            this.btnPretraziZap.Click += new System.EventHandler(this.btnPretraziZap_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pretrazi bolesti:";
            // 
            // txtPretraziBolesti
            // 
            this.txtPretraziBolesti.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtPretraziBolesti.Location = new System.Drawing.Point(583, 39);
            this.txtPretraziBolesti.Name = "txtPretraziBolesti";
            this.txtPretraziBolesti.Size = new System.Drawing.Size(179, 20);
            this.txtPretraziBolesti.TabIndex = 12;
            this.txtPretraziBolesti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPretraziBolesti_KeyPress);
            // 
            // btnPretraziBolesti
            // 
            this.btnPretraziBolesti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPretraziBolesti.Image = ((System.Drawing.Image)(resources.GetObject("btnPretraziBolesti.Image")));
            this.btnPretraziBolesti.Location = new System.Drawing.Point(734, 4);
            this.btnPretraziBolesti.Name = "btnPretraziBolesti";
            this.btnPretraziBolesti.Size = new System.Drawing.Size(28, 29);
            this.btnPretraziBolesti.TabIndex = 13;
            this.btnPretraziBolesti.UseVisualStyleBackColor = true;
            this.btnPretraziBolesti.Click += new System.EventHandler(this.btnPretraziBolesti_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(348, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 45);
            this.button1.TabIndex = 14;
            this.button1.Text = "Pretrazi preglede";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(475, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 45);
            this.button2.TabIndex = 15;
            this.button2.Text = "Prikazi plate";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(819, 494);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPretraziBolesti);
            this.Controls.Add(this.txtPretraziBolesti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPretraziZap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPretraziZap);
            this.Controls.Add(this.btnAzurirajPacijenta);
            this.Controls.Add(this.btnDodajPacijenta);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnStatistika);
            this.Controls.Add(this.btnObrisiZap);
            this.Controls.Add(this.btnDodajZap);
            this.Controls.Add(this.btnAzuriranjezap);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(835, 533);
            this.MinimumSize = new System.Drawing.Size(835, 533);
            this.Name = "Administrator";
            this.Text = "Administrator";
            this.Activated += new System.EventHandler(this.Administrator_Activated);
            this.Load += new System.EventHandler(this.Administrator_Load);
            this.VisibleChanged += new System.EventHandler(this.Administrator_VisibleChanged);
            this.Enter += new System.EventHandler(this.Administrator_Enter);
            this.Resize += new System.EventHandler(this.Administrator_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAzuriranjezap;
        private System.Windows.Forms.Button btnDodajZap;
        private System.Windows.Forms.Button btnObrisiZap;
        private System.Windows.Forms.Button btnStatistika;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnDodajPacijenta;
        private System.Windows.Forms.Button btnAzurirajPacijenta;
        private System.Windows.Forms.TextBox txtPretraziZap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPretraziZap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPretraziBolesti;
        private System.Windows.Forms.Button btnPretraziBolesti;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}