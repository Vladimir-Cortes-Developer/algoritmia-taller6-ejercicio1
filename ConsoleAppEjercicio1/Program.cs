using ConsoleAppEjercicio1.Dominio;

// Fase 1.  Crear empleados en el diccionario
var empresa = new Empresa();

Console.WriteLine("============Fase No.1: Agregar empleados =================");
// A traves del objeto (empresa) accedemos a los miembros de la clase
empresa.AgregarEmpleado(new Empleado()
{
    Id = 1,
    Nombre = "Julian Castillo",
    Cargo = "Desarrollador",
    Salario = 5000000m
});
empresa.AgregarEmpleado(new Empleado()
{
    Id = 2,
    Nombre = "Diana Baquero",
    Cargo = "Lider de Proyectos",
    Salario = 25000000m
});
empresa.AgregarEmpleado(new Empleado()
{
    Id = 3,
    Nombre = "Alvaro Palacios",
    Cargo = "Analista QA",
    Salario = 4500000m
});
empresa.ListarEmpleados();
Console.WriteLine();

//Fase 2. Buscar empleados por Id
Console.WriteLine("============ Fase No.2: Buscar empleados por Id ================= ");
Console.WriteLine("Ingrese el Id del empleado a buscar");
int idBuscado =Convert.ToInt32(Console.ReadLine());
var empleado = empresa.BuscarEmpleado(idBuscado);
if(empleado != null)
{
    Console.WriteLine($"Empleado con Id: {idBuscado} encontrado {empleado}");
}
else
{
    Console.WriteLine($"No se encontro el empleado con Id: {idBuscado}");
}
Console.WriteLine();

// Fase 3.  Encolar Tareas
Console.WriteLine("============ Fase No.3: Encolar Tareas ================= ");
empresa.Encolartarea("Generar nómina de este mes");
empresa.Encolartarea("Enviar reportes de ausentismos");
empresa.Encolartarea("Programar capacitaciones de seguridad laboral");
empresa.Encolartarea("Programar capacitaciones de Analítica de Datos");

empresa.ListarTareasPendientes();

// Fase 4. Procesar Tareas (FIFO)
Console.WriteLine("============ Fase No.4: Procesar Tareas (FIFO) ================= ");
var tarea1 = empresa.ProcesarSiguienteTarea();
Console.WriteLine($"Tarea Procesada: {tarea1}");

var tarea2 = empresa.ProcesarSiguienteTarea();
Console.WriteLine($"Tarea Procesada: {tarea2}");

Console.WriteLine();
empresa.ListarTareasPendientes();
Console.WriteLine();

// Fase 5. Mostrar  el Historial (LIFO)
empresa.MostrarHistorial();
Console.WriteLine();
Console.WriteLine("Presione una Tecla para Salir");
Console.ReadKey();
