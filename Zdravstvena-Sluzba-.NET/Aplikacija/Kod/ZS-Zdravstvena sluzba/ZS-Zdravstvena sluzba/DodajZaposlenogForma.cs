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
    public partial class DodajZaposlenogForma : Form
    {
        private BazaN.Zaposleni zap;
        private bool azuriraj;
        private string user="UNIQUE";
        public DodajZaposlenogForma()
        {
            InitializeComponent();
            azuriraj = false;
            zap = new BazaN.Zaposleni();
        }
        
        public DodajZaposlenogForma(BazaN.Zaposleni z)
            :this()
        {
            user = z.Username;
            azuriraj = true;
            var baza = new DataDataContext();
            zap.Id = z.Id;
            txtIme.Text = z.Ime;
            txtPrezime.Text = z.Prezime;
            txtJMBG.Text = z.JMBG;
            txtUsername.Text = z.Username;
            txtPassword.Text = z.Password;
            cbxTip.Text = baza.Zaposlenis.Where(x => x.Id == z.Id).SingleOrDefault().TipZaposlenog.TipZ;
            txtIDzu.Text = z.Id_ZS.ToString();
            cbOdmor.Checked = !z.Radi;
            if (z.Smena)
                rbPrva.Checked = true;
            else rbDruga.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (azuriraj == false)
            {
                
                var baza = new DataDataContext();

                zap.Ime = txtIme.Text;
                zap.Prezime = txtPrezime.Text;
                zap.JMBG = txtJMBG.Text;
                zap.Username = txtUsername.Text;
                zap.Password = txtPassword.Text;
                zap.Radi = !cbOdmor.Checked;
                if (rbPrva.Checked)
                    zap.Smena = true;
                else zap.Smena = false;
                zap.Id_ZS = Int16.Parse(txtIDzu.Text);
                zap.Tip = cbxTip.SelectedIndex+2;



                baza.Zaposlenis.InsertOnSubmit(zap);
                baza.SubmitChanges();
                this.Close();
                MessageBox.Show("Uspesno dodat zaposleni", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
             
                var baza = new DataDataContext();
                BazaN.Zaposleni z = baza.Zaposlenis.Where(x => x.Id == zap.Id).SingleOrDefault();

              //  user = txtUsername.Text;

                z.Ime = txtIme.Text;
                z.Prezime = txtPrezime.Text;
                z.JMBG = txtJMBG.Text;
                z.Username = txtUsername.Text;
                z.Password = txtPassword.Text;
                z.Id_ZS = Int16.Parse(txtIDzu.Text);
                z.Tip = cbxTip.SelectedIndex+2;
                z.Radi = !cbOdmor.Checked;
                if (rbPrva.Checked)
                    z.Smena = true;
                else z.Smena = false;

                baza.SubmitChanges();
                this.Close();
                
                MessageBox.Show("Uspesno azuriran zaposleni", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            
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

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.ToString() == " ") && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.ToString() == " ") && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtIDzu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtJMBG_Leave(object sender, EventArgs e)
        {
            if (txtJMBG.TextLength < 13)
            {
                MessageBox.Show("JMBG mora imati 13 cifara", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtJMBG.Focus();
            }
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

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.TextLength == 0)
            {
                MessageBox.Show("Polje username ne moze biti prazno!", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
            var baza = new DataDataContext();
            BazaN.Zaposleni z = baza.Zaposlenis.Where(x => x.Username == txtUsername.Text).SingleOrDefault();
            if (z != null || user.Equals(txtUsername.Text))
            {
                MessageBox.Show("Vec postoji zaposleni sa tim korisnickim imenom!", "Obavestenje!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsername.Focus();
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.TextLength == 0)
            {
                MessageBox.Show("Polje sifra ne moze biti prazno!", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
            }
        }

        private void txtIDzu_Leave(object sender, EventArgs e)
        {
            if (txtIDzu.TextLength == 0)
            {
                MessageBox.Show("Unesite ID zdravstvene ustanove!", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIDzu.Focus();
            }
        }

        private void cbxTip_Leave(object sender, EventArgs e)
        {
            if(cbxTip.Text == "")
            {
                MessageBox.Show("Izaberite tip zaposlenog!", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxTip.Focus();
            }
        }

        private void rbDruga_Click(object sender, EventArgs e)
        {
            rbPrva.Checked = false;
        }

        private void rbPrva_Click(object sender, EventArgs e)
        {
            rbDruga.Checked = false;
        }

        private void DodajZaposlenogForma_Load(object sender, EventArgs e)
        {
            if (azuriraj == true)
            {
                button1.Text = "Azuriraj zaposlenog";
                this.Text = "Azuriranje zaposlenog";
                button1.Image = Image.FromFile("D:\\Darko\\Documents\\III godina\\SWE\\zszs\\Zdravstvena sluzba - v2.0\\ZS-Zdravstvena sluzba1\\ZS-Zdravstvena sluzba\\rsz_pen-icon-image.png");
                
            }
            else
            {
                button1.Text = "Dodaj zaposlenog";
                this.Text = "Dodavanje zaposlenog";
                button1.Image = Image.FromFile("D:\\Darko\\Documents\\III godina\\SWE\\zszs\\Zdravstvena sluzba - v2.0\\ZS-Zdravstvena sluzba1\\ZS-Zdravstvena sluzba\\rsz_plus-math.png");
            }
        }

       
    }
}
