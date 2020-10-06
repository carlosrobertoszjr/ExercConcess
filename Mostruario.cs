using System.Collections.Generic;

class Mostruario {
  //TAD
  private Vendedor representante;
        //EST  <TAD>    VARIAVEL 
  public List<veiculo> carros;

  public Mostruario(){
    carros = new List<veiculo>();

  }

  public void setRepresentante(Vendedor v){
    representante = v;
  }


}