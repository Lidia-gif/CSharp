using System;

public class Exercicio17
{

    public static void Main(String[] args)
    {
        // criar um array dos nomes das cidades
        String[] cidades = { " Lisboa", " Porto", "Coimbra", "Faro", "Braga" };

        // Criar um array dos anos dos habitantes
        int[] habitantes = { 545000, 237000, 143000, 118000, 193000 };

        // Percorre os dois arrays
        Console.WriteLine("As cidades e as suas populações:");
        for (int contador = 0; contador < cidades.Length; contador++)
        {
            Console.WriteLine(cidades[contador] + " - " + habitantes[contador]+" habitantes ");
        }


    }
}