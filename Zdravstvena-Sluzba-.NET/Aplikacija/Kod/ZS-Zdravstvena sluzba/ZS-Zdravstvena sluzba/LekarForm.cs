using BazaN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZS_Zdravstvena_sluzba.Klase;

namespace ZS_Zdravstvena_sluzba
{
    public partial class LekarForm : Form
    {
        private int idZS;
        private int lekarId;
        private DateTime dt;
        private List<BazaN.Pacijent> ListaPacijenata;
        private List<BazaN.Uput> ListaUputa;
        private List<BazaN.Terapija> ListaTerapija;
        public LekarForm()
        {
            this.dt = new DateTime();
            this.dt = DateTime.Now;
            this.ListaPacijenata = new List<BazaN.Pacijent>();
            this.ListaUputa = new List<BazaN.Uput>();
            this.ListaTerapija = new List<BazaN.Terapija>();
            InitializeComponent();
        }

        public LekarForm(int id, int idZS)
            : this()
        {
            this.lekarId = id;
            this.idZS = idZS;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selektujte pacijenta", "Obavestenje",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            BazaN.Pacijent a = new BazaN.Pacijent();
            dataGridView1.Focus();
            a = (BazaN.Pacijent)dataGridView1.CurrentRow.DataBoundItem;
            Uput u = new Uput(this.lekarId, a.Id, this.idZS);
            u.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selektujte pacijenta", "Obavestenje",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            BazaN.Pacijent pacijent = new BazaN.Pacijent();
            dataGridView1.Focus();
            pacijent = (BazaN.Pacijent)dataGridView1.CurrentRow.DataBoundItem;
            Dijagnoza djg = new Dijagnoza(pacijent);
            djg.Show();
        }
        public void osveziTerapije()
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            BazaN.Pacijent pac = new BazaN.Pacijent();
            dataGridView1.Focus();
            pac = (BazaN.Pacijent)dataGridView1.CurrentRow.DataBoundItem;
            var baza = new DataDataContext();
            this.ListaTerapija = baza.Terapijas.Where(x => x.Id_Pacijenta == pac.Id).ToList();
            dataGridView2.DataSource = this.ListaTerapija;
            foreach (DataGridViewColumn s in dataGridView2.Columns)
            {
                s.Visible = false;
                if (s.HeaderText == "Opis")
                {
                    s.Visible = true;
                    s.DisplayIndex = 1;
                }
                if (s.HeaderText == "Dijagnoza")
                {
                    s.Visible = true;
                    s.DisplayIndex = 0;
                }
                if (s.HeaderText == "Datum")
                {
                    s.Visible = true;
                    s.DisplayIndex = 2;
                }
            }
            foreach (DataGridViewColumn col in dataGridView2.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            if (dataGridView2.SelectedRows.Count != 0)
            {
                dataGridView2.Rows[0].Cells[0].Selected = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.osveziTerapije();
        }

        private void LekarForm_Load(object sender, EventArgs e)
        {
            this.ucitajPacijente();
            dataGridView1.ReadOnly = true;
            dataGridView2.ReadOnly = true;
            var baza = new DataDataContext();
            BazaN.Zaposleni zpsl = new BazaN.Zaposleni();
            zpsl=baza.Zaposlenis.Where(x => x.Id == this.lekarId && x.Id_ZS == this.idZS).SingleOrDefault();
            this.Text = "Doktor: "+zpsl.Ime +" "+ zpsl.Prezime;
        }

        private void dataGridView2_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.osveziTerapije();   
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void ucitajPacijente()
        {
            dataGridView2.DataSource = null;
            dataGridView1.DataSource = null;
            this.ListaPacijenata.Clear();
            var baza = new DataDataContext();
            int pacdanas = 0;
            List<BazaN.Uput> lu = new List<BazaN.Uput>();
            lu = baza.Uputs.Where(x => (x.Id_Lekara == this.lekarId && x.Id_ZS == this.idZS)).ToList();
            List<BazaN.Pregled> pg = new List<BazaN.Pregled>();
            pg = baza.Pregleds.Where(x => (x.Id_Lekara == this.lekarId && x.Id_ZS == this.idZS)).ToList();
            foreach (BazaN.Pregled pgd in pg)
            {
                BazaN.Uput upt = new BazaN.Uput();
                upt.Id_Lekara = pgd.Id_Lekara;
                upt.Id_Pacijenta = pgd.Id_Pacijenta;
                upt.Opis = pgd.Opis;
                upt.Id_ZS = pgd.Id_ZS;
                upt.Datum = pgd.Datum;
                lu.Add(upt);
            }
            lu.Sort((a, b) => a.Datum.CompareTo(b.Datum));
            foreach (BazaN.Uput up in lu)
            {
                if (up.Datum.Date >= this.dt.Date)
                {
                    foreach(BazaN.Pacijent pc in baza.Pacijents.Where(x => x.Id == up.Id_Pacijenta))
                    {
                        this.ListaPacijenata.Add(pc);
                        if (up.Datum.Date == this.dt.Date)
                        {
                            pacdanas++;
                        }
                    }
                }
            }
            dataGridView1.DataSource = this.ListaPacijenata;
            for (int i=0;i<pacdanas;i++)
            {
                dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
            }
            foreach (DataGridViewColumn s in dataGridView1.Columns)
            {
                s.Visible = false;
                if (s.HeaderText == "Ime")
                {
                    s.Visible = true;
                }
                if (s.HeaderText == "Prezime")
                {
                    s.Visible = true;
                }
                if (s.HeaderText == "JMBG")
                {
                    s.Visible = true;
                }
                if (s.HeaderText == "Dijagnoza")
                {
                    s.Visible = true;
                }
                if (s.HeaderText == "Alergeni")
                {
                    s.Visible = true;
                }
            }
            if (dataGridView1.SelectedRows.Count != 0)
            {
                dataGridView1.Rows[0].Cells[0].Selected = false;
            }
        }
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows.Count != 0)
            {
                var baza = new DataDataContext();
                BazaN.Terapija trp = new BazaN.Terapija();
                dataGridView2.Focus();
                trp = (BazaN.Terapija)dataGridView2.CurrentRow.DataBoundItem;
                Opisterapije ot = new Opisterapije(trp);
                ot.Show();
            }
        }
        private void LekarForm_Activated(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = (System.Windows.Forms.DataGridViewSelectionMode)3;
            this.osveziTerapije();
            this.ucitajPacijente();
            dataGridView1.SelectionMode = (System.Windows.Forms.DataGridViewSelectionMode)1;
            label4.Text = this.dt.ToString("dd/MM/yyyy");
            label6.Text = DateTime.Now.ToString("dd/MM/yyy\n          HH:mm");
        }
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        public void menjajDatum(DateTime a)
        {
            this.dt = a;
            label4.Text = this.dt.ToString("dd/MM/yyy");
            this.ucitajPacijente();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.menjajDatum(dateTimePicker1.Value);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToString("dd/MM/yyy\n          HH:mm");
        }

        private void LekarForm_Resize(object sender, EventArgs e)
        {
        }

        private void LekarForm_SizeChanged(object sender, EventArgs e)
        {
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.ucitajPacijente();
        }

        private void LekarForm_MaximizedBoundsChanged(object sender, EventArgs e)
        {
            
        }
    }
}
