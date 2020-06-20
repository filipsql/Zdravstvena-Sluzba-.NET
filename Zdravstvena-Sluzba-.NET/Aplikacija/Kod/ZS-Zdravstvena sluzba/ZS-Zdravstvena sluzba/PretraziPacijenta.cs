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
    public partial class PretraziPacijenta : Form
    {
        public BazaN.Pacijent pac;
        public PretraziPacijenta()
        {
            InitializeComponent();
            pac = new BazaN.Pacijent();
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            var baza = new DataDataContext();

            pac = baza.Pacijents.Where(x => x.JMBG.ToString() == txtTrazi.Text).SingleOrDefault();
            if (pac != null)
            {
                txtIme.Text = pac.Ime;
                txtPrezime.Text = pac.Prezime;
                txtJBMG.Text = pac.JMBG;
                txtIDLek.Text = pac.Id_Lekara.ToString();
            }
            else
            {
                MessageBox.Show("Ne postoji pacijent sa tim JMBG-om!", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (this.pac != null && this.pac.Alergeni != null)
            {
                var baza = new DataDataContext();

                if (baza.Zaposlenis.Where(x => x.Id == Int16.Parse(txtIDLek.Text)).SingleOrDefault() != null)
                {
                    BazaN.Pacijent pacijent = baza.Pacijents.Where(x => x.Id == pac.Id).SingleOrDefault();
                    pacijent.Ime = txtIme.Text;
                    pacijent.Prezime = txtPrezime.Text;
                    pacijent.JMBG = txtJBMG.Text;
                    pacijent.Id_Lekara = Int16.Parse(txtIDLek.Text);

                    baza.SubmitChanges();
                    MessageBox.Show("Pacijent uspesno azuriran!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                    MessageBox.Show("Ne postoji lekar sa tim ID-jem!", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            MessageBox.Show("Ne postoji pacijent sa adekvatnim JMBG-om, ili niste kliknuli na dugme za pretragu");
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (this.pac != null && this.pac.Alergeni!=null)
            {
                DialogResult dlg = MessageBox.Show("Da li ste sigurni?\nPromene su trajne!", "Obavestenje!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dlg == DialogResult.Yes)
                {
                    var baza = new DataDataContext();

                    BazaN.Pacijent pacijent = baza.Pacijents.Where(x => x.Id == pac.Id).SingleOrDefault();
                    baza.Pacijents.DeleteOnSubmit(pacijent);
                    baza.SubmitChanges();
                    MessageBox.Show("Pacijent uspesno izbrisan!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else return;
            }
            else
                MessageBox.Show("Ne postoji pacijent sa adekvatnim JMBG-om, ili niste kliknuli na dugme za pretragu");
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

        private void txtJBMG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtJBMG.TextLength==13 && !Char.IsControl(e.KeyChar))
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

        private void txtJBMG_Leave(object sender, EventArgs e)
        {
            if (txtJBMG.TextLength == 0 || txtJBMG.TextLength < 13)
            {
                MessageBox.Show("JMBG mora imati 13 cifara", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtJBMG.Focus();
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

        private void txtTrazi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtTrazi.TextLength==13 && !Char.IsControl(e.KeyChar))
                e.Handled = true;
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtTrazi_Leave(object sender, EventArgs e)
        {
            if (txtTrazi.TextLength < 13)
            {
                MessageBox.Show("JMBG mora imati 13 cifara", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTrazi.Focus();
            }
        }

        private void txtTrazi_TextChanged(object sender, EventArgs e)
        {
            this.pac = null;
        }
    }
}
