using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Vendedor carlos = new Vendedor("Carlos", 2000.34, 1.34);
    Veiculo uno = new Veiculo("Fiat", 2020, 0, 50000);

    Mostruario secaoA = new Mostruario(carlos);
    secaoA.carros.Add(uno);
    secaoA.carros.Add(uno);
    secaoA.carros.Add(uno);
    secaoA.carros.Add(uno);

    double soma = 0;

    for (int i=0;i<secaoA.carros.Count;i++){
        soma+=secaoA.carros[i].getValor();
    }

    Console.WriteLine("SOMA >> {0}", soma);




 /* EXPLICACAO LISTA */
    //List<int> meuNumeros = new List<int>{10,20,30,40};
    //meuNumeros.Add(100);
    //Console.WriteLine(meuNumeros.Count);

    //int tot = 0;
    //for(int i=0;i<meuNumeros.Count;i++)
      //Console.WriteLine("Elemento {0} >> {1}", i, meuNumeros[i]);
    //  tot+=meuNumeros[i];
    //Console.WriteLine(tot);

  }
}