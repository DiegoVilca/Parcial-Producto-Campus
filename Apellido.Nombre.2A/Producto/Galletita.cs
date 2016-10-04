using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.PrimerParcial_2016
{
    public class Galletita : Producto
    {
        protected float _peso;

        //costructor
        public Galletita(int codigo, float precio, EMarcaProducto marca, float peso):base(codigo, marca, precio)
        {
            this._peso = peso;
        }
        //metodo

        public string MostrarGalletita(Galletita galleta)
        {
            StringBuilder sb = new StringBuilder();
            Producto.MostrarProducto(galleta);
            sb.AppendLine("Peso: "+galleta._peso);

            return sb.ToString();

        }



    }
}
