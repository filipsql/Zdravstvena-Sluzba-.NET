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
    public partial class StatistikaForma : Form
    {
        private List<StatistikaLista> lista;
        public StatistikaForma()
        {
            InitializeComponent();
            lista = new List<StatistikaLista>();
        }
        public StatistikaForma(List<StatistikaLista> sl) 
            :this()
        {
            lista = sl;
        }

        private void StatistikaForma_Load(object sender, EventArgs e)
        {
            List<int> integeri = new List<int>();
            List<string> stringovi = new List<string>();
            for (int i = 0; i < lista.Count;i++ )
            {
                integeri.Add(lista[i].Broj);
                stringovi.Add(lista[i].Bolest);
            }
            chart1.Series[0].Points.DataBindXY(stringovi, integeri);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
       
       
    }
}
