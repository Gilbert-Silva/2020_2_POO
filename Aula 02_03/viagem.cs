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
