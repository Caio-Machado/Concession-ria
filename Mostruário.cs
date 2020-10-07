using System.Collections.Generic;
using System;

class Mostruario {
  Vendedor Representante;
  public List<Veiculo> Carros;

  public void setRepresentante(Vendedor novoRepresentante){
    Representante = novoRepresentante;
  }

  public Mostruario(Vendedor v) {
    Representante = v;
    Carros = new List<Veiculo>();
  }
  
  public double CalculaValor () {
    double soma = 0;

    for (int i=0; i<Carros.Count;i++) {
      soma += Carros[i].getValor();
    }

    return soma;
  }
}