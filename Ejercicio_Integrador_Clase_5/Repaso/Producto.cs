using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Integrador
{
    public class Producto
    {
        private string codigoDeBarras;
        private string marca;
        private float precio;
        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarras = codigo;
            this.precio = precio;
        }
        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }
        public static string MostrarProducto(Producto p)
        {
            return "Marca: " + p.marca + "\nCódigo: " + p.codigoDeBarras + "\nPrecio: $" + p.precio.ToString() + "\n\n";
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarras;
        }
        public static bool operator ==(Producto p, string marca)
        {
            bool isMatch = false;

            if(p.marca == marca)
            {
                isMatch = true;
            }

            return isMatch;
        }
        public static bool operator !=(Producto p, string marca)
        {
            return !(p==marca);
        }
        public static bool operator ==(Producto p1, Producto p2)
        {
            bool isMatch = false;

            if (p1.codigoDeBarras == p2.codigoDeBarras)
            {
                isMatch = true;
            }

            return isMatch;
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

    }
}
