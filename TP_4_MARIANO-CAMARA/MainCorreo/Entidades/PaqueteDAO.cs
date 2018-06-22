using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    class PaqueteDAO
    {
        
        private static SqlConnection _conexion;
        private static SqlCommand _comando;
        private static string connectionStr = Properties.Settings.Default.connectionStr;
        

        #region Constructores
        /// <summary>
        /// Establezo conexion con la base de datos
        /// </summary>
        static PaqueteDAO()
        {
            // CREO UN OBJETO SQLCONECTION
            PaqueteDAO._conexion = new SqlConnection(connectionStr); //"Data Source=lab3pc14\\sqlexpress;Initial Catalog=correo-sp-2017;Integrated Security=True"
            // CREO UN OBJETO SQLCOMMAND"
            PaqueteDAO._comando = new SqlCommand();
            // INDICO EL TIPO DE COMANDO
            PaqueteDAO._comando.CommandType = System.Data.CommandType.Text;
            // ESTABLEZCO LA CONEXION
            PaqueteDAO._comando.Connection = PaqueteDAO._conexion;
        }
        #endregion


        #region Métodos

       /// <summary>
       /// Inserta un paquete en la base de datos
       /// </summary>
       /// <param name="p">paquete a insertar</param>
       /// <returns>true si todo ok</returns>
        public static bool Insertar(Paquete p)
        {
            string sql = "INSERT INTO Paquetes (direccionEntrega,trackingID,alumno) VALUES(";
            sql = sql + "'" + p.DireccionEntrega + "','" + p.TrackingID + "','" + "Mariano Camara" + "')";
            return EjecutarNonQuery(sql);
        }
        

        /// <summary>
        /// Ejecuto la orden y cierro la conexion 
        /// </summary>
        /// <param name="sql">orden</param>
        /// <returns>true si todo OK</returns>
        private static bool EjecutarNonQuery(string sql)
        {
            bool todoOk = false;
            try
            {
                // LE PASO LA INSTRUCCION SQL
                PaqueteDAO._comando.CommandText = sql;

                // ABRO LA CONEXION A LA BD
                PaqueteDAO._conexion.Open();

                // EJECUTO EL COMMAND
                PaqueteDAO._comando.ExecuteNonQuery();

                todoOk = true;
            }
            catch (Exception e)
            {
                todoOk = false;
                //throw e;
            }
            finally
            {
                if (todoOk)
                    PaqueteDAO._conexion.Close();
            }
            return todoOk;
        }
        #endregion

    }
}
