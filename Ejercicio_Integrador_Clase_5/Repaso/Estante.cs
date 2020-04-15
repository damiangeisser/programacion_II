using Ejercicio_Integrador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;
        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];

            for (int i = 0; i < productos.Length; i++)
            {
                productos[i] = new Producto("", "", 0);
            }
        }
        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }
        public Producto[] GetProductos()
        {
            return this.productos;
        }
        public static string MostrarEstante(Estante e)
        {
            StringBuilder contenidoEstante = new StringBuilder();

            contenidoEstante.Append("\nEl estante posee capacidad para " + e.productos.Length.ToString() + " productos.\n");
            contenidoEstante.Append("Los productos en stock son:\n\n");

            foreach (var producto in e.productos)
            {
               contenidoEstante.Append(Producto.MostrarProducto(producto));
            }

            return contenidoEstante.ToString();
        }
        public static bool operator ==(Estante e, Producto p)
        {
            bool isMatch = false;

            foreach (var producto in e.productos)
            {
                if((string)producto == (string)p)
                {
                    isMatch = true;
                    break;
                }
            }

            return isMatch;
        }
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e==p);
        }
        public static bool operator +(Estante e, Producto p)
        {
            bool inStock;
            bool reStock = false;

            inStock = e == p;

            if (!inStock)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if ((string)e.productos[i] == "")
                    {
                        e.productos[i] = p;

                        reStock = true;

                        break;
                    }
                }
            }

            return reStock;
        }
        public static Estante operator -(Estante e, Producto p)
        {
            bool inStock;

            inStock = e == p;

            if (inStock)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if ((string)e.productos[i] == (string)p)
                    {
                        e.productos[i] = new Producto("","",0);

                        break;
                    }
                }
            }

            return e;
        }
    }
}
