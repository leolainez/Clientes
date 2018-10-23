using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Rentas
{
    public class ClientesBL
    {
       public BindingList<Cliente> ListaClientes { get; set; }

        public ClientesBL()
        {
            ListaClientes = new BindingList<Cliente>();

            var cliente1 = new Cliente();
            cliente1.Id = 1;
            cliente1.Nombre = "Jose Leonel";
            cliente1.Correo = "leonel@hotmail.com";
            cliente1.Telefono = 25594263;
            cliente1.Direccion = "Col. La Pradera";
            cliente1.Activo = true;

            ListaClientes.Add(cliente1);

            var cliente2 = new Cliente();
            cliente2.Id = 2;
            cliente2.Nombre = "Jose David";
            cliente2.Correo = "David@hotmail.com";
            cliente2.Telefono = 25594264;
            cliente2.Direccion = "Col. La Union";
            cliente2.Activo = true;

            ListaClientes.Add(cliente2);

            var cliente3 = new Cliente();
            cliente3.Id = 3;
            cliente3.Nombre = "Jose Marcos";
            cliente3.Correo = "Marcos@hotmail.com";
            cliente3.Telefono = 25594268;
            cliente3.Direccion = "Col. La Petaca";
            cliente3.Activo = true;

            ListaClientes.Add(cliente3);

            var cliente4 = new Cliente();
            cliente4.Id = 4;
            cliente4.Nombre = "Marisela Yanez";
            cliente4.Correo = "Yanez@hotmail.com";
            cliente4.Telefono = 25595241;
            cliente4.Direccion = "Col. La Satelite";
            cliente4.Activo = true;

            ListaClientes.Add(cliente4);

            var cliente5 = new Cliente();
            cliente5.Id = 5;
            cliente5.Nombre = "Merary Lainez";
            cliente5.Correo = "Merary@hotmail.com";
            cliente5.Telefono = 25592121;
            cliente5.Direccion = "Col. La Jupiter";
            cliente5.Activo = true;

            ListaClientes.Add(cliente5);

        }

        public BindingList<Cliente> ObtenerClientes()

        {
        
        return ListaClientes;

    }

        public bool GuardarCliente(Cliente cliente)
        {
            if (cliente.Id == 0)
            {
                cliente.Id = ListaClientes.Max(item => item.Id) + 1;
            }


            return true;
        }

        public void AgregarCliente()
        {
            var nuevoCliente = new Cliente();
            ListaClientes.Add(nuevoCliente);
        }

        public bool EliminarClientes(int id)

        {
            foreach (var cliente in ListaClientes)
            {
                if (cliente.Id == id)
                {
                    ListaClientes.Remove(cliente);
                    return true;
                }

            }
            return false;
       
        }
    }


    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public bool Activo { get; set; }

 
   
    }
}