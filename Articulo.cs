using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Arbiter
{
    public class Articulo
    {

        string marca;
        string talla;
        string color;
        public byte[] Imagen { get; set; }
        string tipo;
        int monto;
        string codigo;
        string rutaImagen;


        public Articulo()
        { }

        public Articulo(string marcaDB, string tallaDB, string colorDB, byte[] imagenDB, string tipoDB, int montoDB)
        {

            this.marca = marcaDB;
            this.talla = tallaDB;
            this.color = colorDB;
            this.Imagen = imagenDB;
            this.tipo = tipoDB;
            this.monto = montoDB;

        }

        public Articulo(string marca, string talla, string color, string rutaImagen, string tipo, int monto, string codigo)
        {

            this.marca = marca;
            this.talla = talla;
            this.color = color;
            this.rutaImagen = rutaImagen;
            this.tipo = tipo;
            this.monto = monto;
            this.codigo = codigo; 

        }

        public string GSMarca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string GSTalla
        {
            get { return talla; }
            set { talla = value; }
        }

        public string GSColor
        {
            get { return color; }
            set { color = value; }
        }
        
        public string GSTipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        
        public int GSMonto
        {
            get { return monto; }
            set { monto = value; }
        }

        public string GSCodigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string GSRutaImagen
        {
            get { return rutaImagen; }
            set { rutaImagen = value; }
        }
    }
}