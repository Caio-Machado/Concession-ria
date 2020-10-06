using System.Collections.Generic;

class Mostruario {
  Vendedor Representante;
  List<Veiculo> Carros;

  public void setRepresentante(Vendedor novoRepresentante){
    Representante = novoRepresentante;
  }

  public Mostruario() {
    Carros = new List<Veiculo>();
  }
  

}