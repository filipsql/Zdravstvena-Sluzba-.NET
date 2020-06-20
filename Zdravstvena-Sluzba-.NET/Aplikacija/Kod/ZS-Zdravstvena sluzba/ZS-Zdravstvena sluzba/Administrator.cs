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
using BazaN;

namespace ZS_Zdravstvena_sluzba
{
    public partial class Administrator : Form
    {
        public DodajZaposlenogForma dzf;
        public DodajZaposlenogForma azf;
        public DodavanjePacijentaForma dpf;
        public PretraziPacijenta ppf;
        public List<StatistikaLista> sl;
        public StatistikaForma sf;
        public Administrator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                
                var baza = new DataDataContext();
                BazaN.Zaposleni z = new BazaN.Zaposleni(); 
                z = (BazaN.Zaposleni)dataGridView1.CurrentRow.DataBoundItem;
                BazaN.Zaposleni zap = baza.Zaposlenis.Where(x => x.Id == z.Id).SingleOrDefault();
                if (zap != null)
                {
                    azf = new DodajZaposlenogForma(zap);
                    azf.Show();
                    baza.SubmitChanges();
                }
            }
            else
            {
                MessageBox.Show("Selektujte zaposlenog!", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            LoadGrid();

        }

        private void btnDodajZap_Click(object sender, EventArgs e)
        {
            dzf = new DodajZaposlenogForma();
            dzf.Show();
            LoadGrid();
        }

        private void btnObrisiZap_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                var baza = new DataDataContext();
                BazaN.Zaposleni z = new BazaN.Zaposleni();
                z = (BazaN.Zaposleni)dataGridView1.CurrentRow.DataBoundItem;
                DialogResult dlg = MessageBox.Show("Da li ste sigurni da zelite da obrisete zaposlenog?\nPromene su trajne!",
                    "Obavestenje!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dlg == DialogResult.Yes)
                {

                    BazaN.Zaposleni zap = baza.Zaposlenis.Where(x => x.Id == z.Id).SingleOrDefault();
                    baza.Zaposlenis.DeleteOnSubmit(zap);
                    baza.SubmitChanges();
                    LoadGrid();
                    MessageBox.Show("Zaposleni uspesno obrisan!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else return;
            }
            else
            {
                MessageBox.Show("Selektujte zaposlenog!", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStatistika_Click(object sender, EventArgs e)
        {
            sf = new StatistikaForma(sl);
            sf.Show();
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            LoadGrid();
            LoadGrid2();
            btnObrisiZap.Text = "Obrisi\nzaposlenog";
            if (DateTime.Today.Equals(DayOfWeek.Sunday))
            {
                var baza = new DataDataContext();
                List<BazaN.Zaposleni> lista = baza.Zaposlenis.ToList();
                foreach (BazaN.Zaposleni z in lista)
                {
                    if (z.Smena)
                        z.Smena = false;
                }
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void LoadGrid()
        {
            var baza = new DataDataContext();
            List<BazaN.Zaposleni> listaZap = new List<BazaN.Zaposleni>();
            List<BazaN.Zaposleni> sort = listaZap.OrderBy(x=>x.Id).ToList();
            listaZap = baza.Zaposlenis.Where(x => x.Id>0).ToList();

            dataGridView1.DataSource = listaZap.ToArray();
            foreach (DataGridViewColumn q in dataGridView1.Columns)
            {
                q.Visible = false;
                if (q.HeaderText == "Id")
                {
                    q.Visible = true;
                    
                }
                if (q.HeaderText == "Ime")
                    q.Visible = true;
                if (q.HeaderText == "Prezime")
                    q.Visible = true;
                if (q.HeaderText == "Radi")
                {
                    q.Visible = true;
                    
                }
                if (q.HeaderText == "Smena")
                    q.Visible = true;
                if (q.HeaderText == "Tip")
                {
                    
                    q.Visible = true;
                }
                
            }
            if (dataGridView1.SelectedRows.Count != 0)
            {
                dataGridView1.Rows[0].Cells[0].Selected = false;
            }

        }

        private void LoadGrid2()
        {
            var baza = new DataDataContext();
            List<BazaN.Terapija> lista = baza.Terapijas.Where(x=>(DateTime.Now - x.Datum).TotalDays<30).ToList();
            List<string> bolesti = new List<string>();
            foreach (BazaN.Terapija t in lista)
            {
                bolesti.Add(t.Dijagnoza.ToString());
            }
            var sort = from b in bolesti
                                group b by b into g
                                select new
                                {
                                    Bolest = g.Key,
                                    BrojPojavljivanja = g.Count()
                                };
            var sorted = sort.OrderByDescending(g => g.BrojPojavljivanja);
            sl = new List<StatistikaLista>();
            for (int i = 0; i < sorted.Count(); i++)
            {
                StatistikaLista sla = new StatistikaLista();
                sla.Bolest = sorted.ToList()[i].Bolest.ToString();
                sla.Broj = sorted.ToList()[i].BrojPojavljivanja;
                sl.Add(sla);
            }

                dataGridView2.DataSource = sorted.ToArray();
                if (dataGridView2.SelectedRows.Count != 0)
                {
                    dataGridView2.Rows[0].Cells[0].Selected = false;
                }
           
          
        }

        private void btnDodajPacijenta_Click(object sender, EventArgs e)
        {
            dpf = new DodavanjePacijentaForma();
            dpf.Show();
        }

        private void Administrator_Enter(object sender, EventArgs e)
        {
            
        }

        private void Administrator_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void Administrator_Activated(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnAzurirajPacijenta_Click(object sender, EventArgs e)
        {
            ppf = new PretraziPacijenta();
            ppf.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btnPretraziZap_Click(object sender, EventArgs e)
        {
            int p;
            var baza = new DataDataContext();
            if (txtPretraziZap.Text.Length==0)
            {
                LoadGrid();
            }
            
            else if(!Int32.TryParse(txtPretraziZap.Text, out p))
            {
                List<BazaN.Zaposleni> lista = baza.Zaposlenis.Where(x => x.Ime.Contains(txtPretraziZap.Text)).ToList();
                List<BazaN.Zaposleni> list = baza.Zaposlenis.Where(x => x.Prezime.Contains(txtPretraziZap.Text)).ToList();
                List<BazaN.Zaposleni> listica = baza.Zaposlenis.Where(x => x.JMBG == txtPretraziZap.Text).ToList();
                List<BazaN.Zaposleni> listaTipova = baza.Zaposlenis.Where(x => x.TipZaposlenog.TipZ.Contains(txtPretraziZap.Text)).ToList();
                foreach (BazaN.Zaposleni z in list)
                {
                    lista.Add(z);
                    
                }
                foreach (BazaN.Zaposleni z in listica)
                {
                    lista.Add(z);
                }
                foreach (BazaN.Zaposleni z in listaTipova)
                {
                    lista.Add(z);
                }
                LoadGridPar(lista);
            }

            else
            {
                List<BazaN.Zaposleni> lista = baza.Zaposlenis.Where(x => x.Id == int.Parse(txtPretraziZap.Text)).ToList();
                LoadGridPar(lista);
            }
          
            
            
        }

        private void LoadGridPar(List<BazaN.Zaposleni> l)
        {
            dataGridView1.DataSource = l.ToArray();
            foreach (DataGridViewColumn q in dataGridView1.Columns)
            {
                q.Visible = false;
                if (q.HeaderText == "Id")
                {
                    q.Visible = true;

                }
                if (q.HeaderText == "Ime")
                    q.Visible = true;
                if (q.HeaderText == "Prezime")
                    q.Visible = true;
                if (q.HeaderText == "Radi")
                {
                    q.Visible = true;

                }
                if (q.HeaderText == "Smena")
                    q.Visible = true;
                if (q.HeaderText == "Tip")
                {

                    q.Visible = true;
                }
                
            }
           
        }

        private void btnPretraziBolesti_Click(object sender, EventArgs e)
        {
            if (txtPretraziBolesti.TextLength == 0)
                LoadGrid2();
            else LoadGrid2Par(txtPretraziBolesti.Text);
        }

        private void LoadGrid2Par(String stri)
        {
            var baza = new DataDataContext();
            List<BazaN.Terapija> lista = baza.Terapijas.Where(x => (DateTime.Now - x.Datum).TotalDays < 30 && x.Dijagnoza.Contains(stri)).ToList();
            List<string> bolesti = new List<string>();
            foreach (BazaN.Terapija t in lista)
            {
                bolesti.Add(t.Dijagnoza.ToString());
            }
            var sort = from b in bolesti
                       group b by b into g
                       select new
                       {
                           Bolest = g.Key,
                           BrojPojavljivanja = g.Count()
                       };
            var sorted = sort.OrderByDescending(g => g.BrojPojavljivanja);

            dataGridView2.DataSource = sorted.ToArray();
        }

        private void txtPretraziBolesti_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }


        private void LoadPregleds()
        {
            var baza = new DataDataContext();
            List<BazaN.Zaposleni> lista = baza.Zaposlenis.Where(x=>x.Tip>2).ToList();
            List<PreglediPrikaz> pregledi = new List<PreglediPrikaz>();
            foreach (BazaN.Zaposleni z in lista)
            {
                PreglediPrikaz p = new PreglediPrikaz();
                p.Id = z.Id;
                p.Ime = z.Ime;
                p.Prezime = z.Prezime;
                int brojac=0;
                foreach (BazaN.Pregled preg in baza.Pregleds.Where(x=>(DateTime.Now - x.Datum).TotalDays < 30 && x.Id_Lekara == p.Id).ToList())
                {
                    brojac++;
                }
                p.BrPregleda = brojac;
                pregledi.Add(p);
            }
            dataGridView1.DataSource = pregledi.ToArray();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadPregleds();
        }

        private void LoadPlate()
        {
            var baza = new DataDataContext();
            List<BazaN.Zaposleni> lista = baza.Zaposlenis.Where(x => x.Tip > 2).ToList();
            List<Plata> plate = new List<Plata>();
            foreach (BazaN.Zaposleni z in lista)
            {
                Plata p = new Plata();
                p.Id = z.Id;
                p.Ime = z.Ime;
                p.Prezime = z.Prezime;
                int brojac = 0;
                foreach (BazaN.Pregled preg in baza.Pregleds.Where(x => (DateTime.Now - x.Datum).TotalDays < 30 && x.Id_Lekara == p.Id).ToList())
                {
                    brojac++;
                }
                p.Isplata = brojac * 204.78;
                plate.Add(p);
            }
            dataGridView1.DataSource = plate.ToArray();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadPlate();
        }

        private void dataGridView1_Resize(object sender, EventArgs e)
        {
            
        }

        private void Administrator_Resize(object sender, EventArgs e)
        {
           
        }
    }

   
}
