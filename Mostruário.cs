using System.Collections.Generic;

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
  

}