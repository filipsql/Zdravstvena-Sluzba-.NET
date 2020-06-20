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
    public partial class Login : Form
    {
        public Administrator af;
        public LekarForm lf;
        public Osoblje pof;
        public Login()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            var baza = new DataDataContext();
            if (baza.DatabaseExists())
            {
                string user = txtKorisnickoIme.Text;
                string pas = txtLozinka.Text;
                int id = ZS_Zdravstvena_sluzba.Klase.Zaposleni.vratiIdZap(user, pas);
                int idZS = ZS_Zdravstvena_sluzba.Klase.Zaposleni.vratiIzZS(id);
                string tip = ZS_Zdravstvena_sluzba.Klase.Zaposleni.logujiSe(user, pas);
                if (tip == null)
                {
                    MessageBox.Show("Neipsravni username i password\nPokusajte ponovo", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (tip == "pomocno")
                {
                    pof = new Osoblje();
                    pof.Show();
                }
                else if (tip == "administrator")
                {
                    af = new Administrator();
                    af.Show();
                }
                else
                {
                    lf = new LekarForm(id, idZS);
                    lf.Show();
                }
            }
            else
            {
                MessageBox.Show("Ne postoji baza podataka!\nObratite se administratoru!", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}
