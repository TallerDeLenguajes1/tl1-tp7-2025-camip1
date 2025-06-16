using DatosEmpleados;

Empleado[] empleados = new Empleado[3];
            
empleados[0] = new Empleado
{
    Nombre = "Adrian",
    Apellido = "Reyes",
    FechaDeNacimiento = new DateTime(1971, 9, 8),
    EstadoCivil = 'C',
    FechaIngreso = new DateTime(2004, 3, 1),
    SueldoBasico = 850000,
    CargoEmpleado = Cargo.Administrativo
};

empleados[1] = new Empleado
{
    Nombre = "Sofia",
    Apellido = "Juarez",
    FechaDeNacimiento = new DateTime(2004, 7, 15),
    EstadoCivil = 'S',
    FechaIngreso = new DateTime(2020, 5, 12),
    SueldoBasico = 570000,
    CargoEmpleado = Cargo.Especialista
};

empleados[2] = new Empleado
{
    Nombre = "Juan",
    Apellido = "Cordoba",
    FechaDeNacimiento = new DateTime(1990, 5, 10),
    EstadoCivil = 'C',
    FechaIngreso = new DateTime(2010, 3, 1),
    SueldoBasico = 650000,
    CargoEmpleado = Cargo.Ingeniero
};

Console.WriteLine("\nEmpleados\n");
foreach (var empleado in empleados)
{
    empleado.MostrarDatosEmpleado();
}

Console.WriteLine("Calculo del total abonado en salarios");
double totalSalarios = 0;
foreach (var empleado in empleados)
{
    totalSalarios += empleado.CalcularSalario();
}
Console.WriteLine($"El total pagado en salarios es de {totalSalarios}");

Console.WriteLine("\nDatos del empleado mas proximo a jubilarse\n");
Empleado proximoJubilacion = empleados[0];
int indice=0;
foreach (var empleado in empleados)
{
    if (empleado.AñosJubilacion() < proximoJubilacion.AñosJubilacion())
    {
        proximoJubilacion = empleado;
    }
}
empleados[indice].MostrarDatosEmpleado();