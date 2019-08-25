using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tp1_Savino
{
    public class Almacen : Zona
    {

        public Operario Operario
        {
            get => default(Operario);
            set
            {
            }
        }

        public int ID
        {
            get => default(int);
            set
            {
            }
        }

        public void Inventario()
        {
            throw new System.NotImplementedException();
        }
    }
}