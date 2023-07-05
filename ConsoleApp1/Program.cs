using ConsoleApp1.Models;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //agregarCliente();
    }

    //agregar Cliente
    public static void agregarCliente()
    {
        Console.WriteLine("Metodo agregar cliente");
            ClienteContext context = new ClienteContext();
            Cliente cli = new Cliente();
            Direccion dir = new Direccion();
            Genero gen = new Genero();
            var dbContextTransaction = context.Database.BeginTransaction();

        try
        {
            

            dir.Nombre = "Calle 1";
            dir.Estado = "A";
            context.Direcciones.Add(dir);
            context.SaveChanges();

            gen.Nombre = "Masculino";
            gen.Estado = "A";
            context.Generos.Add(gen);
            context.SaveChanges();
            
            cli.Nombre = "Pedro";
            cli.Apellido = "Perez";
            cli.Telefono = "12345678";
            cli.DireccionId = dir.DireccionId;
            cli.FechaNacimiento = "01/01/1990";
            cli.GeneroId = gen.GeneroId;
            cli.Estado = "A";
            context.Clientes.Add(cli);
            context.SaveChanges();

            dbContextTransaction.Commit();
      
            Console.WriteLine("Codigo: "+ cli.ClienteId + " Nombre: "+ cli.Nombre);
        }
        catch (Exception e)
        {
            dbContextTransaction.Rollback();
            Console.WriteLine(e);
            throw;
        }

    }
    
}