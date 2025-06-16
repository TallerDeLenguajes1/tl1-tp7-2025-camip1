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
    }
}

