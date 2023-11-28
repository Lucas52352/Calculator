namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2;


            string operation;

            Console.WriteLine("Ingrese el primer numero: ");

            while (!float.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Entrada no válida. Porfavor ingrese un numero: ");
            }

            Console.WriteLine("Ingrese la operacion que desea realizar ( + , - , * , / ): ");
            operation = Console.ReadLine();

            Console.WriteLine("Ingrese el segundo numero: ");

            while (!float.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Entrada no válida. Porfavor ingrese un numero: ");
            }

            float result;
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;

                case "-":
                    result = num1 - num2;
                    break;

                case "*":
                    result = num1 * num2;
                    break;

                case "/":

                    if(num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por cero.");
                        return;

                    }
                    break;

                default:
                    Console.WriteLine("Operacion no valida.");
                    return;
            }

            Console.WriteLine("Resultado: " + num1 + " " + operation + " " + num2 + " = " + result);

        }
    }
}