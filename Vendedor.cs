using System;

class Vendedor{
  public double salario;
  public double comicao;
  




public double receber_salario(double valor_total_vendas){
  return ((salario+comicao)*valor_total_vendas);
}
  
}