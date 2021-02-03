using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");

    Pessoa x; // x armazena um endereço de memória
              // x é uma referência
    int i;
    x = new Pessoa();
    x.matricula = "20201014040001";
    // x tem um endereço de memória onde está
    // uma variádel da classe Pessoa (objeto/instância)
    i = 10; // tem um valor 10 na memória
    Console.WriteLine(i);
    Console.WriteLine(i.ToString());
    Console.WriteLine(x);
    Console.WriteLine(x.ToString());
    //int    - é um tipo de variável
    //Pessoa - é um tipo de variável              
    Data d = new Data();
    d.dia = 31;
    d.mes = 2;
    d.ano = 2021;
    d.SetData(31, 2, 2021);
  }
}

class Pessoa {
  public string matricula;
}

class Data {
  public int dia, mes, ano; 
  public void SetData(int d, int m, int a) {
    // escrever algoritmo para validar
  }
}