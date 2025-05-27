using EspacioCalculadora;

Calculadora calc1 = new Calculadora();

int op;
string? input;
bool esNumValido;
int termino;

do
{
    Console.WriteLine("Menu de operaciones: 1-Sumar | 2-Restar | 3-Multiplicar | 4- Dividir | 5-Limpiar | 6-Salir");
    input = Console.ReadLine();
    esNumValido = int.TryParse(input, out op);

    if (esNumValido)
    {
        switch (op)
        {
            case 1:
                Console.WriteLine("Ingrese un numero para realizar la operacion:");
                input = Console.ReadLine();
                esNumValido = int.TryParse(input, out termino);
                calc1.Sumar(termino);
                Console.WriteLine("Valor de dato:" + calc1.Resultado);
                break;
            case 2:
                Console.WriteLine("Ingrese un numero para realizar la operacion:");
                input = Console.ReadLine();
                esNumValido = int.TryParse(input, out termino);
                calc1.Restar(termino);
                Console.WriteLine("Valor de dato:" + calc1.Resultado);
                break;
            case 3:
                Console.WriteLine("Ingrese un numero para realizar la operacion:");
                input = Console.ReadLine();
                esNumValido = int.TryParse(input, out termino);
                calc1.Multiplicar(termino);
                Console.WriteLine("Valor de dato:" + calc1.Resultado);
                break;
            case 4:
                Console.WriteLine("Ingrese un numero para realizar la operacion:");
                input = Console.ReadLine();
                esNumValido = int.TryParse(input, out termino);
                if (termino != 0)
                {
                    calc1.Dividir(termino);
                    Console.WriteLine("Valor de dato:" + calc1.Resultado);
                }
                else
                {
                    Console.WriteLine("No se puede realizar la division (division por cero).");
                }
                break;
            case 5:
                calc1.Limpiar();
                Console.WriteLine("Valor de dato:" + calc1.Resultado);
                break;
            case 6:
                Console.WriteLine("Saliendo del programa...");
                break;
            default:
                Console.WriteLine("Opcion invalida!");
                break;
        }
    }
    else
    {
        Console.WriteLine("La opcion debe ser un numero.");
    }
} while (op != 6);