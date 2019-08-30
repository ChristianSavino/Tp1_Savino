using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tp1_Savino
{
    public class TipoAlmacenamiento
    {

        public Objeto Objeto
        {
            get => default(Objeto);
            set
            {
            }
        }

        public Caracteristicas Tamaño
        {
            get => default(Caracteristicas);
            set
            {
            }
        }

        public int CantUnidades
        {
            get => default(int);
            set
            {
            }
        }

        public int Id
        {
            get => default(int);
            set
            {
            }
        }

        public int Precio
        {
            get => default(int);
            set
            {
            }
        }

        public void AgregaralAlmacen(Almacen alm)
        {
            throw new System.NotImplementedException();
        }

        public void RevisarTipoAlmacen(Almacen alm)
        {
            throw new System.NotImplementedException();
        }

        public void RevisarTipoObjeto(Objeto obj)
        {
            throw new System.NotImplementedException();
        }
    }
}