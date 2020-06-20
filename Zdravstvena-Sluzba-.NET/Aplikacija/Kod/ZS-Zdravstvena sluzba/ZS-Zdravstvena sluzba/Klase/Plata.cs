using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZS_Zdravstvena_sluzba.Klase
{
    public class Plata
    {
        private int id;
        private string ime;
        private string prezime;
        private double isplata;

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
        public double Isplata
        {
            get
            {
                return this.isplata;
            }
            set
            {
                this.isplata = value;
            }
        }
    }
}
