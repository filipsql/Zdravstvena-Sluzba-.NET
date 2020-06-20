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
    public partial class DodavanjePacijentaForma : Form
    {
        public BazaN.Pacijent pac;
        public bool azuriranje;
        public DodavanjePacijentaForma()
        {
            InitializeComponent();
            azuriranje = false;
            pac = new BazaN.Pacijent();
        }
        public DodavanjePacijentaForma(BazaN.Pacijent p)
            :this()
        {
            azuriranje = true;
            var baza = new DataDataContext();
            pac.Id = p.Id;
            txtIme.Text = p.Ime;
            txtPrezime.Text = p.Prezime;
            txtJMBG.Text = p.JMBG;
            txtIDLek.Text = p.Id_Lekara.ToString();

        }

        private void btnDodajPacijenta_Click(object sender, EventArgs e)
        {
           
                var baza = new DataDataContext();
                if (baza.Zaposlenis.Where(x => x.Id == Int16.Parse(txtIDLek.Text)).SingleOrDefault() != null)
                {
                    pac.Ime = txtIme.Text;
                    pac.Prezime = txtPrezime.Text;
                    pac.JMBG = txtJMBG.Text;
                    pac.Id_Lekara = Int16.Parse(txtIDLek.Text);

                    baza.Pacijents.InsertOnSubmit(pac);
                    baza.SubmitChanges();
                    this.Close();
                    MessageBox.Show("Uspesno dodat pacijent", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Ne postoji lekar sa tim ID-jem!", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);

           
            

            
        }

        private void txtIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtPrezime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtJMBG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtJMBG.TextLength == 13 && !Char.IsControl(e.KeyChar))
                e.Handled = true;
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtIDLek_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtIme_Leave(object sender, EventArgs e)
        {
            if (txtIme.TextLength == 0)
            {
                MessageBox.Show("Polje ime ne moze biti prazno!", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIme.Focus();
            }
        }

        private void txtPrezime_Leave(object sender, EventArgs e)
        {
            if (txtPrezime.TextLength == 0)
            {
                MessageBox.Show("Polje prezime ne moze biti prazno!", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrezime.Focus();
            }
        }

        private void txtJMBG_Leave(object sender, EventArgs e)
        {
            if (txtJMBG.TextLength < 13)
            {
                MessageBox.Show("JMBG mora imati 13 cifara", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtJMBG.Focus();
            }
        }

        private void txtIDLek_Leave(object sender, EventArgs e)
        {
            if (txtIDLek.TextLength == 0)
            {
                MessageBox.Show("Unesite ID lekara!", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIDLek.Focus();
            }
            var baza = new DataDataContext();
            BazaN.Zaposleni z = baza.Zaposlenis.Where(x => x.Id == Int16.Parse(txtIDLek.Text)).SingleOrDefault();
            if (z == null)
            {
                MessageBox.Show("Ne postoji lekar sa tim ID-jem", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
