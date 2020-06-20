using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZS_Zdravstvena_sluzba.Klase
{
    public class PreglediPrikaz
    {
        private int id;
        private string ime;
        private string prezime;
        private int brPregleda;

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public string Ime
        {
            get
            {
                return this.ime;
            }
            set
            {
                this.ime = value;
            }
        }

        public string Prezime
        {
            get
            {
                return this.prezime;
            }

            set
            {
                this.prezime = value;
            }
        }
        public int BrPregleda
        {
            get
            {
                return this.brPregleda;
            }
            set
            {
                this.brPregleda = value;
            }
        }
    }
}
