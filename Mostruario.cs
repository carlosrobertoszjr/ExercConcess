using System.Collections.Generic;

class Mostruario {
  //TAD
  private Vendedor representante;
        //EST  <TAD>    VARIAVEL 
  public List<Veiculo> carros;

  public Mostruario(Vendedor v){
    representante = v;
    carros = new List<Veiculo>();
    

  }

  public void setRepresentante(Vendedor v){
    representante = v;
  }
  


}