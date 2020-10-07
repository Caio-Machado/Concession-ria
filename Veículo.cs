using System;

class Veiculo {
  string marca;
  int ano;
  double valor;
  int KM;

  /*
  public Veiculo () {
    marca = "wolksvagem";
    ano = 2012;
    valor = 25000;
    KM = 0;
  }
  */

  public void AtualizaValor (int novoAno) {
    double novo_valor = valor - (novoAno - ano) * 2.05;
    valor = novo_valor;
  }

  public void Relatorio () {
    Console.WriteLine("A marca do carro é {0}.",marca);
    Console.WriteLine("O ano do carro é {0}.", ano);
    Console.WriteLine("O valor do carro é {0}", valor);
    Console.WriteLine("A Kilometragem do carro é {0}", KM);
  }

  public Veiculo (string m, int a, double v, int km) {
    marca = m;
    ano = a;
    valor = v;
    KM = km;
  }
}