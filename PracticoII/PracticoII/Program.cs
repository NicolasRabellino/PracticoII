using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticoII
{
    internal class Program
    {


        static void Main(string[] args)
        {
            //Vehiculos
            Deportivo miDeportivo = new Deportivo("M121 31W1", "Deportido", "Rojo", 15, 15, true, 6000, "180");
            Familiar miFamiliar = new Familiar("WQEQ QQ11", "Cherry qq", "Negro", 12, 13, false, 2000, "50");
            Utilitario miutilitario = new Utilitario("WQED QWEW", "Honda", "Gris", 20, 13, false, 3500, "80");
            List<Vehiculo> listaDeAutos = new List<Vehiculo>();
            listaDeAutos.Add(miutilitario);
            listaDeAutos.Add(miFamiliar);
            listaDeAutos.Add(miDeportivo);
            //Alquiler
            Alquiler miAlquiler = new Alquiler("Rick", "Sanchez", "09231232", 50005555);

            //Detalles
            miAlquiler.agregarDetalle(13, miDeportivo, 2022, 12, 13);

            //Lista Alquiler
            List<Alquiler> listaAlquiler = new List<Alquiler>();
            listaAlquiler.Add(miAlquiler);

            //Surcusar
            Sucursal miSucursal = new Sucursal("Ruedas del Norte", 1, "Maldonado", listaDeAutos, listaAlquiler);
            miSucursal.agregarNumeroVehiculos();
            miSucursal.agregarIdAlquileres();

            bool salirMenu = false;
            int ingresoMenu;
            while (salirMenu == false)
            {
                Console.WriteLine($"--------Sucursal {miSucursal.getNombre()}----------------\n");
                miSucursal.menuPrincipal();
                try
                {
                    ingresoMenu = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    ingresoMenu = 10;
                }
                switch (ingresoMenu)
                {
                    case 1:
                        miSucursal.mostrartodosVehiculo();
                        break;
                    case 2:
                        miSucursal.mostrarEstados();
                        break;





                    case 3:
                        miSucursal.mostrarCliente();
                        int ingresoCliente;
                        Console.Write("Ingrese el numero del Cliente: ");
                        try

                        {
                            ingresoCliente = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            ingresoCliente = miSucursal.getListaAlquiler().Count() + 2;

                        }
                        if (ingresoCliente != 1)
                        {
                            break;
                        }

                        miSucursal.darDatosCompletosDeCliente(ingresoCliente);

                        break;
                    case 0:
                        salirMenu = true;
                        break;

                }
            }
        }
    }
}
