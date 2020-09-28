using System;

class MainClass {
  public static void Main (string[] args) {
    double l, d, v, t;
  Console.WriteLine("\n Exercício D");
  Console.WriteLine("Os valores de velocidade media, tempo gasto na viagem a distancia percorrida e a quantidade de litros gastos na viagem.");
 
  Console.WriteLine("Digite o tempo em horas:");
  t = double.Parse(Console.ReadLine());
  Console.WriteLine("Digite a velocidade media em km/h");
  v = double.Parse(Console.ReadLine());
  
  d = v * t; //calculando a distancia
  l = d / 12; // calculando litros 
  
  //LITROS_USADOS ←DISTANCIA / 12
  Console.WriteLine("A velocidade media foi de: " + v + "km/h");
  Console.WriteLine("O tempo gasto foi de: " + t +  "horas");
  Console.WriteLine("A distancia percorrida foi de: " + d + "km");
  Console.WriteLine("Quantidade de litros gastos nesta viagem foi de: " + l + " Litros");

  }
}