using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.PrimerParcial_2016
{
    public class Producto
    {
        protected int _codigoDeBarra;
        protected EMarcaProducto _marca;
        protected float _precio;

        public EMarcaProducto Marca { get { return this._marca;} };
        public float Precio { get{ return this._precio;}}

        //constructor 
  
        public Producto (int codigo, EMarcaProducto marca, float precio)
	    {
            this._codigoDeBarra = codigo;
            this._marca = marca;
            this._precio = precio;
                 
	    }

        //Metodos

        protected static string MostrarProducto(Producto prod)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Marca: "+prod._marca);
            sb.AppendLine("Precio: "+prod._precio);
            sb.AppendLine("Codigo de barra: "+prod._codigoDeBarra);

            return sb.ToString();
        }

        //operadores

        public static bool operator ==(Producto productoUno, Producto productoDos)
        {
            if (productoUno._marca == productoDos._marca && productoUno._codigoDeBarra == productoDos._codigoDeBarra)
	        {
		        return true;
	        }

            return false;
        }

        public static bool operator !=(Producto productoUno, Producto productoDos)
        {
            return !(productoUno==productoDos);
        }

        public static bool operator ==(Producto productoUno, EMarcaProducto marca)
        {
            if (productoUno._marca == marca)
	        {
		        return true;
	        }

            return false;
        }

         public static bool operator !=(Producto productoUno, EMarcaProducto marca)
        {
            return !(productoUno==marca);
        }


        //conversor

        public static explicit operator int(Producto prod)
        {
            return prod._codigoDeBarra;
        }




    }
}
