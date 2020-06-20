using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZS_Zdravstvena_sluzba.Klase
{
    public class StatistikaLista
    {
        private int broj;
        private string bolest;

        public int Broj
        {
            get
            {
                return this.broj;
            }
            set
            {
                this.broj = value;
            }
        }

        public string Bolest
        {
            get
            {
                return this.bolest;
            }
            set
            {
                this.bolest = value;
            }
        }
    }
}
