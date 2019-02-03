using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Arbiter; 

namespace Arbiter
{
    public partial class ProductoAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             Lmsj.Text = "";
             if (!IsPostBack)
             {
                 LlenarListaTipo();
                
             }
        }


        private void LlenarListaTipo()
        {
            DDLTipo.Items.Insert(0, new ListItem("Seleccione", "0"));
            DDLTipo.Items.Insert(1, new ListItem("Camisa", "1"));
            DDLTipo.Items.Insert(2, new ListItem("Pantalón", "2"));
            DDLTipo.Items.Insert(3, new ListItem("Traje", "3"));
            DDLTipo.Items.Insert(4, new ListItem("Esmoquin", "4"));
            DDLTipo.Items.Insert(5, new ListItem("Corbata", "5"));
            DDLTipo.Items.Insert(6, new ListItem("Accesorio", "6"));
        }

        protected void BAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                ConexionBDAdmin objBD = new ConexionBDAdmin();
                if (objBD.ExisteProducto(TBCodigo.Text))
                {
                    Lmsj.Text = "EL código ya existe";
                }
                else
                {
                    Articulo miArticulo = new Articulo(TBMarca.Text, TBTalla.Text, TBColor.Text, ImagenFile.PostedFile.FileName, DDLTipo.SelectedItem.Text, int.Parse(TBMonto.Text), TBCodigo.Text);

                    if (objBD.AgregarProducto(miArticulo))
                    {
                        DDLTipo.SelectedIndex = 0;
                        TBMarca.Text = "";
                        TBColor.Text = "";
                        TBTalla.Text = "";
                        TBMonto.Text = "";
                        TBCodigo.Text = "";                                          
                        Lmsj.Text = "El producto ha sido agregado exitosamente";
                    }
                    else
                    {
                        Lmsj.Text = "Error con Base de Datos, no se pudo agregar el producto";
                    }
                }
            }
        }

        bool ValidarCampos()
        {
            bool valido = true;
            if (ImagenFile.FileName == "")
            {
                Lmsj.Text = "Ingrese la imagen";
                valido = false;
            }
            if (TBCodigo.Text == "")
            {
                Lmsj.Text = "Indique el código";
                valido = false;
            }
            if (TBMonto.Text == "")
            {
                Lmsj.Text = "Indique el monto";
                valido = false;
            }
            if (TBTalla.Text == "")
            {
                Lmsj.Text = "Indique talla";
                valido = false;
            }
            if (TBMarca.Text == "")
            {
                Lmsj.Text = "Indique marca";
                valido = false;
            }
            if (DDLTipo.SelectedIndex == 0)
            {
                Lmsj.Text = "Seleccione tipo";
                valido = false;
            }
            return valido; 
        }

    }
}