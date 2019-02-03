using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace Arbiter
{
    public partial class VentasArt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarListaMes();
                LlenarListaTipo();
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

        private void LlenarListaTipo()
        {
            //DDLTipo.Items.Insert(0, new ListItem("Seleccione", "0"));
            DDLTipo.Items.Insert(0, new ListItem("Camisa", "0"));
            DDLTipo.Items.Insert(1, new ListItem("Pantalón", "1"));
            DDLTipo.Items.Insert(2, new ListItem("Traje", "2"));
            DDLTipo.Items.Insert(3, new ListItem("Esmoquin", "3"));
            DDLTipo.Items.Insert(4, new ListItem("Corbata", "4"));
            DDLTipo.Items.Insert(5, new ListItem("Accesorio", "5"));
        }


        public void CargarTodoelaño()
        {
            ConexionBDAdmin objBD = new ConexionBDAdmin();
            string select = "select po.marca, count(copo.fk_producto) 	from Producto po, compraproducto copo	where po.id = copo.fk_producto and		  po.tipo = '"+DDLTipo.SelectedItem.Text+"'  	group by po.marca	order by count(copo.fk_producto)desc";
            DataTable dtReporte = objBD.ReporteVentas(select, "Marca", "Cantida vendida");
            GridView1.DataSource = dtReporte;
            GridView1.DataBind();
            GridView1.Visible = true;
        }

        public void CargarPorMes(int mes)
        {
            ConexionBDAdmin objBD = new ConexionBDAdmin();
            string select = "select po.marca, count(copo.fk_producto) 	from Producto po, compraproducto copo, compra co	where po.id = copo.fk_producto and		  co.id=copo.fk_compra and		  co.fechacompra = 10-" + mes + "-2015 and		  po.tipo = '" + DDLTipo.SelectedItem.Text + "'   group by po.marca	order by count(copo.fk_producto)desc";
            DataTable dtReporte = objBD.ReporteVentas(select, "Marca", "Cantida vendida");
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

        protected void DDLTipo_SelectedIndexChanged(object sender, EventArgs e)
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