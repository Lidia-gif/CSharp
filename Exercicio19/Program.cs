using System;
using System.Collections.Generic;

public class Exercicio19
{

    public static void Main(string[] args)
    {
        //Variaveis Globais
        //Inicia o dicionário
        Dictionary<string, string> numero  = new Dictionary<string, string>();

        string opcao;
        do
        {
            //Menu principal
            Console.WriteLine("1.Adicionar contacto: ");
            Console.WriteLine("2.Pesquisar contacto: ");
            Console.WriteLine("3.Remover conttactos: ");
            Console.WriteLine("4.sair");

            // Pedir ao utilizador que escolha uma opção
            Console.WriteLine("\nEscolha a opção: ");


            //Obtem a opcao para usar no swich
             opcao = Console.ReadLine();


            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Nome: ");
                    String nome = Console.ReadLine();
                    Console.WriteLine("Contacto: ");
                    String contacto = Console.ReadLine();

                    numero.Add(nome, contacto);

                    Console.WriteLine("Número adicinado com sucesso! ");


                    break;


                case "2":
                    Console.WriteLine("Nome: ");
                    String nomePesquisado = Console.ReadLine();


                    if (numero.ContainsKey(nomePesquisado))// verifica se o contacto é true
                    {
                        Console.WriteLine($"\n numero: {numero[nomePesquisado]}");
                    }
                    else
                    {
                        Console.WriteLine("O contacto esta errado ");
                    }
                    break;

                case "3":
                    Console.WriteLine("Nome:");
                    nomePesquisado = Console.ReadLine();

                    if (numero.ContainsKey(nomePesquisado))
                    {
                        numero.Remove(nomePesquisado);
                    }
                    else
                    {
                        Console.WriteLine("Contacto não encontrado");
                    }
                    break;

                case "4":
                    Console.WriteLine("Sair");
                   

                    break;

                default:
                    Console.WriteLine("Opcao inválida");
                    break;

            }
        } while (opcao != "4");
        
    }
}
