using System;

public class Exercicio20
{

    public static void Main(string[] args)
    {
        //converter um double para um int
        double numeroDecimal = 2.55;
        int decimalToInt = Convert.ToInt32(Convert.ToInt32((double)numeroDecimal));
      
        Console.WriteLine("Decimal:" + numeroDecimal + " To Integer Convert:  " + decimalToInt);


        //2.O que acontece se usar um número grande ao convertee um long para um int?
        long numeroMuitolong = 10000000000000;
        // int longToIntConvert = Convert.ToInt32(numeroMuitolong);
        int longInt = (int)numeroMuitolong;

        // Console.Writeline("long: " + numeroMuitolong + " To Integer convert:" + longToIntConvert
        Console.WriteLine("Long: " + numeroMuitolong + "To Integer casting:  " + longInt);

        //3. Qual é o valor ASCII da letra ´B´?
        char letra = 'B';
        int numeroASCIICasting = (int)letra;
        int numeroASCIIConvert = Convert.ToInt32(letra);

        Console.WriteLine("Character: " + letra + "To Int ASCII casting:  " + numeroASCIICasting);
        Console.WriteLine("Character: " + letra + "To Int ASCII convert:  " + numeroASCIIConvert);

        //4. Por que razao não é possível converter um int para um byte sem fazer cast?
        int numeroInt = 356;
        byte numeroByteCasting = (byte)numeroInt;
        //byte numeroByteConvert = Convert.ToByte(numeroInt);

        Console.WriteLine("Integer: " + numeroInt + "To Byte casting:  " + numeroByteCasting);

    
        // Console.WriteLine("Integer: " + numeroInt + "To Byte convert:  " + numeroByteConvert);

        //Converte um double para um float
        double numeroDouble = 1234.56789;
        float numeroFloatCasting = (float)numeroDouble;
        float numeroFloatConvert = Convert.ToSingle(numeroDouble);

        Console.WriteLine("Double: " + numeroDouble + "To Float casting:  " + numeroFloatCasting);
        Console.WriteLine("Double: " + numeroDouble + "To Float convert:  " + numeroFloatConvert);
    }
}