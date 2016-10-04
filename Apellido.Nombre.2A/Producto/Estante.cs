using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Estante
    {
        protected sbyte _capacidad;
        protected List<Producto> _productos;

        public float ValorEstanteTotal { get { return ;} }

        //constructores

        private Estante()
        {
            _productos = new List<Producto>();
        }

        public Estante(sbyte capacidad) :this()
        {
            this._capacidad = capacidad;
        }

        //metodos

        public List<Producto> GetProductos()
        {
            return this._productos;
        }

        private float GetValorEstante()
        { 
        }

        public float GetValorEstante(ETipoProducto tipo)
        {
            float suma;

            foreach (Producto item in this._productos)
            {
                if (item.GetType() == typeof8)
                {
                    
                }
            }
        }

        //operadores

        public static bool operator ==(Estante est, Producto prod)
        {
            foreach (Producto item in est._productos)
            {
                if (item == prod)
                {
                    return true;
                }
            }

            return false;
        }


        public static bool operator !=(Estante est, Producto prod)
        {
            return !(est == prod);
        }


        public static bool operator +(Estante est, Producto prod)
        {
            if (est._productos.Count<5 && est!=prod)
            {
                return true;
            }

            return false;
        }


        public static Estante operator -(Estante est, Producto prod)
        {
            for (int i = 0; i < est._productos.Count; i++)
            {
                if (est == prod)
                {
                    est._productos[i] = null;

                    return est;
                }
            }

            return est;
        }



        public static Estante operator -(Estante est, ETipoProducto tipo)
        {
            switch (tipo)
            {
                case ETipoProducto.Galletita:
                    for (int i = 0; i < est._productos.Count; i++)
                    {
                        if (est is Galletita)
                        {
                            est._productos[i] = null;
                        }
                    }
                    break;
                case ETipoProducto.Gaseosa:
                    for (int i = 0; i < est._productos.Count; i++)
                    {
                        if (est is Gaseosa)
                        {
                            est._productos[i] = null;
                        }
                    }
                    break;
                case ETipoProducto.Jugo:
                    for (int i = 0; i < est._productos.Count; i++)
                    {
                        if (est is Jugo)
                        {
                            est._productos[i] = null;
                        }
                    }
                    break;
                case ETipoProducto.Todos:
                    for (int i = 0; i < est._productos.Count; i++)
                    {
                        est._productos[i] = null;
                    }
                    break;
                    
                
            }

            return est;
        }









    }
}
