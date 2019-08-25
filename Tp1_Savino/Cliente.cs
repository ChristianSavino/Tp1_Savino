using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tp1_Savino
{
    public class Cliente
    {
        public Deposito Deposito
        {
            get => default(Deposito);
            set
            {
            }
        }

        public Almacen Almacen
        {
            get => default(Almacen);
            set
            {
            }
        }

        public TipoAlmacenamiento TipoAlmacenamiento
        {
            get => default(TipoAlmacenamiento);
            set
            {
            }
        }

        public Zona Zona
        {
            get => default(Zona);
            set
            {
            }
        }

        public int DNI
        {
            get => default(int);
            set
            {
            }
        }

        public string Nombre
        {
            get => default(string);
            set
            {
            }
        }

        public void GuardarObjeto(TipoAlmacenamiento alm)
        {
            throw new System.NotImplementedException();
        }

        public void SacarObjeto(TipoAlmacenamiento obj, Almacen alm)
        {
            throw new System.NotImplementedException();
        }

        public void RevisarObjetosGuardados()
        {
            throw new System.NotImplementedException();
        }
    }
}