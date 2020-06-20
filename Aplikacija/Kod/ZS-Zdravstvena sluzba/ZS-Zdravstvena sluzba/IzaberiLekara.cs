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

namespace ZS_Zdravstvena_sluzba
{
    public partial class IzaberiLekara : Form
    {
        private List<BazaN.Zaposleni> lekari;
        private BazaN.Zaposleni lekar;
        private BazaN.Uput uput;
        private Uput up;
        public IzaberiLekara(List<BazaN.Zaposleni> lekari,BazaN.Uput uput,Uput up)
        {
            this.lekari = new List<BazaN.Zaposleni>();
            this.uput = new BazaN.Uput();
            this.lekari = lekari;
            this.lekar = new BazaN.Zaposleni();
            this.uput = uput;
            this.up = up;
            InitializeComponent();
        }

        private void IzaberiLekara_Load(object sender, EventArgs e)
        {
        }

        private void IzaberiLekara_Activated(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.lekari;
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
                if (s.HeaderText == "Radi")
                {
                    s.Visible = true;
                }
                if (s.HeaderText == "Smena")
                {
                    s.Visible = true;
                }
                if (s.HeaderText == "Id_ZS")
                {
                    s.HeaderText = "Id ustanove";
                    s.Visible = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var baza = new DataDataContext();
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selektujte lekara", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dataGridView1.Focus();
            this.lekar=(BazaN.Zaposleni)dataGridView1.CurrentRow.DataBoundItem;
            this.uput.Id_ZS = this.lekar.Id_ZS;
            this.uput.Id_Lekara = this.lekar.Id;
            baza.Uputs.InsertOnSubmit(uput);
            baza.SubmitChanges();
            this.up.Close();
            this.Close();
        }
    }
}
