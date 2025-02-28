using System;
using System.Collections.Generic;

public class Exercicio19
{

    public static void Main(string[] args)
    {
        //Inicia o dicionário
        Dictionary<string, string> numero  = new Dictionary<string, string>();


        //Meno principal
        Console.WriteLine("1.Adicionar contacto: ");
        Console.WriteLine("2.Pesquisar contacto: ");
        Console.WriteLine("3.Remover conttactos: ");
        Console.WriteLine("4.sair");

        // Pedir ao utilizador que escolha uma opção
        Console.WriteLine("Escolha a opção: ");
       

        //Obtem a opcao para usar no swich
        string opcao = Console.ReadLine();
       

        switch (opcao)
        { 
              case "1" :
                Console.WriteLine("Nome: ");
                String nome = Console.ReadLine();
                Console.WriteLine("Contacto: ");
                String contacto = Console.ReadLine();
                Console.WriteLine("Número adicinado com sucesso! ");

                numero.Add(nome, contacto);
                break;

        
              case "2":
                Console.WriteLine("Pesquisar contacto: ");
                String pesquisarcontacto = Console.ReadLine();
               
                numero.ContainsKey(pesquisarcontacto);
                Console.WriteLine(pesquisarcontacto.Contains(pesquisarcontacto));
                break;

                if (pesquisarcontacto.Contains("pesquisarcontacto"))
                {
                    Console.WriteLine("Então o contacto esta correto");
                }

                else
                {
                    Console.WriteLine("O contacto esta errado ");
                }
        }
        
            

        
    }
}
