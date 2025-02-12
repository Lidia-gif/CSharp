using System;

public class Exercicio17
{

    public static void Main(String[] args)
    {
         // criar um array dos nomes dos filmes
        String[]  listaFilmes = {" Harry Potter" ," Zorro", "Simpsons"};

        // Criar um array dos anos dos filmes
        int [] anos = { 1999, 2010, 2014 };

        // Percorre os dois arrays
        Console.WriteLine("Anos percorrida com for:");
        for (int contador = 0;  contador < anos.Length; contador++)
        {
            Console.WriteLine(anos [contador]+ " - " +listaFilmes[contador]);
        }
        
        
        
        
        

    }



}


