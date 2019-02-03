using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;

namespace Arbiter
{
    public partial class Contactenos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Visible = false;
            Label2.Text = "";
        }


        protected void Button1_Click(object sender, EventArgs e)
       {
            
            MailMessage mail = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            

                var eMailSubject = TextBox2.Text;
                if (eMailSubject == null)
                {
                    eMailSubject = "Asunto vacío";
                }
                var eMailMessage = TextBox1.Text;
                if (eMailMessage == null)
                {
                    eMailMessage = "Mensaje vacío";
                }

                try
                {
                    mail.From = new MailAddress("gcadamob@gmail.com"); // De quien
                    mail.To.Add("isabelgull90@gmail.com"); // Para quien
                    mail.Subject = eMailSubject; // Titulo
                    mail.Body = eMailMessage;    // Mensaje
                    mail.IsBodyHtml = false;
                    smtp.Host = "smtp.gmail.com";
                   
                    smtp.UseDefaultCredentials = false;
                    smtp.Port = 587;
                    smtp.Credentials = new NetworkCredential("gcadamob@gmail.com", "Xjch12cd");
                    
                    smtp.EnableSsl = true;
                    
                    smtp.Send(mail);
                    Label2.Visible = true;
                    Label2.Text = "Mensaje Enviado Correctamente";

                }

                catch(Exception ex)
                {
                    Label2.Visible = true;
                    Label2.Text = "No se ha podido enviar el mensaje. Intente nuevamente.";
                
                }
            

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            Label2.Visible = false;
            Label2.Text = "";
        }
    }
}