using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticoII
{
    internal class Vehiculo
    {
        private int numero;
        private double precioDiario;
        private string matricula;
        private string marca;
        private string color;
        private double capacidadTanque;
        private double kPorl;
        private bool estado;
        public Vehiculo(string matricula, string marca, string color, double capacidadTanque, double kPorl, bool estado, double precioDiario)
        {
            this.numero = 0;
            this.matricula = matricula;
            this.marca = marca;
            this.color = color;
            this.capacidadTanque = capacidadTanque;
            this.kPorl = kPorl;
            this.estado = estado;
            this.precioDiario = precioDiario;
        }
        public int getNumero() { return numero; }
        public string getMatricula() { return matricula; }
        public string getMarca() { return marca; }
        public string getColor() { return color; }
        public double getCapacidadTanque() { return capacidadTanque; }
        public double getKporL() { return kPorl; }
        public bool getEstado() { return estado; }
        public double getPrecio() { return precioDiario; }
        public void setEstado(bool estado) { this.estado = estado; }
        public void setNumero(int numero) { this.numero = numero; }
        public void setMatricula(string matricula) { this.matricula = matricula; }
        public void setMarca(string marca) { this.marca = marca; }
        public void setColor(string color) { this.color = color; }
        public void setCapacidadtanque(double capacidadTanque) { this.capacidadTanque = capacidadTanque; }
        public void setKporL(double kPorl) { this.kPorl = kPorl; }
        public void setPrecioDiario(double precioDiario) { this.precioDiario = precioDiario; }
        public virtual void getEspecialidad() { }



    }
}
