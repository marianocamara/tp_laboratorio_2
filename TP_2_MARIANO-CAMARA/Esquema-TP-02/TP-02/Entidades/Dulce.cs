using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2017
{
    public class Dulce : Producto
    {
        #region "Constructores"
        /// <summary>
        /// constructor 
        /// </summary>
        /// <param name="marca">marca</param>
        /// <param name="codigo">codigo</param>
        /// <param name="color">color</param>
        public Dulce(EMarca marca, string codigo, ConsoleColor color)
            : base(marca, codigo, color)
        {
        }
        #endregion

        #region "Propiedades"
        /// <summary>
        /// Los dulces tienen 80 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 80;
            }
        }
        #endregion 

        #region "Metodos"
        /// <summary>
        /// muestra los datos del producto
        /// </summary>
        /// <returns>string con datos</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DULCE");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("CALORIAS : {0}", this.CantidadCalorias);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion
    }
}
