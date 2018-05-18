using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades_2017
{
    public class Leche : Producto
    {
        public enum ETipo { Entera, Descremada }
        ETipo _tipo;

        #region "Constructores"

        /// <summary>
        /// Constructor
        /// Por defecto, TIPO será ENTERA
        /// </summary>
        /// <param name="marca">marca</param>
        /// <param name="patente">codigo</param>
        /// <param name="color">color</param>
        public Leche(EMarca marca, string codigo, ConsoleColor color)
            : base(marca, codigo, color)
        {
            _tipo = ETipo.Entera;
        }

        /// <summary>
        /// Sobrecarga costructor con opcion de tipo
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="codigo"></param>
        /// <param name="color"></param>
        /// <param name="tipo"></param>
        public Leche(EMarca marca, string codigo, ConsoleColor color, ETipo tipo)
            : base(marca, codigo, color)
        {
            _tipo = tipo;
        }

        #endregion

        #region "Propiedades"
        /// <summary>
        /// Las leches tienen 20 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 20;
            }
        }
        #endregion

        #region "Sobrecargas"

        /// <summary>
        /// imprime los datos del producto
        /// </summary>
        /// <returns>string con datos</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LECHE");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("CALORIAS : {0}", this.CantidadCalorias);
            sb.AppendLine("TIPO : " + this._tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion
    }
}
