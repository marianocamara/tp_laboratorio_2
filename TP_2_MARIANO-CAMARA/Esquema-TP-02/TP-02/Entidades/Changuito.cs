using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2017
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public class Changuito
    {
        List<Producto> _productos;
        int _espacioDisponible;
        public enum ETipo
        {
            Dulce, Leche, Snacks, Todos
        }

        #region "Constructores"

        /// <summary>
        /// constructor por defecto 
        /// inicializa la lista
        /// </summary>
        private Changuito()
        {
            this._productos = new List<Producto>();
        }
        /// <summary>
        /// sobrecarga constructor por defecto
        /// setea el atribubuto espacioDisponible
        /// </summary>
        /// <param name="espacioDisponible">int espacio</param>
        public Changuito(int espacioDisponible)
            : this()
        {
            this._espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Muestro la concecionaria y TODOS los Productos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar(ETipo.Todos);
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public string Mostrar(ETipo tipo) //quitar static
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", this._productos.Count, this._espacioDisponible);
            sb.AppendLine("");
            foreach (Producto v in this._productos)
            {
               if (v.GetType().Name == tipo.ToString())
                    sb.AppendLine(v.Mostrar());
               else if (tipo == ETipo.Todos)
                    sb.AppendLine(v.Mostrar());
            }

            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="c">Objeto donde se agregará el elemento</param>
        /// <param name="p">Objeto a agregar</param>
        /// <returns></returns>
        public static Changuito operator +(Changuito c, Producto p)
        {
            if (c._espacioDisponible > c._productos.Count())
            {
                foreach (Producto v in c._productos)
                {
                    if (v == p)
                        return c;
                }

                c._productos.Add(p);
            }
            return c;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="c">Objeto donde se quitará el elemento</param>
        /// <param name="p">Objeto a quitar</param>
        /// <returns></returns>
        public static Changuito operator -(Changuito c, Producto p)
        {
            foreach (Producto v in c._productos)
            {
                if (v == p)
                {
                    c._productos.Remove(p);
                    break;
                }
            }

            return c;
        }
        #endregion
    }
}
