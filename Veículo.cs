using System;

class Veiculo {
  string marca;
  int ano;
  string valor;
  int KM;

  /*
  public Veiculo () {
    marca = "wolksvagem";
    ano = 2012;
    valor = 25000;
    KM = 0;
  }
  */

  public static void AtualizaValor (int novoAno) {
    novo_valor = valor - (novoAno - ano) * 2.05;
    valor = novo_valor;
  }

  public static void Relatorio () {
    Console.WriteLine("A marca do carro é {0}.",marca);
    Console.WriteLine("O ano do carro é {0}.", ano);
    Console.WriteLine("O valor do carro é {0}", valor);
    Console.WriteLine("A Kilometragem do carro é {0}", KM);
  }
}