using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticoII
{
    internal class Alquiler
    {
        private string nombreCliente;
        private string apellidoCliente;
        private string telefonoCliente;
        private int documentoCliente;
        private int id;
        private double precioTotal;
        private List<Detalle> listaDetalles;
        public Alquiler(string nombreCliente, string apellidoCliente, string telefonoCliente, int documentoCliente)
        {
            this.nombreCliente = nombreCliente;
            this.apellidoCliente = apellidoCliente;
            this.telefonoCliente = telefonoCliente;
            this.documentoCliente = documentoCliente;
            this.id = 0;
            this.precioTotal = 0;
            this.listaDetalles = new List<Detalle>();
        }
        public void agregarDetalle(int cantidadDias, Vehiculo vehiculos, int anio, int mes, int dia)
        {
            Detalle midetalle = new Detalle(cantidadDias, vehiculos, anio, mes, dia);
            listaDetalles.Add(midetalle);
        }
        public string getnombreCliente() { return nombreCliente; }
        public string getapellidoCliente() { return apellidoCliente; }
        public int getId() { return id; }
        public double getPrecioTotal() { return precioTotal; }
        public string getTelefonoCliente() { return telefonoCliente; }
        public int getDocumentoCliente() { return documentoCliente; }

        public void setNombreCliente(string nombreCliente) { this.nombreCliente = nombreCliente; }
        public void setIdAlquiler(int id) { this.id = id; }
        public void setApellidoCliente(string apellidoCliente) { this.apellidoCliente = apellidoCliente; }
        public void setDocumentoCliente(int documentoCliente) { this.documentoCliente = documentoCliente; }

        public void setTelefonoCliente(string telefonoCliente) { this.telefonoCliente = telefonoCliente; }
        public void darMontoTotal(int i)
        {

            precioTotal = listaDetalles[i].getCantidadDeDias() * listaDetalles[i].getvehiculos().getPrecio();
            Console.WriteLine($"\nCantidad de dias alquilado: {listaDetalles[i].getCantidadDeDias()} \nPrecio diario del auto $ {listaDetalles[i].getvehiculos().getPrecio()} ");
            Console.WriteLine($"Con un monto de $ {precioTotal} y fecha de retiro {listaDetalles[i].getFechaRetiro()}\n\n");
        }

    }
}
