using System;

class Vendedor {
  double salario;
  double comissao;

  /*
  public Vendedor () {
    salario = 2500;
    comissao = 150;
  }
  */

  public double ReceberSalario (double ValorTotalVendas) {
    return salario + comissao * ValorTotalVendas;
  }
}