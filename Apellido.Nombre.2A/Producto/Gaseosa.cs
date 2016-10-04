using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gaseosa :Producto
    {
        protected float _litros;

        //constuctor

        public Gaseosa(int codigo, float precio, EMarcaProducto marca, float litros) :base(codigo, marca, precio)
        {
            this._litros = litros;
        }

        public Gaseosa(Producto producto, float litros) :this(, producto.Precio, producto.Marca, litros)
        {

        }
        //metodo

        public string MostrarGaseosa()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine("Litros: ");

            return sb.ToString();
        }
    }
}
