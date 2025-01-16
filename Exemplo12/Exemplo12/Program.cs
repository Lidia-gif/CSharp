using System;

public class Exemplo12
{
  
 
      public static void Main(string[] args)
      {
        // Isto é um contador . Vai contar até 10
        int contador = 0;

        //Vamos fazer a lógica de exercicil12
        do
        {
            //Mostra em que número se encontra o contador
            Console.WriteLine(contador);

            // Isto aumenta o valor do computador
            contador++;
        }
        while (contador <= 10);
      }
}

