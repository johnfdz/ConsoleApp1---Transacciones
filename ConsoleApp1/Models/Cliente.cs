using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string FechaNacimiento { get; set; }
        public string Estado { get; set; }

        public int GeneroId { get; set; }
        public Genero Genero { get; set; }

        public int DireccionId { get; set; }
        public Direccion Direccion { get; set; }
    }
}