using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tp1_Savino
{
    public class Deposito
    {
        public Zona Zona
        {
            get => default(Zona);
            set
            {
            }
        }

        public Persona Persona
        {
            get => default(Persona);
            set
            {
            }
        }

        public Vehiculo Vehiculo
        {
            get => default(Vehiculo);
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

        public string Nombre
        {
            get => default(string);
            set
            {
            }
        }

        public string Empresa
        {
            get => default(string);
            set
            {
            }
        }

        public string Direccion
        {
            get => default(string);
            set
            {
            }
        }

        public void RevisarPersonal()
        {
            throw new System.NotImplementedException();
        }

        public void RevisarAlmacen(Zona zona)
        {
            throw new System.NotImplementedException();
        }

        public void RevisarVehiculos(Vehiculo tipoVehiculo)
        {
            throw new System.NotImplementedException();
        }

        public void AgregarZona(Zona zona)
        {
            throw new System.NotImplementedException();
        }

        public void NuevoEmpleado()
        {
            throw new System.NotImplementedException();
        }

        public void RealizarTransporte(Almacen alm, int idobjeto, Vehiculo trans)
        {
            throw new System.NotImplementedException();
        }
    }
}