using ConsoleApp1.Models;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //agregarEstudiante();
        //consultarEstudiantes();
        //consultarEstudiante();
        //modificarEstudiante();
    }

    //agregar Cliente
    public static void agregarCliente()
    {
        Console.WriteLine("Metodo agregar cliente");
        ClienteContext context = new ClienteContext();
        Cliente cli = new Cliente();
        cli.Nombre = "Pedro";
        cli.Apellido = "Perez";
        cli.Direccion = "Calle 1";
        cli.Telefono = "12345678";
        cli.FechaNacimiento = "01/01/1990";
        cli.Estado = "A";
        context.Clientes.Add(cli);
        context.SaveChanges();
      
        Console.WriteLine("Codigo: "+ cli.ClienteId + " Nombre: "+ cli.Nombre);

    }

    public static void consultarClientes()
    {
        Console.WriteLine("Metodo consultar estudiantes");
        ClienteContext context = new ClienteContext();
        List<Cliente> listClientes= context.Clientes.ToList() ;

        foreach (var item in listClientes)
        {
            Console.WriteLine("Codigo: " + item.ClienteId + " Nombre: " + item.Nombre + " Apellido: "
            + item.Apellido + "Direccion: " + item.Direccion);
        }
        
    }

    public static void consultarCliente()
    {
        Console.WriteLine("Metodo consultar cliente por Id");
        ClienteContext context = new ClienteContext();
        Cliente cli = new Cliente();
        cli = context.Clientes.Find(1);

       Console.WriteLine("Codigo: " + cli.ClienteId + " Nombre: " + cli.Nombre);
      
    }

    public static void modificarCliente()
    {
        Console.WriteLine("Metodo modificar cliente");
        ClienteContext context = new ClienteContext();
        Cliente cli = new Cliente();
        cli = context.Clientes.Find(1);

        cli.Nombre = "Alfredo";
        cli.Apellido = "Poveda";
        cli.Direccion = "Calle 1";
        cli.Telefono = "12345678";
        cli.FechaNacimiento = "01/01/1990";
        cli.Estado = "A";
        context.SaveChanges();
        Console.WriteLine("Codigo: " + cli.ClienteId + " Nombre: " + cli.Nombre);

    }

}