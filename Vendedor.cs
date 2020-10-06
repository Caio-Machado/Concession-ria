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

  public void setSalario (double novoSalario) {
    salario = novoSalario;
  }

  public void setComissao (double novaComissao) {
    comissao = novaComissao;
  }


  public double getSalario () {
    return salario;
  }

  public double getComissao () {
    return comissao;
  }

  public double ReceberSalario (double ValorTotalVendas) {
    return salario + comissao * ValorTotalVendas;
  }
}