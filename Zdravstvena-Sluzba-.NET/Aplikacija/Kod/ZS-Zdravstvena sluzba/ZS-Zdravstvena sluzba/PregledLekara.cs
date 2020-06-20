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
    public partial class PregledLekara : Form
    {
        private int lekarId;
        public PregledLekara()
        {
            InitializeComponent();
        }

        public PregledLekara(int a)
            :this()

        {
            lekarId = a;

        }

        private void PregledLekara_Load(object sender, EventArgs e)
        {
            promeniUredjenjePregleda();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            promeniUredjenjePregleda();
        }
     public void promeniUredjenjePregleda()
        {
            var baza = new DataDataContext();
            List<BazaN.Pregled> pregled = new List<BazaN.Pregled>();
            List<BazaN.Uput> uput1 = new List<BazaN.Uput>();
            List<BazaN.Uput> uput = new List<BazaN.Uput>();


            DateTime datum = dateTimePicker1.Value;
           

            pregled = baza.Pregleds.Where(x => x.Id_Lekara == lekarId).ToList();
            uput = baza.Uputs.Where(x => x.Id_Lekara == lekarId).ToList();


            var novaListaP = pregled.OrderBy(x => x.Datum).ToList();
            var novaListaU = uput.OrderBy(x => x.Datum).ToList();

           
            foreach(var v in novaListaP)
            {
                BazaN.Uput u = new BazaN.Uput();
                u.Id = v.Id;
                u.Id_Lekara = v.Id_Lekara;
                u.Id_Pacijenta = v.Id_Pacijenta;
                u.Id_ZS = v.Id_ZS;
                u.Opis = v.Opis;
                u.Datum = v.Datum;

                novaListaU.Add(u);
            }

            foreach (var v in novaListaU)
            {
                if (datum.Date <= v.Datum)
                {
                    uput1.Add(v);
                }
            }

            var finalna=uput1.OrderBy(x => x.Datum).ToList();

            dataGridView1.DataSource = finalna;



            foreach (DataGridViewColumn s in dataGridView1.Columns)
            {
                s.Visible = false;

                if (s.HeaderText == "Id")
                {
                    s.Visible = true;
                    s.Width = 40;
                }
                if (s.HeaderText == "Id_Lekara")
                {
                    s.Visible = true;
                    s.Width = 40;
                }
                if (s.HeaderText == "Id_Pacijenta")
                {
                    s.Visible = true;
                    s.Width = 40;
                }
                if (s.HeaderText == "Opis")
                {
                    s.Visible = true;
                }
                if (s.HeaderText == "Id_ZS")
                {
                    s.Visible = true;
                    s.Width = 40;
                }
                if (s.HeaderText == "Datum")
                {
                    s.Visible = true;
                }
            }
        }
    }
}
