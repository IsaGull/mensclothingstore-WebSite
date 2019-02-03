using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Data;
using System.IO;


namespace Arbiter.ArticulosDelCatalogo
{
    public partial class Esmoquin : System.Web.UI.Page
    {   
         int a = 1;
         int i = 0;
         int quedan = 0;
         List<Articulo> Elemento = new List<Articulo>();
         SingletonEsmoquin Elemento2 = SingletonEsmoquin.Instance;
    
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            
                // ****************************************  Prueba Lograda. Carga imagen desde el proyecto en la carpeta images (img01.jpg) *************************

                /* Image imagenPrueba = new Image();
                 imagenPrueba.ImageUrl = "/images/img01.jpg";

                 Articulo prueba = new Articulo("Hollister", "XL", "Rojo", imagenPrueba, "Camisa", 100);

                 Image1.ImageUrl = prueba.GSImagen.ImageUrl;
            
          
                 Literal1.Text = prueba.GSColor;
                  *************************************************************************************************/



                /********************************** INSERTAR REGISTRO CON IMAGEN *************************
                           string cadenaConexion = "Data Source=localhost;Initial Catalog=arbiter;Integrated Security=True";
                           SqlConnection conn = new SqlConnection(cadenaConexion);
           
                           // Sube el archivo a un Stream
                            FileStream stream = new FileStream("/Users/UnaAhí/Documents/Visual Studio 2010/Projects/Arbiter/Arbiter/images/turquesa.jpg", FileMode.Open, FileAccess.Read);
            
                            //Se inicailiza un flujo de archivo con la imagen seleccionada desde el disco.
                            BinaryReader br = new BinaryReader(stream);
                            FileInfo fi = new FileInfo("/Users/UnaAhí/Documents/Visual Studio 2010/Projects/Arbiter/Arbiter/images/turquesa.jpg");

                            //Se prepara el archivo en un arreglo de byte[]
                            byte[] imagenPrueba = new byte[stream.Length];
            
                            stream.Read(imagenPrueba, 0, Convert.ToInt32(stream.Length));


                            //Insert del registro en la Base de datos.
                            string query = "INSERT INTO Producto(marca,talla,color,imagen,tipo,montodolares) VALUES(@marca,@talla,@color,@imagen,@tipo,@montodolares)";

                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@marca", "Zara");
                            cmd.Parameters.AddWithValue("@talla", "S");
                            cmd.Parameters.AddWithValue("@color", "turquesa");
                            cmd.Parameters.AddWithValue("@tipo", "Smoking");
                            cmd.Parameters.AddWithValue("@montodolares", "90");
                            cmd.Parameters.Add("@imagen", System.Data.SqlDbType.Image).Value = imagenPrueba;

                            conn.Open();
                            cmd.ExecuteReader();
                            conn.Close();

                /********************************** TERMINA EL REGISTRO CON IMAGEN **************************/



                /********************************** SELECCION Y MUESTRA DE LAS IMAGENES (6) CON LOS DATOS DE LA BD ****************/


                int i;
                i = 0;
                string cadenaConexion2 = "Data Source=localhost;Initial Catalog=arbiter;Integrated Security=True";
                SqlConnection conn2 = new SqlConnection(cadenaConexion2);
                SqlCommand query2 = new SqlCommand("select marca,talla,color,imagen,tipo,montodolares from Producto where tipo = 'Esmoquin'", conn2);
                conn2.Open();
                SqlDataReader entrada = query2.ExecuteReader();
                Elemento2.GSquedan.Clear();


                while (entrada.Read())
                {

                    Articulo prueba = new Articulo(entrada.GetValue(0).ToString(), entrada.GetValue(1).ToString(), entrada.GetValue(2).ToString(), (byte[])entrada.GetValue(3), entrada.GetValue(4).ToString(), Convert.ToInt32(entrada.GetValue(5)));

                    Elemento2.GSquedan.Add(prueba);

                }

                conn2.Close();



                // Cargar solo los primeros 6, eliminarlos de la lista y mostrarlos en los cuadros...


                foreach (Articulo articulo in Elemento2.GSquedan)
                {
                    Elemento.Add(articulo);

                    if (a == 6)
                    {
                        break;
                    }
                    a++;
                }

                Elemento2.GSquedan.RemoveRange(0, 6);  // Elimina los primeros 6 de la lista

                foreach (Articulo t in Elemento)
                {

                    using (MemoryStream ms = new MemoryStream(t.Imagen, 0, t.Imagen.Length))
                    {

                        ms.Write(t.Imagen, 0, t.Imagen.Length);


                        i++;

                        if (i == 1)
                        {
                            Image1.ImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(ms.ToArray(), 0, ms.ToArray().Length);
                            Literal1.Text = " <b> Marca: </b> " + t.GSMarca;
                            Literal2.Text = " <b> Talla: </b> " + t.GSTalla;
                            Literal3.Visible = false;
                            
                        }

                        if (i == 2)
                        {
                            Image2.ImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(ms.ToArray(), 0, ms.ToArray().Length);
                            Literal4.Text = " <b> Marca: </b> " + t.GSMarca;
                            Literal5.Text = " <b> Talla: </b> " + t.GSTalla;
                            Literal6.Visible = false;
                        }

                        if (i == 3)
                        {
                            Image3.ImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(ms.ToArray(), 0, ms.ToArray().Length);
                            Literal7.Text = " <b> Marca: </b> " + t.GSMarca;
                            Literal8.Text = " <b> Talla: </b> " + t.GSTalla;
                            Literal9.Visible = false;
                        }

                        if (i == 4)
                        {
                            Image4.ImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(ms.ToArray(), 0, ms.ToArray().Length);
                            Literal10.Text = " <b> Marca: </b> " + t.GSMarca;
                            Literal11.Text = " <b> Talla: </b> " + t.GSTalla;
                            Literal12.Visible = false;
                        }

                        if (i == 5)
                        {
                            Image5.ImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(ms.ToArray(), 0, ms.ToArray().Length);
                            Literal13.Text = " <b> Marca: </b> " + t.GSMarca;
                            Literal14.Text = " <b> Talla: </b> " + t.GSTalla;
                            Literal15.Visible = false;
                        }

                        if (i == 6)
                        {
                            Image6.ImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(ms.ToArray(), 0, ms.ToArray().Length);
                            Literal16.Text = " <b> Marca: </b> " + t.GSMarca;
                            Literal17.Text = " <b> Talla: </b> " + t.GSTalla;
                            Literal18.Visible = false;
                        }


                    }


                }

            }
           
        }

        protected void Button1_Click(object sender, EventArgs e) // Boton de pasar pagina
        {

            if (Elemento2.GSquedan.Count() >= 6)
            {

                Elemento.Clear();
                i = 0;


                foreach (Articulo articulo in Elemento2.GSquedan)
                {
                    Elemento.Add(articulo);

                    if (a == 6)
                    {
                        break;
                    }
                    a++;
                }

                a = 1;

                Elemento2.GSquedan.RemoveRange(0, 6);

                foreach (Articulo t in Elemento)
                {

                    using (MemoryStream ms = new MemoryStream(t.Imagen, 0, t.Imagen.Length))
                    {

                        ms.Write(t.Imagen, 0, t.Imagen.Length);


                        i++;

                        if (i == 1)
                        {
                            Image1.ImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(ms.ToArray(), 0, ms.ToArray().Length);
                            Literal1.Text = " <b> Marca: </b> " + t.GSMarca;
                            Literal2.Text = " <b> Talla: </b> " + t.GSTalla;
                            Literal3.Visible = false;

                        }

                        if (i == 2)
                        {
                            Image2.ImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(ms.ToArray(), 0, ms.ToArray().Length);
                            Literal4.Text = " <b> Marca: </b> " + t.GSMarca;
                            Literal5.Text = " <b> Talla: </b> " + t.GSTalla;
                            Literal6.Visible = false;
                        }

                        if (i == 3)
                        {
                            Image3.ImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(ms.ToArray(), 0, ms.ToArray().Length);
                            Literal7.Text = " <b> Marca: </b> " + t.GSMarca;
                            Literal8.Text = " <b> Talla: </b> " + t.GSTalla;
                            Literal9.Visible = false;
                        }

                        if (i == 4)
                        {
                            Image4.ImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(ms.ToArray(), 0, ms.ToArray().Length);
                            Literal10.Text = " <b> Marca: </b> " + t.GSMarca;
                            Literal11.Text = " <b> Talla: </b> " + t.GSTalla;
                            Literal12.Visible = false;
                        }

                        if (i == 5)
                        {
                            Image5.ImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(ms.ToArray(), 0, ms.ToArray().Length);
                            Literal13.Text = " <b> Marca: </b> " + t.GSMarca;
                            Literal14.Text = " <b> Talla: </b> " + t.GSTalla;
                            Literal15.Visible = false;
                        }

                        if (i == 6)
                        {
                            Image6.ImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(ms.ToArray(), 0, ms.ToArray().Length);
                            Literal16.Text = " <b> Marca: </b> " + t.GSMarca;
                            Literal17.Text = " <b> Talla: </b> " + t.GSTalla;
                            Literal18.Visible = false;
                        }


                    }

                }

                Elemento.Clear();

            }






            else // Entra solo cuando quedan menos de 6 imagenes en la lista.
            {
                i = 0;

                foreach (Articulo articulo in Elemento2.GSquedan)  // Paso los elementos de la lista grande a la temporal.
                {
                    Elemento.Add(articulo);
                }

                foreach (Articulo t in Elemento)
                {

                    using (MemoryStream ms = new MemoryStream(t.Imagen, 0, t.Imagen.Length))
                    {

                        ms.Write(t.Imagen, 0, t.Imagen.Length);


                        i++;

                        if (i == 1)
                        {
                            Image1.ImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(ms.ToArray(), 0, ms.ToArray().Length);
                            Literal1.Text = " <b> Marca: </b> " + t.GSMarca;
                            Literal2.Text = " <b> Talla: </b> " + t.GSTalla;
                            Literal3.Visible = false;

                        }

                        if (i == 2)
                        {
                            Image2.ImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(ms.ToArray(), 0, ms.ToArray().Length);
                            Literal4.Text = " <b> Marca: </b> " + t.GSMarca;
                            Literal5.Text = " <b> Talla: </b> " + t.GSTalla;
                            Literal6.Visible = false;
                        }

                        if (i == 3)
                        {
                            Image3.ImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(ms.ToArray(), 0, ms.ToArray().Length);
                            Literal7.Text = " <b> Marca: </b> " + t.GSMarca;
                            Literal8.Text = " <b> Talla: </b> " + t.GSTalla;
                            Literal9.Visible = false;
                        }

                        if (i == 4)
                        {
                            Image4.ImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(ms.ToArray(), 0, ms.ToArray().Length);
                            Literal10.Text = " <b> Marca: </b> " + t.GSMarca;
                            Literal11.Text = " <b> Talla: </b> " + t.GSTalla;
                            Literal12.Visible = false;
                        }

                        if (i == 5)
                        {
                            Image5.ImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(ms.ToArray(), 0, ms.ToArray().Length);
                            Literal13.Text = " <b> Marca: </b> " + t.GSMarca;
                            Literal14.Text = " <b> Talla: </b> " + t.GSTalla;
                            Literal15.Visible = false;
                        }

                        if (i == 6)
                        {
                            Image6.ImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(ms.ToArray(), 0, ms.ToArray().Length);
                            Literal16.Text = " <b> Marca: </b> " + t.GSMarca;
                            Literal17.Text = " <b> Talla: </b> " + t.GSTalla;
                            Literal18.Visible = false;
                        }

                    }

                }

                int imagen = 0 + Elemento2.GSquedan.Count;

                while (imagen < 6)
                {
                    imagen++;

                    if (imagen == 6)
                    {
                        Image6.ImageUrl = "/images/corbata.jpg";
                        Literal16.Visible = false;
                        Literal17.Visible = false;
                        Literal18.Visible = false;
                    }

                    if (imagen == 5)
                    {
                        Image5.ImageUrl = "/images/corbata.jpg";
                        Literal13.Visible = false;
                        Literal14.Visible = false;
                        Literal15.Visible = false;
                    }

                    if (imagen == 4)
                    {
                        Image4.ImageUrl = "/images/corbata.jpg";
                        Literal10.Visible = false;
                        Literal11.Visible = false;
                        Literal12.Visible = false;
                    }

                    if (imagen == 3)
                    {
                        Image3.ImageUrl = "/images/corbata.jpg";
                        Literal7.Visible = false;
                        Literal8.Visible = false;
                        Literal9.Visible = false;
                    }

                    if (imagen == 2)
                    {
                        Image2.ImageUrl = "/images/corbata.jpg";
                        Literal4.Visible=false;
                        Literal5.Visible=false;
                        Literal6.Visible=false;
                    }

                    if (imagen == 1)
                    {
                        Image1.ImageUrl = "/images/corbata.jpg";
                        Literal1.Visible=false;
                        Literal2.Visible=false;
                        Literal3.Visible=false;
                    }


                }
                Button1.Visible = false;
                Elemento2.GSquedan.Clear();

            }


        }

       
   } 
}