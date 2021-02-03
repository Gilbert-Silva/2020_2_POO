using System;

class MainClass {
  public static void Main (string[] args) { 
    Viagem x;
    x = new Viagem();
    //x.distancia = 300;
    //x.tempo = -4;
    x.SetDistancia(300);
    x.SetTempo(-4);
    Console.WriteLine(x.VelocidadeMedia());
  }
}

class Viagem {
  private double distancia;
  private double tempo;
  public void SetDistancia(double d) {
    if (d > 0) distancia = d;
  }
  public void SetTempo(double t) {
    if (t > 0) tempo = t;
  }
  public double VelocidadeMedia() {
    return distancia/tempo;
  }
}