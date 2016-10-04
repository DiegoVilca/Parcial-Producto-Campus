using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugo :Producto
    {
        protected ESaborJugo _sabor;

        //constructor
        public Jugo(int codigo, float precio, EMarcaProducto marca, ESaborJugo sabor) :base(codigo, marca, precio)
        {
            this._sabor = sabor;
        }

        //Metodo
        public string MostrarJugo()
        {
            StringBuilder sb = new StringBuilder();
            
           sb.AppendLine("Sabor: "+this._sabor);
            
           return sb.ToString();
        }

        
        

    }
}
