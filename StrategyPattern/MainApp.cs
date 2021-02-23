using System;
class MainApp
{
    static void Main(){

        CalculateClient MinusClient = new CalculateClient(new Minus());
        CalculateClient PlusClient = new CalculateClient(new Plus());

        var result1 = MinusClient.Calculate(13, 5);
        Console.WriteLine($"Substraction of 5 from 13 is {result1}");
        var result2 = PlusClient.Calculate(13,5);
        Console.WriteLine($" Addition of 5 to 13 is {result2}");

    }
}