using EjercicioExcepciones;

class Program
{
    static void Main(string[] args)
    {
        Operaciones operaciones = new Operaciones();
        int opcion=0;

        do
        {
            Console.WriteLine("Elija una opción:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Salir");

            try
            {
                opcion = int.Parse(Console.ReadLine());

                if (opcion >= 1 && opcion <= 4)
                {
                    Console.Write("Ingrese el primer número: ");
                    double num1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese el segundo número: ");
                    double num2 = double.Parse(Console.ReadLine());

                    double resultado = 0;

                    switch (opcion)
                    {
                        case 1:
                            resultado = operaciones.Sumar(num1, num2);
                            break;
                        case 2:
                            resultado = operaciones.Restar(num1, num2);
                            break;
                        case 3:
                            resultado = operaciones.Multiplicar(num1, num2);
                            break;
                        case 4:
                            resultado = operaciones.Dividir(num1, num2);
                            break;
                    }

                    Console.WriteLine("El resultado es: " + resultado);
                }
                else if (opcion != 5)
                {
                    Console.WriteLine("Opción inválida. Por favor, elija una opción del 1 al 5.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inesperado: " + ex.Message);
            }

        } while (opcion != 5);
    }
}