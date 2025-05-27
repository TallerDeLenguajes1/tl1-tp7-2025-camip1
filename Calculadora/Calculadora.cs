using System.Dynamic;

namespace EspacioCalculadora
{
    public class Calculadora
    {
        private double Dato;
        public double Resultado
        {
            get => Dato;
        }
        public void Sumar(double termino)
        {
            Dato += termino;
        }
        public void Restar(double termino)
        {
            Dato -= termino;
        }
        public void Multiplicar(double termino)
        {
            Dato *= termino;
        }
        public void Dividir(double termino)
        {
            Dato /= termino;
        }
        public void Limpiar()
        {
            Dato = 0;
        }
    }
}