// Definir las credenciales del agente de tránsito
string usuario = "agente1";
string contraseña = "123456";

List<string> infracciones = new List<string>();

// Definir los tipos de infracciones y sus penalidades
Dictionary<string, int> penalidades = new Dictionary<string, int>()
{
    {"Obstrucción de tránsito", 1800},
    {"Pasar en rojo", 5950},
    {"Hablar por celular", 3750},
    {"Conducir sin cinturón", 2560},
    {"Licencia vencida", 3890}
};

// Pedir al usuario que ingrese sus credenciales para acceder al programa
Console.Write("Ingrese su nombre de usuario: ");
string usuarioIngresado = Console.ReadLine();
Console.Write("Ingrese su contraseña: ");
string contraseñaIngresada = Console.ReadLine();

// Verificar si las credenciales son correctas
if (usuarioIngresado == usuario && contraseñaIngresada == contraseña)
{
    // Obtener la fecha y hora actual del sistema
    DateTime fechaHoraAcceso = DateTime.Now;

    // Pedir al usuario que ingrese las informaciones del agente
    Console.Write("Ingrese el nombre del agente: ");
    string nombreAgente = Console.ReadLine();
    Console.Write("Ingrese la dirección del agente: ");
    string direccionAgente = Console.ReadLine();
    Console.Write("Ingrese la fecha de acceso al programa (DD/MM/AAAA): ");
    DateTime fechaIngresoAgente = DateTime.Parse(Console.ReadLine());

    // Imprimir un mensaje de bienvenida al agente
    Console.WriteLine($"Bienvenido, {nombreAgente}.");

    // Pedir al usuario que ingrese las informaciones del conductor
    Console.Write("Ingrese el nombre del conductor: ");
    string nombreConductor = Console.ReadLine();
    Console.Write("Ingrese la placa del vehículo: ");
    string placaVehiculo = Console.ReadLine();
    Console.Write("Ingrese la infracción cometida: ");
    string infraccion = Console.ReadLine();
    Console.Write("Ingrese el tipo de licencia (A/B/C): ");
    string tipoLicencia = Console.ReadLine();

    List<TipoLicencia> tiposLicencia = new List<TipoLicencia>()
{
    new TipoLicencia("A", "Todos los vehículos"),
    new TipoLicencia("B", "Vehículos pesados"),
    new TipoLicencia("C", "Motocicletas")
};

    TipoLicencia tipoLicenciaSeleccionado = tiposLicencia.Find(t => t.Tipo == tipoLicencia);

    if (tipoLicenciaSeleccionado != null)
    {
        Console.WriteLine($"Tipo de licencia seleccionado: {tipoLicenciaSeleccionado.Descripcion}");
    }
    else
    {
        Console.WriteLine("El tipo de licencia ingresado no es válido.");
    }


   

    // Verificar si la infracción está en la lista de infracciones válidas
    if (penalidades.ContainsKey(infraccion))
    {
        // Obtener la penalidad correspondiente a la infracción
        int penalidad = penalidades[infraccion];

        // Agregar los datos de la infracción a la lista
        infracciones.Add($"{fechaHoraAcceso} - {nombreConductor} - {placaVehiculo} - {infraccion} - Registrado por {nombreAgente} - Penalidad: RD${penalidad}");

        // Imprimir un mensaje de confirmación
        Console.WriteLine($"La infracción ha sido registrada correctamente. Penalidad: RD${penalidad}");
    }
    else
    {
        Console.WriteLine("La infracción ingresada no es válida.");
    }
}
else
{
    Console.WriteLine("Credenciales incorrectas. Acceso denegado.");
}


public class Conductor
{
    public string Nombre { get; set; }
    public string Licencia { get; set; }

    public Conductor(string nombre, string licencia)
    {
        Nombre = nombre;
        Licencia = licencia;
    }
}

public class Vehiculo
{
    public string Placa { get; set; }
    public string Tipo { get; set; }

    public Vehiculo(string placa, string tipo)
    {
        Placa = placa;
        Tipo = tipo;
    }
}
