using System;

class MainClass {
  public static void Main (string[] args) { 
    Retangulo r = new Retangulo(10, 20);
    Retangulo x = new Retangulo();
    Console.WriteLine(r);
    Console.WriteLine(x);
    r.SetBase(30);
    r.SetAltura(40);
    r.Mostrar();
  }
}

class Retangulo { // : Object {
  private double b, h;
  public Retangulo() { }
  public Retangulo(double x, double y) {
    if (x > 0) this.b = x;
    if (y > 0) this.h = y;
  }
  public void SetBase(double b) {
    if (b > 0) this.b = b;
  }
  public void SetAltura(double h) {
    if (h > 0) this.h = h;
  }
  public void Mostrar() {
    Console.WriteLine($"Base = {b}, Altura = {h}");
  }
  public override string ToString() {
    //return "Olá, eu sou um retângulo";
    //return "Oi, eu sou um" + base.ToString();
    return $"Base = {b}, Altura = {h}";
  }
}