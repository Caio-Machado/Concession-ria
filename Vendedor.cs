using System;

class Vendedor {
  double salario;
  double comissao;
  string nome;

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

  public void setNome (string n) {
    nome = n;
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

  public Vendedor (double s, double c, string n) {
    salario = s;
    comissao = c;
    nome = n;
  }
}