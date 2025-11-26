using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppEjercicio1.Dominio;

namespace ConsoleAppEjercicio1.Dominio
{
    public class Empresa
    {
        // 1: usar Dictionary<int, Empleado> para guardar empleados por Id
        private readonly Dictionary<int, Empleado> _empleados =  new Dictionary<int, Empleado>();

        // 2: usar Stack<string> para almacenar historial de operaciones
        private readonly Stack<string> _historial = new Stack<string>();

        // 3: usar Queue<string> para cola de tareas pendientes
        private readonly Queue<string> _tareas = new Queue<string>();

        // Métodos (Acciones)

        public void AgregarEmpleado(Empleado empleado)
        {
            // 4: agregar o actualizar empleado en el Dictionary
            _empleados[empleado.Id] = empleado;

            // TODO 5: registrar en el historial
            _historial.Push($"[{DateTime.Now}] Agregado/Actualizado empleado {empleado.Id} - {empleado.Nombre}");
        }
        public Empleado? BuscarEmpleado(int id)
        {
            // 6. Usar TryGetValue
            _empleados.TryGetValue(id, out var empleado);
            return empleado;
        }
        public void Encolartarea(string tarea)
        {
            // 7: encolar tarea y registrarla en historial
            _tareas.Enqueue(tarea);
            _historial.Push($"[{DateTime.Now}] Encolada tarea: {tarea}");
        }

        public string? ProcesarSiguienteTarea()
        {
            // 8: Si NO hay Tareas, devolver null
            if (_tareas.Count==0)
            {
                return null;
            }
            // 9. Desencolar la tarea y registrarla en el historial
            var tarea = _tareas.Dequeue();
            _historial.Push($"[{DateTime.Now}] Procesada tarea: {tarea}");
            return tarea;
        }

        public void MostrarHistorial()
        {
            Console.WriteLine("=== Historial (último primero, Stack) ===");
            foreach (var item in _historial)
            {
                Console.WriteLine(item);
            }
        }

        public void ListarEmpleados()
        {
            Console.WriteLine("=== Empleados (Dictionary) ===");
            foreach(var item in _empleados)
            {
                Console.WriteLine($"Clave (Id): {item.Key} \t {item.Value}");
            }
        }

        public void ListarTareasPendientes()
        {
            Console.WriteLine("=== Tareas (Queue) ===");
            foreach (var item in _tareas)
            {
                Console.WriteLine(item);
            }
        }
        
    }
}
