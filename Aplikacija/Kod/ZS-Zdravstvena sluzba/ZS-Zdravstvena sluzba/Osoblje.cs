using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BazaN;

namespace ZS_Zdravstvena_sluzba
{
    public partial class Osoblje : Form
    {
        public Osoblje()
        {
            InitializeComponent();
        }

        public void loadGrid()
        {
            var baza = new DataDataContext();
            
                List<BazaN.Zaposleni> lista = new List<BazaN.Zaposleni>();

                lista = baza.Zaposlenis.Where(x => x.Tip > 2).ToList();

                dataGridView1.DataSource = lista.ToArray();

                foreach (DataGridViewColumn q in dataGridView1.Columns)
                {
                    q.Visible = false;

                    if (q.HeaderText == "Id")
                    {
                        q.Visible = true;
                        q.Width = 40;
                    }
                    if (q.HeaderText == "Ime")
                    {
                        q.Visible = true;
                        q.Width = 40;
                    }
                    if (q.HeaderText == "Prezime")
                    {
                        q.Visible = true;
                        q.Width = 70;
                    }
                    if (q.HeaderText == "Radi")
                    {
                        q.Visible = true;
                        q.Width = 40;
                    }
                    if (q.HeaderText == "Smena")
                    {
                        q.Visible = true;
                        q.Width = 50;
                    }
                }
                if (dataGridView1.SelectedRows.Count != 0)
                {
                    dataGridView1.Rows[0].Cells[0].Selected = false;
                }
            
           
           
        }

        private void LoadGridPar(List<BazaN.Zaposleni> lista)
        {
            dataGridView1.DataSource = lista.ToArray();

            foreach (DataGridViewColumn q in dataGridView1.Columns)
            {
                q.Visible = false;

                if (q.HeaderText == "Id")
                {
                    q.Visible = true;
                    q.Width = 40;
                }
                if (q.HeaderText == "Ime")
                {
                    q.Visible = true;
                    q.Width = 40;
                }
                if (q.HeaderText == "Prezime")
                {
                    q.Visible = true;
                    q.Width = 70;
                }
                if (q.HeaderText == "Radi")
                {
                    q.Visible = true;
                    q.Width = 40;
                }
                if (q.HeaderText == "Smena")
                {
                    q.Visible = true;
                    q.Width = 50;
                }
            }
            if (dataGridView1.SelectedRows.Count != 0)
            {
                dataGridView1.Rows[0].Cells[0].Selected = false;
            }
        }

        private void LoadIzabrani()
        {
                var baza = new DataDataContext();
            
                List<BazaN.Zaposleni> lista = new List<BazaN.Zaposleni>();
                lista = baza.Zaposlenis.Where(x => x.Id.ToString() == textBox2.Text).ToList();
                dataGridView1.DataSource = lista.ToArray();

                if (dataGridView1.SelectedRows.Count != 0)
                {
                    dataGridView1.Rows[0].Cells[0].Selected = false;
                }
            
        }

        private void Osoblje_Load(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            BazaN.Zaposleni lekar = new BazaN.Zaposleni();
            int selectedRow = dataGridView1.SelectedRows[0].Index;

            lekar = (BazaN.Zaposleni)dataGridView1.CurrentRow.DataBoundItem;



            PregledLekara pl = new PregledLekara(lekar.Id);
            pl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtJMBG.TextLength == 13)
            {
                var baza = new DataDataContext();
                string JMBG = txtJMBG.Text;
                BazaN.Pacijent pacijent;
   

                pacijent = baza.Pacijents.Where(x => x.JMBG.Equals(JMBG)).SingleOrDefault();

                if (pacijent == null)
                {
                    MessageBox.Show("Pacijent ne postoji");
                    clear();
                    return;
                }

                txtIme.Text = pacijent.Ime;
                txtPrezime.Text = pacijent.Prezime;
                textBox1.Text = pacijent.Id.ToString();
                textBox2.Text = pacijent.Id_Lekara.ToString();
                //loadGrid();

            }
            else
            {
                MessageBox.Show("Nevalidan JMBG");
                clear();

            }
        }

        private void btnZakazi_Click(object sender, EventArgs e)
        {
            if (txtJMBG.Text == ""||txtJMBG.TextLength!=13)
            {
                MessageBox.Show("Popunite JMBG");
                clear();
                return;
            }
            string JMBG = txtJMBG.Text;
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string id = textBox1.Text;
            DateTime vremePregleda = dateTimePicker1.Value;
       

            if (vremePregleda < DateTime.Now)
            {
                MessageBox.Show("Nevalidan datum");
                return;
            }

            var baza = new DataDataContext();
            
            BazaN.Pacijent pacijent = new BazaN.Pacijent();
            BazaN.Pregled pregled = new BazaN.Pregled();

            pacijent = baza.Pacijents.Where(x => x.JMBG.Equals(JMBG)).SingleOrDefault();


            BazaN.Zaposleni lekar = new BazaN.Zaposleni();
        
            BazaN.Zaposleni izabrani = baza.Zaposlenis.Where(x => x.Id == pacijent.Id_Lekara).SingleOrDefault();

            int idPregleda = baza.Pregleds.ToList().Last().Id;

            if (!cbIzabrani.Checked)
            {
                if (dataGridView1.SelectedRows.Count != 0)
                {
                    lekar = (BazaN.Zaposleni)dataGridView1.CurrentRow.DataBoundItem;
                    pregled.Id_Pacijenta = pacijent.Id;
                    pregled.Id_Lekara = lekar.Id;
                    pregled.Id_ZS = lekar.Id_ZS;
                    pregled.Datum = vremePregleda;
                    idPregleda++;
                    pregled.Opis = "Pregled";
                    pregled.Id = idPregleda;
                    MessageBox.Show("Pacijent " + pacijent.Ime + " " + pacijent.Prezime + " je uspesno zakazao pregled.\nDatum pregleda: "
                        + pregled.Datum + " \nLekar: " + lekar.Ime + " " + lekar.Prezime, "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Niste selektovali lekara!", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    
                }
            }
            else
            {
                pregled.Id = ++idPregleda;
                pregled.Id_Pacijenta = pacijent.Id;
                pregled.Id_Lekara = izabrani.Id;
                pregled.Id_ZS = izabrani.Id_ZS;
                pregled.Datum = vremePregleda;
                pregled.Opis = "Pregled";
                MessageBox.Show("Pacijent " + pacijent.Ime + " " + pacijent.Prezime + " je uspesno zakazao pregled kod svog lekara.\nDatum pregleda: "
                    + pregled.Datum + " \nLekar: " + baza.Zaposlenis.Where(x => x.Id == pacijent.Id_Lekara).SingleOrDefault().Ime + " " + baza.Zaposlenis.Where(x => x.Id == pacijent.Id_Lekara).SingleOrDefault().Prezime, "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            baza.Pregleds.InsertOnSubmit(pregled);
            baza.SubmitChanges();   


        }

        private void txtJMBG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtJMBG.TextLength == 13 &&  !Char.IsControl(e.KeyChar))
                e.Handled = true;
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
        public void clear()
        {
            txtJMBG.Text = "";
            txtIme.Text = "";
            txtPrezime.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddMinutes(15);
            dateTimePicker1.Update();
        }

        private void btnSatiMinus_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSatiPlus_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value= dateTimePicker1.Value.AddHours(1);
            dateTimePicker1.Update();
            
        }

        private void btnMinutiMinus_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddMinutes(-15);
            dateTimePicker1.Update();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSatiMinus_Click_1(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddHours(-1);
            dateTimePicker1.Update();

        }

        private void cbIzabrani_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIzabrani.Checked)
                LoadIzabrani();
            else loadGrid();
        }

        private void txtJMBG_Leave(object sender, EventArgs e)
        {
            if (txtJMBG.TextLength < 13)
            {
                MessageBox.Show("JMBG mora imati 13 cifara", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtJMBG.Focus();
            }
        }

        private void btnPretraziLekare_Click(object sender, EventArgs e)
        {
            int p;

            var baza = new DataDataContext();
            if (txtPretragaLekara.TextLength == 0)
            {
                loadGrid();
            }
            else if (!Int32.TryParse(txtPretragaLekara.Text, out p))
            {
                List<BazaN.Zaposleni> lista = baza.Zaposlenis.Where(x => x.Ime.Contains(txtPretragaLekara.Text) && x.Tip>2).ToList();
                List<BazaN.Zaposleni> list = baza.Zaposlenis.Where(x => x.Prezime.Contains(txtPretragaLekara.Text) && x.Tip > 2).ToList();
                List<BazaN.Zaposleni> listica = baza.Zaposlenis.Where(x => x.JMBG == txtPretragaLekara.Text && x.Tip > 2).ToList();
                foreach (BazaN.Zaposleni z in list)
                {
                    lista.Add(z);

                }
                foreach (BazaN.Zaposleni z in listica)
                {
                    lista.Add(z);
                }
                
                LoadGridPar(lista);
            }
            else
            {
                List<BazaN.Zaposleni> lista = baza.Zaposlenis.Where(x => x.Id == int.Parse(txtPretragaLekara.Text) && x.Tip>2).ToList();
                LoadGridPar(lista);
            }
        }
    }
}
