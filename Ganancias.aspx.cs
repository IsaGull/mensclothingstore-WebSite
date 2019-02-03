using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace Arbiter
{
    public partial class Ganascias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarPorMes();
            }
        }


        public void CargarTodoelaño(DataTable dtReporte)
        {
            ConexionBDAdmin objBD = new ConexionBDAdmin();
            string montoTotal = objBD.BucarMontoGanaciaTotal();

            DataRow dr = dtReporte.NewRow();
            dr["Mes"] = "TOTAL";
            dr["Monto $"] = montoTotal;
            dtReporte.Rows.Add(dr);
            GridView1.DataSource = dtReporte;
            GridView1.DataBind();
            GridView1.Visible = true;
        }


        public void CargarPorMes()
        {
            ConexionBDAdmin objBD = new ConexionBDAdmin();
            string select = "select mes, monto from cambiomoneda";
            DataTable dtReporte = objBD.ReporteVentas(select, "Mes", "Monto $");
            CargarTodoelaño(dtReporte);

        }
    }
}