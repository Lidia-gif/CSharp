using System;

public class Teste1
{

    public static void Main(string[] args)
    {
        //Array
        int[] idadeAlunos = { 10, 15, 17, 19 };

        // percorrida array com for
        Console.WriteLine("Idade percorrida com for:");
        for(int contador = 0; contador < idadeAlunos.Length; contador++)
        {
            Console.WriteLine(idadeAlunos[contador]);
        }

        //Percorre o array com foreach
        Console.WriteLine("Idade percorrida com foreach:");
        foreach(int idade in idadeAlunos)
        {
            Console.WriteLine(idade);
        }
    }





}