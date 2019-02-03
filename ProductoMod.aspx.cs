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
    public partial class ProductoMod : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Lmsj.Text = "";
           
            if (!IsPostBack)
            {
                LlenarListaTipo();
                InicializarValores();

            }
        }

        protected void BBuscar_Click(object sender, EventArgs e)
        {
            if (!TBCodigo.Enabled)
            {
                TBCodigo.Enabled = true;
                InicializarValores();
            }
            else
            {
                if (TBCodigo.Text == "")
                {
                    Lmsj.Text = "Ingrese codigo del producto";
                    InicializarValores();
                }
                else
                {
                    ConexionBDAdmin objBD = new ConexionBDAdmin();
                    Articulo miArticulo = objBD.BuscarProductoCodigo(TBCodigo.Text);
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
                        DDLTipo.SelectedIndex = BuscarIndex(miArticulo.GSTipo);
                        TBMarca.Text = miArticulo.GSMarca;
                        TBColor.Text = miArticulo.GSColor;
                        TBTalla.Text = miArticulo.GSTalla;
                        TBMonto.Text = miArticulo.GSMonto.ToString();
                        TBCodigo.Text = miArticulo.GSCodigo;
                        TBCodigo.Enabled = false;
                        DDLTipo.Enabled = true;
                        TBMarca.Enabled = true;
                        TBColor.Enabled = true;
                        TBTalla.Enabled = true;
                        TBMonto.Enabled = true;
                        ImagenFile.Enabled = true;
                    }
                }
            }
        }

        protected void BModificar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (ImagenFile.FileName == "")
                {
                    ConexionBDAdmin objBD = new ConexionBDAdmin();
                    Articulo miArticulo = new Articulo(TBMarca.Text, TBTalla.Text, TBColor.Text, ImagenFile.PostedFile.FileName, DDLTipo.SelectedItem.Text, int.Parse(TBMonto.Text), TBCodigo.Text);
                    if (objBD.ModificarProducto(miArticulo))
                    {
                        InicializarValores();
                        Lmsj.Text = "El producto se ha modificado satisfactoriamente";
                    }
                }
                else
                {
                    ConexionBDAdmin objBD = new ConexionBDAdmin();
                    if (objBD.EliminaProducto(TBCodigo.Text))
                    {
                        Articulo miArticulo = new Articulo(TBMarca.Text, TBTalla.Text, TBColor.Text, ImagenFile.PostedFile.FileName, DDLTipo.SelectedItem.Text, int.Parse(TBMonto.Text), TBCodigo.Text);

                        if (objBD.AgregarProducto(miArticulo))
                        {
                            InicializarValores();
                            Lmsj.Text = "El producto se ha modificado satisfactoriamente";

                        }
                    }
                }
            }
        }

        bool ValidarCampos()
        {
            bool valido = true;
        
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

            if (TBCodigo.Text == "")
            {
                Lmsj.Text = "Indique el código";
                valido = false;
            }
            return valido;
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

        private int BuscarIndex(string tipo)
        {
            int index = 0; 
            switch (tipo)
            {
                case "Camisa": index = 1; break;
                case "Pantalón": index = 2; break;
                case "Traje": index = 3; break;
                case "Esmoquin": index = 4; break;
                case "Corbata": index = 5; break;
                case "Accesorio": index = 6; break; 
                
            }
            return index; 
        }

        private void InicializarValores()
        {
            TBCodigo.Enabled = true;
            DDLTipo.SelectedIndex = 0;
            TBMarca.Text = "";
            TBColor.Text = "";
            TBTalla.Text = "";
            TBMonto.Text = "";
            TBCodigo.Text = "";
            Image1.ImageUrl = "";

            DDLTipo.Enabled = false;
            TBMarca.Enabled = false;
            TBColor.Enabled = false;
            TBTalla.Enabled = false;
            TBMonto.Enabled = false;
            Image1.ImageUrl = "";
            ImagenFile.Enabled = false;
        }

       
    }
}