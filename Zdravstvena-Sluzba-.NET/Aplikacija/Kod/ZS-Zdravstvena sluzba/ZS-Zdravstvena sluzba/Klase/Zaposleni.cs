using BazaN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZS_Zdravstvena_sluzba.Klase
{
    public class Zaposleni
    {
        protected int id;
        protected String ime;
        protected String prezime;
        protected string jmbg;
        protected bool radniDan;
        protected bool smena;
        protected String username;
        protected String password;
        protected int tipZaposlenog;
        protected int idZU;


        public static string logujiSe(string user,string pas)
        {
            var baza = new DataDataContext();

            var zaposleni = baza.Zaposlenis.Where(x => x.Username == user && x.Password == pas).SingleOrDefault();
            if(zaposleni != null)
                return zaposleni.TipZaposlenog.TipZ;
            else
            {
                return null;
            }
            
        }

        public static int vratiIdZap(string user, string pas)
        {
            var baza = new DataDataContext();

            BazaN.Zaposleni zaposleni = baza.Zaposlenis.Where(x => x.Username == user && x.Password == pas).SingleOrDefault();
            if (zaposleni != null)
                return zaposleni.Id;
            else return -1;
        }

        public static void azurirajZaposlenog(BazaN.Zaposleni z)
        {
            var baza = new DataDataContext();
            BazaN.Zaposleni zap = baza.Zaposlenis.Where(x => x.Id == z.Id).SingleOrDefault();
            zap.Username = z.Username;
            zap.Password = z.Password;
            zap.Id_ZS = z.Id_ZS;
            baza.SubmitChanges();

        }
        public static int vratiIzZS(int idZap)
        {
            var baza = new DataDataContext();
            BazaN.Zaposleni zap = new BazaN.Zaposleni();
            zap = baza.Zaposlenis.Where(x=>x.Id==idZap).SingleOrDefault();//vraca zaposlenog s tim id-jem
            if (zap != null)
                return zap.Id_ZS;
            else return -1;
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public int IdZU
        {
            get 
            {
                return idZU;
            }
            set
            {
                idZU = value;
            }
        }
        public int TipZaposlenog
        {
            get 
            {
                return tipZaposlenog;
            }
            set 
            {
                tipZaposlenog = value;
            }
        }

        public String Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
            }
        }

        public String Prezime
        {
            get
            {
                return prezime;
            }

            set
            {
                prezime = value;
            }
        }

        public string JMBG
        {
            get
            {
                return jmbg;
            }

            set
            {
                jmbg = value;
            }
        }

        public bool RadniDan
        {
            get
            {
                return radniDan;
            }

            set
            {
                radniDan = value;
            }
        }

        public bool Smena
        {
            get
            {
                return smena;
            }

            set
            {
                smena = value;
            }
        }

        public String Username
        {
            get 
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        public String Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
    }
    }
