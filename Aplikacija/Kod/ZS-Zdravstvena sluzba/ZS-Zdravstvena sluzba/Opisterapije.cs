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
    public partial class Opisterapije : Form
    {
        private BazaN.Terapija trp;
        public Opisterapije(BazaN.Terapija trp)
        {
            this.trp = new BazaN.Terapija();
            this.trp = trp;
            InitializeComponent();
        }

        private void Opisterapije_Load(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = true;
            richTextBox2.ReadOnly = true;
            richTextBox1.Text = trp.Opis;
            richTextBox2.Text = trp.Dijagnoza;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
