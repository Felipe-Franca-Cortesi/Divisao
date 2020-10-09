using System;

namespace Divisao
{
    class Program
    {
        static void Main(string[] args)
        {
            double numerador, denominador, resultadoFinal;
            string textoNumerador, textoDenominador;
            bool numeradorValido, denominadorValido;

            Console.Clear();
            Console.WriteLine("--- Divisão");

            Console.Write("Digite o numerador....: ");
            textoNumerador = Console.ReadLine();

            Console.Write("Digite o denominador..: ");
            textoDenominador = Console.ReadLine();

            numeradorValido = double.TryParse(textoNumerador, out numerador);
            denominadorValido = double.TryParse(textoDenominador, out denominador);

            if (!numeradorValido)
            {
                Console.WriteLine("Valor inválido");
            }
            else if (!denominadorValido)
            {
                Console.WriteLine("Valor inválido");
            }
            else if(denominador == 0)
            {
                Console.Clear();
                Console.WriteLine($"Numerador: {numerador}\nDenominador: {denominador}\nNão é possível dividir por zero");
            }
            else if (numerador == 0)
            {
                Console.Clear();
                Console.WriteLine($"Numerador: {numerador}\nDenominador: {denominador}\n{numerador} dividido por {denominador} é 0");
            }
            else
            {
                Console.Clear();
                resultadoFinal = numerador / denominador;
                Console.WriteLine($"Numerador: {numerador}\nDenominador: {denominador}\n{numerador} dividido por {denominador} é {resultadoFinal}");
            }
        
    

       }
        
    }
}

