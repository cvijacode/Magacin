using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Magacin
{
    public class Proizvod
    {
        public string BarKod { get; set; }
        public string Naziv { get; set; }
        public string Vrsta { get; set; }
        public string JedinicaMere { get; set; }
        public string Cena { get; set; }

        public Proizvod()
        {

        }

        public Proizvod(string ln)
        {
            string[] lines = ln.Split('|');
            BarKod = lines[0];
            Naziv = lines[1];
            Vrsta = lines[2];
            JedinicaMere = lines[3];
            Cena = lines[4];
        }

        public static List<Proizvod> ProcitajProizvode()
        {
            List<Proizvod> lp = new List<Proizvod>();

            using (StreamReader sr = new StreamReader(HttpContext.Current.Server.MapPath("~/magacin.txt")))
            {
                try
                {
                    string line = sr.ReadLine();
                    while (!string.IsNullOrEmpty(line))
                    {
                        Proizvod pr = new Proizvod(line);
                        lp.Add(pr);
                        line = sr.ReadLine();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return lp;
        }

        public static void DodajProizvodeUFajl(List<Proizvod> proizvodi)
        {
            using (StreamWriter sw = new StreamWriter(HttpContext.Current.Server.MapPath("~/magacin.txt")))
            {
                try
                {
                    foreach (Proizvod P in proizvodi)
                    {
                        sw.WriteLine(P.BarKod + "|" + P.Naziv + "|" + P.Vrsta + "|" + P.JedinicaMere + "|" + P.Cena);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void ObrisiProizvod()
        {
            List<Proizvod> proizvodi = ProcitajProizvode();

            Proizvod P = proizvodi.FirstOrDefault(p => p.BarKod == this.BarKod);
            proizvodi.Remove(P);
            DodajProizvodeUFajl(proizvodi);
        }

        public void PronadjiProizvod(string bk)
        {
            List<Proizvod> proizvodi = ProcitajProizvode();

            Proizvod P = proizvodi.FirstOrDefault(p => p.BarKod == bk);
            if (P != null)
            {
                this.Naziv = P.Naziv;
                this.Vrsta = P.Vrsta;
                this.JedinicaMere = P.JedinicaMere;
                this.Cena = P.Cena;
            }
        }

        public static void DodajProizvod(Proizvod P)
        {
            using (StreamWriter sw = new StreamWriter(HttpContext.Current.Server.MapPath("~/magacin.txt"), true))
            {
                try
                {
                    sw.WriteLine(P.BarKod + "|" + P.Naziv + "|" + P.Vrsta + "|" + P.JedinicaMere + "|" + P.Cena);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void IzmeniPodatke()
        {
            try
            {
                List<Proizvod> proizvodi = new List<Proizvod>();
                proizvodi = ProcitajProizvode();

                Proizvod P = proizvodi.FirstOrDefault(p => p.BarKod == this.BarKod);
                if (P != null)
                {
                    P.Naziv = this.Naziv;
                    P.Vrsta = this.Vrsta;
                    P.JedinicaMere = this.JedinicaMere;
                    P.Cena = this.Cena;
                }
                DodajProizvodeUFajl(proizvodi);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}