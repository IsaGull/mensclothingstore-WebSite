using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI; 
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Configuration;
using System.Data;

namespace Arbiter
{
    public class ConexionBDAdmin
    {
        #region Variables

        string cadenaConexion = "Data Source=localhost;Initial Catalog=arbiter;Integrated Security=True";
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader entrada;

        #endregion


        public bool ValidarUsuario(string usuario, string contrasena)
        {
            bool exito = false;
            try
            {
                 conexion = new SqlConnection(cadenaConexion);
                 comando = new SqlCommand("select id from Usuario where usuario = '" + usuario +"' and contrasena = '" + contrasena + "'", conexion);
                 conexion.Open();
                 entrada = comando.ExecuteReader();
                 if (entrada.Read())
                     exito = true;
                 conexion.Close();
            }

            catch { }
            return exito;

        }

        public bool ExisteProducto(string codigo)
        {
            bool exito = false;
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                comando = new SqlCommand("select codigo from producto where codigo = '" + codigo , conexion);
                conexion.Open();
                entrada = comando.ExecuteReader();
                if (entrada.Read())
                    exito = true;
                conexion.Close();
            }
            catch { }
            return exito;
        }

        public bool AgregarProducto(Articulo miArticulo)
        {
             bool exito = false;
            try
            {

            // Sube el archivo a un Stream
            FileStream stream = new FileStream(miArticulo.GSRutaImagen, FileMode.Open, FileAccess.Read);

            //Se inicailiza un flujo de archivo con la imagen seleccionada desde el disco.
            BinaryReader br = new BinaryReader(stream);
            FileInfo fi = new FileInfo(miArticulo.GSRutaImagen);

            //Se prepara el archivo en un arreglo de byte[]
            byte[] imagenPrueba = new byte[stream.Length];

            stream.Read(imagenPrueba, 0, Convert.ToInt32(stream.Length));



            //Insert del registro en la Base de datos.
            string query = "INSERT INTO Producto(marca,talla,color,imagen,tipo,montodolares,codigo) VALUES(@marca,@talla,@color,@imagen,@tipo,@montodolares,@codigo)";

            conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.AddWithValue("@marca", miArticulo.GSMarca);
            cmd.Parameters.AddWithValue("@talla", miArticulo.GSTalla);
            cmd.Parameters.AddWithValue("@color", miArticulo.GSColor);
            cmd.Parameters.AddWithValue("@tipo", miArticulo.GSTipo);
            cmd.Parameters.AddWithValue("@montodolares", miArticulo.GSMonto);
            cmd.Parameters.AddWithValue("@codigo", miArticulo.GSCodigo);
            cmd.Parameters.Add("@imagen", System.Data.SqlDbType.Image).Value = imagenPrueba;

            conexion.Open();
            cmd.ExecuteReader();
            conexion.Close();
            exito = true; 

            }
            catch { }
            return exito;
        }

        public Articulo BuscarProductoCodigo(string codigo)
        {
            Articulo miArticulo = null; 
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                comando = new SqlCommand("select marca,talla,color,imagen,tipo,montodolares from producto where codigo = '" + codigo+"'", conexion);
                conexion.Open();
                entrada = comando.ExecuteReader();
                
                while (entrada.Read())
                {
                    miArticulo = new Articulo(entrada.GetValue(0).ToString(), entrada.GetValue(1).ToString(), entrada.GetValue(2).ToString(), (byte[])entrada.GetValue(3), entrada.GetValue(4).ToString(), Convert.ToInt32(entrada.GetValue(5)));
                    miArticulo.GSCodigo = codigo;                     
                }
                conexion.Close();
            }
            catch
            {
            
            }
            return miArticulo;
        }

        public bool EliminaProducto(string codigo)
        {
            bool exito = false;
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                comando = new SqlCommand("delete from producto where codigo ='" + codigo+"'", conexion);
                conexion.Open();
                entrada = comando.ExecuteReader();
                conexion.Close();
                exito = true;
            }
            catch { }

            return exito;
        }

        public bool ModificarProducto(Articulo miArticulo)
        {
            bool exito = false;
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                comando = new SqlCommand(" update producto set marca = '" + miArticulo.GSMarca + "', talla = '" + miArticulo.GSTalla + "', color = '" + miArticulo.GSColor + "', tipo = '" + miArticulo.GSTipo + "',   montodolares = " + miArticulo.GSMonto + " where codigo = '" + miArticulo.GSCodigo + "'", conexion);
                conexion.Open();
                entrada = comando.ExecuteReader();
                conexion.Close();
                exito = true;
            }
            catch { }

            return exito;
        }


        public DataTable ReporteVentas(string select, string col1, string col2)
        {
            DataTable dtReporte = new DataTable();            
            dtReporte.Columns.Add(col1);
            dtReporte.Columns.Add(col2);
            try
             {
                conexion = new SqlConnection(cadenaConexion);
                comando = new SqlCommand(select, conexion);
                conexion.Open();
                entrada = comando.ExecuteReader();
                
                while (entrada.Read())
                {
                    DataRow dr = dtReporte.NewRow();
                      dr[col1] = entrada.GetValue(0).ToString();
                      dr[col2] = entrada.GetValue(1).ToString();
                      dtReporte.Rows.Add(dr);                                         
                }
                conexion.Close();
            }
            catch
            {
            
            }
            return dtReporte;
        }

        public String BucarMontoGanaciaTotal()
        {
            string monto = "";
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                comando = new SqlCommand("select sum(monto) from cambiomoneda", conexion);
                conexion.Open();
                entrada = comando.ExecuteReader();

                if (entrada.Read())
                {
                    monto = entrada.GetValue(0).ToString();
                }
                conexion.Close();
            }
            catch
            {

            }
            return monto;
        }
    }
}