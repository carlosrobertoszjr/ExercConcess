using System;

class Vendedor{
  double salario;
  double comissao;
  




public double receber_salario(double valor_total_vendas){
  return ((salario+comissao)*valor_total_vendas);
}
  
}