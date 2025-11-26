using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEjercicio1.Dominio
{
    public class Empleado
    {
        //Propiedades de la clase
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }

        public override string ToString()
        {
            return $"[Id={Id}, Nombre={Nombre}, Cargo={Cargo}, Salario={Salario:C}]";
        }
    }
}
