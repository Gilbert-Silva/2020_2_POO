using System;

class Compromisso {
  public string Assunto {get;set;}
  public string Local {get;set;}
  public DateTime Data {get;set;}
  public override string ToString() {
    return $"{Assunto} - {Local} - {Data}";
  }
}

class Agenda {
  private Compromisso[] comps;
  private int k;
  public int Qtd { get { return k; } }
  public int K { get => k; }
  public int GetK() { return k; }
  public int GetK2() => k; 
  public Agenda() {
    comps = new Compromisso[10];
  }
  public void Inserir(Compromisso c) {
    if (k < 10) comps[k++] = c;
  }
  public Compromisso[] Listar() {
    return comps;
  }
}

class MainClass {
  public static void Main() {
    Compromisso c1 = new Compromisso();
    c1.Assunto = "Avaliação POO";
    c1.Local = "GSA";
    c1.Data = DateTime.Parse("2021-03-03");
    //Console.WriteLine(c1);
    Compromisso c2 = new Compromisso {
      Assunto = "CAP POO",
      Local = "GSA",
      Data = DateTime.Parse("2021-03-01 14:00")
    };
    //Console.WriteLine(c2);
    Agenda a = new Agenda();
    a.Inserir(c1);
    a.Inserir(c2);
    Compromisso[] v = a.Listar();
    for (int i = 0; i < a.Qtd; i++)
      Console.WriteLine(v[i]);
    for (int i = 0; i < a.GetK(); i++)
      Console.WriteLine(v[i]);
  }
}