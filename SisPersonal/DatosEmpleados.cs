namespace DatosEmpleados
{
    public class Empleados
    {
        private string Nombre;
        private string Apellido;
        private DateTime fechaDeNacimiento;
        private char EstadoCivil;
        private DateTime FechaIngreso;
        private double sueldoBasico(double);
        enum cargos
        {
        Auxiliar = 0,
        Administrativo=1,
        Ingeniero = 2,
        Especialista = 3,
        Investigador = 4,
        }
        private cargos Cargo;
    }
}