using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticoII
{
    internal class Detalle
    {
        private int cantidadDias;
        private DateTime fechaRetiro;
        private Vehiculo vehiculos;
        public Detalle(int cantidadDias, Vehiculo vehiculos, int anio, int mes, int dia)
        {
            this.cantidadDias = cantidadDias;
            this.fechaRetiro = new DateTime(anio, mes, dia);
            this.vehiculos = vehiculos;
        }
        public int getCantidadDeDias() { return cantidadDias; }
        public DateTime getFechaRetiro() { return fechaRetiro; }
        public Vehiculo getvehiculos() { return vehiculos; }


    }
}
