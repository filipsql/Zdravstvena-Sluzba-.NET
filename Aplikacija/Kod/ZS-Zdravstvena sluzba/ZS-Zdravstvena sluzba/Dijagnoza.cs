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


/// <summary>
/// ZA DIJAGNOZU JE POTREBNO DA SE DORADI SLEDECE:
/// DODAT JE STRING TERAP U KLASI TERAPIJA;
/// DODATA FUNKCIJA ZA AZURIRANJETERAPIJA U KLASI TERAPIJA;
/// NAPRAVLJENA JE NOVA KOLONA U TABELI "TERAPIJA" - koja se zove isto terapija xD jer nije dovoljna samo jedna tabela i za dijagnozu i za opis
/// 
/// DA SE NAPRAVI STRING TERAP ZA KLASU BAZEN.TERAPIJA DA BI MOGLO DA SE UNOSI U NOVU KOLONU U BAZI "TERAPIJA"
/// POTREBNO JE DODATI ID LEKARA PROMENJIVOJ LEKAR KOJA SE NALAZI U KLASI LekarForm.cs, taj id bi trebao da bude id lekara koji je trenutno prijavljen
/// PORTRENO JE TAJ ID DODATI KAO ARGUMENT U OVOJ KLASI (postoji komentar gde treba) DA BI SE ZNALO KOJI JE LEKAR NAPISAO DIJAGNOZU
/// 
///
/// </summary>
namespace ZS_Zdravstvena_sluzba
{
    public partial class Dijagnoza : Form
    {
        private int idLekara;
        private int idPacijenta;
        public Dijagnoza()
        {
            InitializeComponent();
            this.idLekara = 1;
        }
        public Dijagnoza(BazaN.Pacijent p)
            :this()
        {
            this.idPacijenta = p.Id;
          //ovde ce da ide ID lekara od prosle klase kad se to sredi
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BazaN.Terapija terp = new BazaN.Terapija();
            terp.Id_Pacijenta = this.idPacijenta;
            terp.Id_Lekara = this.idLekara;
            terp.Datum = DateTime.Now;
            terp.Opis = richTextBox1.Text;
            terp.Dijagnoza = richTextBox2.Text;
            var baza = new DataDataContext();
            baza.Terapijas.InsertOnSubmit(terp);
            baza.SubmitChanges();
            this.Close();
        }

        private void Dijagnoza_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
