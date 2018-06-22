using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TrackingRepetidoException : Exception
    {
            public TrackingRepetidoException(string mensaje, Exception innerException)
                : base(mensaje, innerException)
            {
            }

            public TrackingRepetidoException(string mensaje)
                : this(mensaje, null)
            {
            }        
    }
}
