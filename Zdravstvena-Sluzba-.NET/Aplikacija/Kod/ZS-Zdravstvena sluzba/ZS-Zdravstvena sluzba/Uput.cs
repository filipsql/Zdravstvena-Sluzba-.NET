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
    public partial class Uput : Form
    {
        private int idLekara;
        private int idPacijenta;
        private int idZS;
        private List<BazaN.Zaposleni> lekari;
        private BazaN.Zaposleni izabraniLekar;
        public Uput(int id_Lekara, int id_Pacijenta, int id_ZS)
        {
            this.idLekara = id_Lekara;
            this.idPacijenta = id_Pacijenta;
            this.idZS = id_ZS;
            this.lekari = new List<BazaN.Zaposleni>();
            this.izabraniLekar = new BazaN.Zaposleni();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || richTextBox1.Text=="")
            {
                MessageBox.Show("Popunite adekvatno sva polja!");
            }
            else
            {
                var baza = new DataDataContext();
                BazaN.Uput uput = new BazaN.Uput();
                List<BazaN.Zaposleni> lekari = new List<BazaN.Zaposleni>();
                lekari = baza.Zaposlenis.Where(x=>((x.Tip==(comboBox1.SelectedIndex+3))&&x.Radi)).ToList();
                if (lekari == null)
                {
                    MessageBox.Show("Nije pronadjen zahtevan tip lekara u bazi podataka!","Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                uput.Datum = dateTimePicker1.Value;
                uput.Id_Pacijenta = this.idPacijenta;
                uput.Opis = richTextBox1.Text;
                IzaberiLekara il = new IzaberiLekara(lekari,uput,this);
                il.Show();
            }
        }

        private void Uput_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
