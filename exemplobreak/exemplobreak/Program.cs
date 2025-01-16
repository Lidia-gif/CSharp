using System;

 

  public class exemplobreak
    {
        public static void Main(string[] args)
        {
        //loop Aninhado
        for(int contador =1; contador <= 10; contador++)
        {
            if (contador == 5)
            {
                break;
            }
        }   Console.WriteLine("contador");
        }
    }

