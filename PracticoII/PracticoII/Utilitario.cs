using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticoII
{
    internal class Utilitario : Vehiculo
    {
        private string especialidad;
        public Utilitario(string matricula, string marca, string color, double capacidadTanque, double kPorl, bool estado, double precio, string especialidad) : base(matricula, marca, color, capacidadTanque, kPorl, estado, precio)
        {
            this.especialidad = especialidad;
        }
        public override void getEspecialidad()
        {
            Console.WriteLine($"Especialidad : Tiene una capacidad de carga de {especialidad} L");
        }

        public void setEspecialidad(string especialidad) { this.especialidad = especialidad; }
    }
}
