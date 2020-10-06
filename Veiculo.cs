using System;

class Veiculo{
  public string marca;
  public int ano;
  public double valor;
  public int KM;

  
public void relatorio(){
  Console.WriteLine(marca);
  Console.WriteLine(ano);
  Console.WriteLine(valor);
  Console.WriteLine(KM);
}

public double atualiza_valor(double novo_ano){
  double novo_valor = (valor - (novo_ano - ano))*2.05;
  return novo_valor;
}

}