using System;

class MainClass {
  public static void Main() {
    Frete f = new Frete(50, 80);
    Console.WriteLine(f);
    Console.WriteLine(f.ValorFrete);
    FreteExpresso x = new FreteExpresso(10, 100, 200);
    Console.WriteLine(x);
    Console.WriteLine(x.ValorFrete);
  }
}

class Frete : object {
  private double distancia, peso;
  public Frete(double distancia, double peso) { 
    this.distancia = distancia;
    this.peso = peso;
  }
  public virtual decimal ValorFrete {
    get { return Convert.ToDecimal(0.01 * distancia * peso); }
  }
  public double GetDistancia() {
    return distancia;
  }
  public override string ToString() {
    return $"{distancia} {peso}";
  }
}

class FreteExpresso : Frete {
  private decimal seguro;
  public FreteExpresso(double distancia, double peso, decimal seguro) : base(distancia, peso)
  {
    this.seguro = seguro;
  }
  public override decimal ValorFrete {
    get { return base.ValorFrete * 2 + 0.01M * seguro; }
  }
  public override string ToString() {
    return $"{base.ToString()} {seguro}";
  }
}

//object::ToString()