using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Drawing;
using System.Data;
using System.IO;

namespace Arbiter
{
    public partial class ProductoDel : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Lmsj.Text = ""; 
        }

        protected void BBuscar_Click(object sender, EventArgs e)
        {
            if (TBcodigo.Text == "")
            {
                Lmsj.Text = "Ingrese codigo del producto";
                InicializarValores();
            }
            else
            {
                ConexionBDAdmin objBD = new ConexionBDAdmin ();
                Articulo miArticulo = objBD.BuscarProductoCodigo(TBcodigo.Text);
                if (miArticulo == null)
                {
                    Lmsj.Text = "codigo del producto incorrecto";
                    InicializarValores();
                }
                else
                {
                    using (MemoryStream ms = new MemoryStream(miArticulo.Imagen, 0, miArticulo.Imagen.Length))
                    {
                        ms.Write(miArticulo.Imagen, 0, miArticulo.Imagen.Length);
                        Image1.ImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(ms.ToArray(), 0, ms.ToArray().Length);      
                    }
                    LTipo.Text = miArticulo.GSTipo;
                    LMarca.Text = miArticulo.GSMarca;
                    LColor.Text = miArticulo.GSColor;
                    LTalla.Text = miArticulo.GSTalla;
                    LMonto.Text = miArticulo.GSMonto.ToString();
                    TBcodigo.Text = miArticulo.GSCodigo; 
                }
            }              
        }

        protected void BEliminar_Click(object sender, EventArgs e)
        {
            if (LTipo.Text != "")
            {
                ConexionBDAdmin objBD = new ConexionBDAdmin();
                if (objBD.EliminaProducto(TBcodigo.Text))
                {
                    Lmsj.Text = "El producto se ha eliminado del catálogo satisfactoriamente";
                    InicializarValores();

                }
                else
                {
                    Lmsj.Text = "Error con Base de Datos, no se pudo eliminar el producto";
                    InicializarValores();
                }
            }
        }

        private void InicializarValores()
        {
            LTipo.Text = "";
            LMarca.Text = "";
            LColor.Text = "";
            LTalla.Text = "";
            LMonto.Text = "";
            TBcodigo.Text = "";
            Image1.ImageUrl = ""; 
        }







    }
}