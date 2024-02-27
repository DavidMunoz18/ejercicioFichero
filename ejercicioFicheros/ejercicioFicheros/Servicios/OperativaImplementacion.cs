using ejercicioFicheros.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioFicheros.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void aniadirCliente(List<ClienteDto> listaClientes)
        {
            ClienteDto cliente = darAltaCliente(listaClientes);

            listaClientes.Add(cliente);
        }
        private ClienteDto darAltaCliente(List<ClienteDto> listaClientes)
        {
            ClienteDto cliente = new ClienteDto();

            Console.WriteLine("Referencia de orden de acreedor");
            cliente.RefOrdernDomi = refIterativa(listaClientes);

            Console.WriteLine("Introduzca el nombre del adeudor");
            cliente.NombreAdeudor = Console.ReadLine();
            string nombreAdeudor = cliente.NombreAdeudor;

            Console.WriteLine("Introduzca el primer apellido del adeudor");
            cliente.Apellido1 = Console.ReadLine();

            Console.WriteLine("Introduzca el segundo apellido del adeudor");
            cliente.Apellido2 = Console.ReadLine();

            Console.WriteLine("Introduzca la dirección del adeudor");
            cliente.DireccionAdeudor = Console.ReadLine();

            Console.WriteLine("Introduzca el codigo postal del adeudor");
            cliente.CodPostalAdeudor = Console.ReadLine();

            Console.WriteLine("Introduzca el numero de cuenta del adeudor");
            cliente.NumerCuentaIbanAdeudor = Console.ReadLine();

            Console.WriteLine("Introduzca el swift del adeudor");
            cliente.SwitchBankAdeudor = Console.ReadLine();

            Console.WriteLine("Introduzca el tipo de pago (R/U)");
            cliente.TipPago = Convert.ToChar(Console.ReadLine());

            adeudoSepa(listaClientes , nombreAdeudor);

            return cliente;

        }

        private long refIterativa(List<ClienteDto> listaClientes)
        {
            long refCalculada;
            int tamanioLista = listaClientes.Count;

            if(tamanioLista == 0)
            {
                refCalculada = 1;
            }
            else
            {
                refCalculada = listaClientes[tamanioLista-1].RefOrdernDomi;
            }
            return refCalculada;
        }

        private void adeudoSepa(List<ClienteDto> listaClientes , string nombreAdeudor)
        {
            foreach(var cliente in listaClientes)
            {
                if (cliente.NombreAdeudor.Equals(nombreAdeudor) == true)
                {
                    string ruta = cliente.NombreAdeudor + cliente.Apellido1 + ".txt";

                    using(StreamWriter sw = new StreamWriter(ruta))
                    {
                        sw.WriteLine("-------------------------------------------------");
                        sw.WriteLine("Referencia de la orden de domiciliación: " + cliente.RefOrdernDomi);
                        sw.WriteLine("Identificador del acreedor: " + cliente.IdAcreedor );
                        sw.WriteLine("Nombre del acreedor: " + cliente.NombreAcre );
                        sw.WriteLine("Direccion del acreedor: " + cliente.DireccionAcre );
                        sw.WriteLine("Codigo postal acreedor: " + cliente.CodPostarAcre);
                        sw.WriteLine("-------------------------------------------------");
                        sw.WriteLine("Nombre del deudor: " + cliente.NombreAdeudor);
                        sw.WriteLine("Direccion del deudor: " + cliente.NombreAdeudor);
                        sw.WriteLine("Codigo postal deudor: " + cliente.CodPostalAdeudor);
                        sw.WriteLine("Numero de cuenta iban: " + cliente.NumerCuentaIbanAdeudor);
                        sw.WriteLine("Swift: " + cliente.SwitchBankAdeudor);
                        sw.WriteLine("Tipo de pago: " + cliente.TipPago);
                        sw.WriteLine("-------------------------------------------------");
                        sw.WriteLine("Firma del deudor: ");
                        sw.WriteLine("-------------------------------------------------");

                    }
                }
            }
        }
    }
}
