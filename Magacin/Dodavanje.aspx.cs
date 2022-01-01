using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Magacin
{
    public partial class Dodavanje : System.Web.UI.Page
    {
        private bool NoviProizvod;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["NoviProizvod"] != null)
            {
                NoviProizvod = Boolean.Parse(Session["NoviProizvod"].ToString());
            }
            else
            {
                NoviProizvod = false;
            }

            if(Session["Proizvod"] != null)
            {
                if(!NoviProizvod)
                {
                    Proizvod P = Session["Proizvod"] as Proizvod;

                    txtBarKod.Text = P.BarKod;
                    txtNaziv.Text = P.Naziv;
                    txtVrsta.Text = P.Vrsta;
                    txtJedinicaMere.Text = P.JedinicaMere;
                    txtCena.Text = P.Cena;
                }
                Session["Proizvod"] = null;
            }
        }

        protected void btnSacuvaj_Click(object sender, EventArgs e)
        {
            bool NoviProizvod = Boolean.Parse(Session["NoviProizvod"].ToString());

            Proizvod P = new Proizvod();
            P.BarKod = txtBarKod.Text;
            P.Naziv = txtNaziv.Text;
            P.Vrsta = txtVrsta.Text;
            P.JedinicaMere = txtJedinicaMere.Text;
            P.Cena = txtCena.Text;

            if(NoviProizvod == true)
            {
                Proizvod.DodajProizvod(P);
            }
            else
            {
                P.IzmeniPodatke();
            }
            Response.Redirect("~/Default.aspx");
        }

        protected void btnOdustani_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }
    }
}