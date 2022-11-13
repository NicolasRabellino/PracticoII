using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticoII
{
    internal class Sucursal
    {
        private string nombre;
        private int id;
        private string direccion;
        private List<Alquiler> listaAlquiler;
        private List<Vehiculo> listaVehiculo;
        public Sucursal(string nombre, int id, string direccion, List<Vehiculo> listaVehiculo, List<Alquiler> alquilers)
        {
            this.nombre = nombre;
            this.id = id;
            this.direccion = direccion;
            this.listaVehiculo = listaVehiculo;
            this.listaAlquiler = alquilers;
        }

        public string getNombre() { return nombre; }
        public int getId() { return id; }
        public string getDireccion() { return direccion; }
        public List<Alquiler> getListaAlquiler() => this.listaAlquiler;
        public List<Vehiculo> GetVehiculos() => this.listaVehiculo;

        public void setNombre(string nombre) { this.nombre = nombre; }
        public void setId(int id) { this.id = id; }
        public void setDireccion(string direccion) { this.direccion = direccion; }
        public void setAlquiler(List<Alquiler> alquilers) { this.listaAlquiler = alquilers; }
        public void setVehiculo(List<Vehiculo> vehiculos) { this.listaVehiculo = vehiculos; }

        public void agregarNumeroVehiculos()
        {
            for (int i = 0; i < listaVehiculo.Count; i++)
            {
                listaVehiculo[i].setNumero(i + 1);
            }
        }
        public void agregarIdAlquileres()
        {
            for (int i = 0; i < listaAlquiler.Count; i++)
            {
                listaAlquiler[i].setIdAlquiler(i + 1);
            }
        }
        public void menuPrincipal()
        {

            Console.WriteLine("--------- MENU PRINCIPAL ----------\n");
            Console.WriteLine("1 - Mostrar Todos los Vehiculos registrados");
            Console.WriteLine("2 - Mostrar Estado de los Vehiculos");
            Console.WriteLine("3 - Mostrar Registro de clientes ");
            Console.WriteLine("0 - Salir\n");

            Console.Write("Seleccione opcion: ");
        }
        public void mostrarEstados()
        {
            Console.Clear();
            Console.WriteLine("---------Estado del Vehiculo---------\n");

            for (int i = 0; i < this.listaVehiculo.Count; i++)
            {
                if (listaVehiculo[i].getEstado() == true)
                {
                    Console.WriteLine($"Vehiculo {listaVehiculo[i].getMarca()}- Estado : Alquilado");
                }

                else if (listaVehiculo[i].getEstado() == false)
                {
                    Console.WriteLine($"Vehiculo {listaVehiculo[i].getMarca()}- Estado : Disponible");
                }
            }
            Console.WriteLine("");
        }

        public void mostrartodosVehiculo()
        {
            Console.Clear();
            Console.WriteLine("---------Todos los Vehiculos---------\n");

            for (int i = 0; i < this.listaVehiculo.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {this.listaVehiculo[i].getMarca()}");
            }
            Console.WriteLine("");
        }
        public void mostrarCliente()
        {
            Console.Clear();
            Console.WriteLine("---------Clientes Registrados---------\n");

            for (int i = 0; i < this.listaAlquiler.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {this.listaAlquiler[i].getnombreCliente()} {this.listaAlquiler[i].getapellidoCliente()} - Vehiculo : {listaVehiculo[i].getMarca()}");
            }
            Console.WriteLine("0 - Salir");

        }

        public void darDatosCompletosDeCliente(int indice)
        {
            Console.Clear();
            int i = indice - 1;
            Console.WriteLine("-------------Datos Del cliente-------------");
            Console.WriteLine($"Nombre: {listaAlquiler[i].getnombreCliente()} {listaAlquiler[i].getapellidoCliente()}\nDocumento:{listaAlquiler[i].getDocumentoCliente()}\nTelefono: {listaAlquiler[i].getTelefonoCliente()}");
            Console.WriteLine("-------------Datos del Vehiculo Alquilado-------------");
            Console.WriteLine($"Marca: {listaVehiculo[i].getMarca()} \nMatricula: {listaVehiculo[i].getMatricula()} \nColor: {listaVehiculo[i].getColor()} \nCapacidad De Tanque : {listaVehiculo[i].getCapacidadTanque()} L \nKilometros por litro ; L/{listaVehiculo[i].getKporL()}km ");
            listaVehiculo[i].getEspecialidad();
            Console.WriteLine("-------------Detalles-------------");
            listaAlquiler[i].darMontoTotal(i);

        }


    }
}
