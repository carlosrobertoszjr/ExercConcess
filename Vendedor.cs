using System;

class Vendedor{
  private double salario;
  private double comissao;
  private string nome;


  //Set nome
  public void setNome(string n){
    nome = n;
  }
  //Get nome
  public string getNome(){
    return nome;
  }
  

  public Vendedor(string n, double s, double c){
    nome = n;
    salario = s;
    comissao = c;
  }



  public double receber_salario(double valor_total_vendas){
    return ((salario+comissao)*valor_total_vendas);
  }
  
}