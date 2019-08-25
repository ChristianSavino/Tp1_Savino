using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tp1_Savino
{
    public class Almacenero : Operario
    {
        public Autoelevador Autoelevador
        {
            get => default(Autoelevador);
            set
            {
            }
        }

        public Grua Grua
        {
            get => default(Grua);
            set
            {
            }
        }
    }
}