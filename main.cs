using System.Collections.Generic;
using System;

class MainClass {
  public static void Main (string[] args) {
    Vendedor carlos = new Vendedor(2000, 1.35, "Carlos");

    Veiculo uno = new Veiculo(50000,"Fiat", 2020, 0);

    Mostruario secaoA = new Mostruario(carlos);

    //Mostruario secaoB = new Mostruario();

    secaoA.Carros.Add(uno);
    // secaoA.Carros.Add(uno);
    // secaoA.Carros.Add(uno);

    Console.WriteLine(secaoA.CalculaValor());
  }
}