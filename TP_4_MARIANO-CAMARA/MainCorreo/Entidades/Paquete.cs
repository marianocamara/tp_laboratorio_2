using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    /// <summary>
    /// Posibles estados de un paquete
    /// </summary>
    public enum EEstado
    {
        Ingresado,
        EnViaje,
        Entregado
    }

    public class Paquete : IMostrar<Paquete>
    {
      
        public delegate void DelegadoEstado(object sender, EventArgs e); 
        public event DelegadoEstado InformaEstado;
        

        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;

        #region Constructores
        /// <summary>
        /// Constructor de un Paquete
        /// </summary>
        /// <param name="direccionEntrega"></param>
        /// <param name="trackingID">ID unico</param>
        public Paquete(string direccionEntrega, string trackingID)
        {
            this.direccionEntrega = direccionEntrega;
            this.trackingID = trackingID;
            this.estado = EEstado.Ingresado;
        }
        #endregion

        #region Propiedades

        public string DireccionEntrega
        {
            get { return this.direccionEntrega; }
            set { this.direccionEntrega = value; }
        }

        public EEstado Estado
        {
            get { return this.estado; }
            set { this.estado = value; }
        }

        public string TrackingID
        {
            get { return this.trackingID; }
            set { this.trackingID = value; }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Muestra la informacion de un paquete
        /// </summary>
        /// <param name="elemento">paquete</param>
        /// <returns>string con datos</returns>
        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            return String.Format("{0} para {1}", ((Paquete)elemento).TrackingID, ((Paquete)elemento).DireccionEntrega);
        }

        /// <summary>
        /// Ciclo de vid de un paquete
        /// Cambia e informa el estado
        /// Guarda un paquete en la base de datos
        /// </summary>
        public void MockCicloDeVida()
        {
            do
            {
                Thread.Sleep(5000);
                if (this.Estado == EEstado.Ingresado)
                    this.Estado = EEstado.EnViaje;
                else
                    this.Estado = EEstado.Entregado;
   
               InformaEstado(this, new EventArgs());

            } while (Estado != EEstado.Entregado);
            
            //guardo en base de datos
            this.GuardarDB();   
        }


        #endregion

        #region Operadores 
        /// <summary>
        /// Override ToString, muestra la info de un paquete
        /// </summary>
        /// <returns>string con datos</returns>
        public override string ToString()
        {
            return MostrarDatos(this);
        }

        /// <summary>
        /// Sobreescritura operador ==
        /// Dos paquetes son iguales si tienen el mismo Tracking ID
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns>true si son iguales</returns>
        public static bool operator ==(Paquete p1, Paquete p2)
        {
            bool retorno=false;
            if (!(ReferenceEquals(p1, null) || ReferenceEquals(p2, null)))
            {
                if (p1.TrackingID == p2.TrackingID)
                    retorno = true;
            }

            return retorno;
        }
        /// <summary>
        /// Sobreescritura operador !=
        /// Dos paquetes son diferentes si tienen diferente Tracking ID
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns>true si son diferentes</returns>
        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Paquete))
                return false;
            return this == (Paquete)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        #region Base de datos
        /// <summary>
        /// Inserta un paquete en la base de datos
        /// </summary>
        /// <returns>true si todo OK</returns>
        public bool GuardarDB()
        {
            return PaqueteDAO.Insertar(this);
        }
        #endregion

    }
}
