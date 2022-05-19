using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RestApp_Site
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                cargarListado();
            }
        }

        private void cargarListado()
        {
            DataTable dtProductos = new DataTable();
            dtProductos.Columns.Add("Cantidad");
            dtProductos.Columns.Add("Producto");
            dtProductos.Columns.Add("Total");


            DataRow drProd1 = dtProductos.NewRow();
            drProd1["cantidad"] = "1";
            drProd1["producto"] = "Coca Cola";
            drProd1["Total"] = "5,000.0";
            dtProductos.Rows.Add(drProd1);

            DataRow drProd2 = dtProductos.NewRow();
            drProd2["cantidad"] = "3";
            drProd2["producto"] = "Batidos de Fresas";
            drProd2["Total"] = "18,000.0";
            dtProductos.Rows.Add(drProd2);


            DataRow drProd3 = dtProductos.NewRow();
            drProd3["cantidad"] = "2";
            drProd3["producto"] = "Hamburguesas Dobles";
            drProd3["Total"] = "60,000.0";
            dtProductos.Rows.Add(drProd3);

            gvListado.DataSource = dtProductos;
            gvListado.DataBind();

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            pnlIngresar.Visible = false;
            pnlCuenta.Visible = true;
        }

        protected void gvListado_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void gvListado_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void gvListado_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

        }
    }
}