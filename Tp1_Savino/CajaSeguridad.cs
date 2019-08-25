using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tp1_Savino
{
    public class CajaSeguridad : Caja
    {
        public int CodigoSeguridad
        {
            get => default(int);
            set
            {
            }
        }

        public void EstablecerCodigoSeguridad()
        {
            throw new System.NotImplementedException();
        }

        public void CambiarCodigoSeguridad()
        {
            throw new System.NotImplementedException();
        }
    }
}