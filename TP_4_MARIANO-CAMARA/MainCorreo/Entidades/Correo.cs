using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>>
    {
        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;

        #region Constructores
        /// <summary>
        /// Constructor Correo
        /// </summary>
        public Correo()
        {
            mockPaquetes = new List<Thread>();
            paquetes = new List<Paquete>();
        }
        #endregion

        #region Propiedades
        
        public List<Paquete> Paquetes
        {
            get { return this.paquetes; }
            set { this.paquetes = value; }
        }
        #endregion

        #region Operadores
        /// <summary>
        /// add de paquete en lista de Correo, error si est repetido
        /// crea un hilo para el paquete, lo agrega a la lista de hilos y lo inicia  
        /// </summary>
        /// <param name="c">correo</param>
        /// <param name="p">paquete a agregar</param>
        /// <returns>Correo con paqeuete</returns>
        public static Correo operator +(Correo c, Paquete p)
        {
            foreach (Paquete paquete in c.Paquetes)
            {
                if (paquete == p)
                {
                    throw new TrackingRepetidoException("El paquete esta repetido");
                }
            }
            //agrego paquete
            c.Paquetes.Add(p);
            
            //hilo
            Thread hiloA = new Thread(p.MockCicloDeVida);
            c.mockPaquetes.Add(hiloA);
            hiloA.Start();

            return c;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// recorre la lista de hilos, matando los hilos que aun estan corriendo
        /// </summary>
        public void FinEntregas()
        {
            foreach (Thread h in this.mockPaquetes)
            {
                if (h.IsAlive)
                {
                    h.Abort();
                }
            }
        }

        /// <summary>
        /// muestra la info de una lista de paquetesdel Correo
        /// </summary>
        /// <param name="elementos">lista</param>
        /// <returns>string con datos</returns>
        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            string retorno="";

            if ((Correo)elementos is Correo)
            {
                StringBuilder sb = new StringBuilder();
                foreach (Paquete p in ((Correo)elementos).Paquetes)
                {
                    sb.AppendFormat("{0} para {1} ({2})", p.TrackingID, p.DireccionEntrega, p.Estado.ToString());
                    sb.AppendLine();
                }
                retorno = sb.ToString();
            }
            return retorno;
        }
        #endregion

    }
}
