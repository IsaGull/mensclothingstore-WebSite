using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Arbiter
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Lmsj.Text = " ";
        }


        protected void BAceptar_Click(object sender, EventArgs e)
        {
            if ((TBusuario.Text == "") || (TBcontrasena.Text == ""))
            {

            }
            else
            {
                ConexionBDAdmin objBD = new ConexionBDAdmin();
                if (objBD.ValidarUsuario(TBusuario.Text, TBcontrasena.Text))
                {
                   // Lmsj.Text = "existe";
                    Response.Redirect("InicioAdmin.aspx");
                }
                else
                {
                    Lmsj.Text = "Usuario o Contraseña incorrecta";
                }


            }
        }










    }
}