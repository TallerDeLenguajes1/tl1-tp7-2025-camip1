using System.Runtime.InteropServices;

namespace DatosEmpleados
{
    public enum Cargo
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador,
    }

    public class Empleado
    {
        private string nombre;
        private string apellido;
        private DateTime fechaDeNacimiento;
        private char estadoCivil;
        private DateTime fechaIngreso;
        private double sueldoBasico;
        private Cargo cargo;

        // Propiedades
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public string Apellido
        {
            get => apellido;
            set => apellido = value;
        }
        public DateTime FechaDeNacimiento
        {
            get => fechaDeNacimiento;
            set => fechaDeNacimiento = value;
        }
        public char EstadoCivil
        {
            get => estadoCivil;
            set => estadoCivil = value;
        }
        public DateTime FechaIngreso
        {
            get => fechaIngreso;
            set => fechaIngreso = value;
        }
        public double SueldoBasico
        {
            get => sueldoBasico;
            set => sueldoBasico = value;
        }
        public Cargo CargoEmpleado
        {
            get => cargo;
            set => cargo = value;
        }

        //metodos
        public int CalcularAntiguedad()
        {
            return DateTime.Now.Year - FechaIngreso.Year;
        }
        public int ObtenerEdad()
        {
            DateTime hoy = DateTime.Today;
            int edad = hoy.Year - FechaDeNacimiento.Year;
            if (FechaDeNacimiento.Date > hoy.Date)
            {
                edad--;
            }
            return edad;
        }

        public int AñosJubilacion()
        {
            int edad = ObtenerEdad();
            return 65 - edad;
        }

        public double CalcularSalario()
        {
            double Adicional;
            int antiguedad = CalcularAntiguedad();
            if (antiguedad <= 20)
            {
                Adicional = SueldoBasico * (antiguedad * 0.01);
            }
            else
            {
                Adicional = SueldoBasico * 0.25;
            }
            if (CargoEmpleado == Cargo.Ingeniero || CargoEmpleado == Cargo.Especialista)
            {
                Adicional *= 1.50;
            }
            if (EstadoCivil == 'C')
            {
                Adicional += 150000;
            }
            double salario = SueldoBasico + Adicional;
            return salario;
        }

        public void MostrarDatosEmpleado()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Apellido: {Apellido}");
            Console.WriteLine($"Fecha de Nacimiento: {FechaDeNacimiento}");
            Console.WriteLine($"Edad: {ObtenerEdad()}");
            Console.WriteLine($"Estado Civil: {EstadoCivil}");
            Console.WriteLine($"Fecha de ingreso a la empresa: {FechaIngreso}");
            Console.WriteLine($"Sueldo basico: {SueldoBasico}");
            Console.WriteLine($"Cargo: {CargoEmpleado}");
            Console.WriteLine($"Antiguedad en la empresa: {CalcularAntiguedad()}");
            Console.WriteLine($"Años restantes para la jubilacion: {AñosJubilacion()}");
            Console.WriteLine($"Salario: {CalcularSalario()}\n");
        }
    }
}
