using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Magacin
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Proizvod> lp = Proizvod.ProcitajProizvode();
            grdProizvodi.DataSource = lp;
            grdProizvodi.DataBind();
        }

        protected void grdProizvodi_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Izmena")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument.ToString());
                string bk = grdProizvodi.Rows[rowIndex].Cells[0].Text;
                Proizvod P = new Proizvod();
                P.BarKod = bk;
                P.PronadjiProizvod(bk);
                Session["Proizvod"] = P;
                Session["NoviProizvod"] = false;
                Response.Redirect("~/Dodavanje.aspx");
            }
            else
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument.ToString());
                string bk = grdProizvodi.Rows[rowIndex].Cells[0].Text;
                Proizvod P = new Proizvod();
                P.BarKod = bk;
                P.ObrisiProizvod();
                Response.Redirect("~/Default.aspx");
            }
        }

        protected void btnDodaj_Click(object sender, EventArgs e)
        {
            Session["NoviProizvod"] = true;
            Session["Proizvod"] = null;
            Response.Redirect("~/Dodavanje.aspx");
        }
    }
}