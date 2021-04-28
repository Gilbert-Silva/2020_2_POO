using System;

class MainClass {
  public static void Main() {
    Triangulo t = new Triangulo();
    try {
      t.SetBase(double.Parse(Console.ReadLine()));
    }
    catch (ArgumentOutOfRangeException) {

    }
    catch (FormatException) {

    }
  }
}

class MinhaClassedeErro : Exception {
  
}

class Triangulo {
  private double b;
  public void SetBase(double b) {
    if (b >= 0) this.b = b;
    else
      throw new ArgumentOutOfRangeException("msg");
  }
}