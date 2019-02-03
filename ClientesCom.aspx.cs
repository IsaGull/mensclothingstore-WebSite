using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Arbiter
{
    public partial class ClientesCom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarListaMes();
                CargarTodoelaño();
            }
        }

        private void LlenarListaMes()
        {
            DDLMes.Items.Insert(0, new ListItem("Todo el año", "0"));
            DDLMes.Items.Insert(1, new ListItem("Enero", "1"));
            DDLMes.Items.Insert(2, new ListItem("Febrero", "2"));
            DDLMes.Items.Insert(3, new ListItem("Marzo", "3"));
            DDLMes.Items.Insert(4, new ListItem("Abril", "4"));
            DDLMes.Items.Insert(5, new ListItem("Mayo", "5"));
        }

        public void CargarTodoelaño()
        {
            ConexionBDAdmin objBD = new ConexionBDAdmin();


            string select = "select DISTINCT   cl.nombre, max(co.montocompra) as montomax from Compra co, cliente cl where cl.id=co.fk_cliente  group by cl.nombre order by montomax desc";
            DataTable dtReporte = objBD.ReporteVentas(select, "Cliente", "Monto BSF");
            GridView1.DataSource = dtReporte;
            GridView1.DataBind();
            GridView1.Visible = true;
        }


        public void CargarPorMes(int mes)
        {
            ConexionBDAdmin objBD = new ConexionBDAdmin();
            string select = "select DISTINCT   cl.nombre, max(co.montocompra) as montomax from Compra co, cliente cl where cl.id=co.fk_cliente  and       co.fechacompra=10-" + mes + "-2015 group by cl.nombre order by montomax desc";
            DataTable dtReporte = objBD.ReporteVentas(select, "Cliente", "Monto BSF");
            GridView1.DataSource = dtReporte;
            GridView1.DataBind();
            GridView1.Visible = true;
        }

        protected void DDLMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DDLMes.SelectedIndex == 0)
            {
                CargarTodoelaño();
            }
            else
            {
                CargarPorMes(DDLMes.SelectedIndex);
            }
        }

    }
}