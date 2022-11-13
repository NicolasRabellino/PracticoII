using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticoII
{
    internal class Deportivo : Vehiculo
    {
        private string especialidad;
        public Deportivo(string matricula, string marca, string color, double capacidadTanque, double kPorl, bool estado, double precio, string especialidad) : base(matricula, marca, color, capacidadTanque, kPorl, estado, precio)
        {
            this.especialidad = especialidad;
        }
        public override void getEspecialidad()
        {
            Console.WriteLine($"Especialidad : Tiene una velocidad maxima de {especialidad} km/h ");
        }
        public void setEspecialidad(string especialidad) { this.especialidad = especialidad; }
    }
}
