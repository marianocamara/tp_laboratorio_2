using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Entidades;

namespace MainCorreo
{
    public partial class FrmPpal : Form
    {

        public Correo correo;

        public FrmPpal()
        {
            InitializeComponent();
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {
            correo = new Correo();
        }
        /// <summary>
        /// Agrega un paquete y comienza su ciclo de vida
        /// error si el paquete ya esta en la lista
        /// agrega a base de datos el paquete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(BoxTrackingID.Text) && !String.IsNullOrEmpty(BoxDireccion.Text))
            {
                Paquete paquete = new Paquete(BoxDireccion.Text, BoxTrackingID.Text);
                paquete.InformaEstado += paq_InformaEstado;
                try
                {
                    correo += paquete;
                    ActualizarEstados();
                }
                catch (TrackingRepetidoException ex)
                {
                    MessageBox.Show(String.Format("El paquete con tracking ID {0} ya se encuentra en la lista de envios", paquete.TrackingID), ex.Message);
                }
            }
        }

        #region Metodos
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void paq_InformaEstado(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(paq_InformaEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                ActualizarEstados();
            }
        }
        /// <summary>
        /// cambia el estado de un paquete al que corresponda
        /// </summary>
        private void ActualizarEstados()
        {
            listBoxIngresado.Items.Clear();
            listBoxEnViaje.Items.Clear();
            listBoxEntregado.Items.Clear();
            
            foreach (Paquete p in correo.Paquetes)
            {
                switch (p.Estado)
                {
                    case Entidades.EEstado.Ingresado:
                        listBoxIngresado.Items.Add(p);
                        break;
                    case Entidades.EEstado.EnViaje:
                        listBoxEnViaje.Items.Add(p);
                        break;
                    case Entidades.EEstado.Entregado:
                        listBoxEntregado.Items.Add(p);
                        break;
                }
            }
        }
        /// <summary>
        /// Muestra la informacion de un paquete o una lista de paquetes
        /// Guarda la inforamcion en un archivo
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="elemento"></param>
        private void MostrarInformacion<T>(IMostrar<T> elemento)                                          
        {
            if (elemento != null)
            {
                if (elemento is Correo || elemento is Paquete)
                {
                    string info = elemento.MostrarDatos(elemento);
                    TxtBoxMostrar.Text = info;
                    //ruta de archivo
                    string desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                    string fullFileName = Path.Combine(desktopFolder, "salida.txt");
                    //guardo archivo
                    info.Guardar(fullFileName);
                }
               /* 
               if (elemento is Correo){
                   string info = elemento.MostrarDatos(elemento);
                   TxtBoxMostrar.Text = info;
                   //info.Guardar("salida.txt");
               }   
               else if (elemento is Paquete)
               {
                   string info = elemento.MostrarDatos(elemento);
                   TxtBoxMostrar.Text = info;
                   //info.Guardar("salida.txt");
               }
                */
                              
            }
        }

        #endregion
        /// <summary>
        /// boton muestra la informacion de lista de paquetes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
        }
        /// <summary>
        /// boton click derecho sobre paquete muestra su informacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)listBoxEntregado.SelectedItem);
        }
        /// <summary>
        /// mata los hilos que estan corriendo al cerrar el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            correo.FinEntregas();
        }
    }
}
