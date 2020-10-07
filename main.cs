using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Vendedor carlos = new Vendedor(2000, 1.35, "Carlos");

    Veiculo uno = new Veiculo("Fiat", 2020, 0, 50000);

    Mostruario secaoA = new Mostruario(carlos);

    secaoA.Carros.Add(uno);
  }
}