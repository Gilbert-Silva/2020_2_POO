using System;
using System.Threading;
using System.Globalization;

class Contato {
  public string Nome {get;set;}
  public DateTime Nasc {get;set;}
  public override string ToString() {
    return $"{Nome} {Nasc}";
  }
}

enum SituacaoTarefa {
  nada, fizParte, fizTudo
}

[Flags]
enum Dias {
  vaz, dom = 1, seg = 2, ter = 4, qua = 8, qui = 16, sex = 32, sab = 64
}

class MainClass {
  public static void Main (string[] args) { 
    Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");  

    Dias ds = Dias.dom | Dias.seg | Dias.ter;
    Console.WriteLine(ds);

    if ((ds & Dias.seg) != 0) Console.WriteLine("OK");

    int x = (int) SituacaoTarefa.fizTudo;
    Console.WriteLine(x);

    Contato a = new Contato();
    Contato b = new Contato{ Nome="nome" };
    Console.WriteLine(a);
    Console.WriteLine(b);

/*

    SituacaoTarefa st;
    st = SituacaoTarefa.nada;
    Console.WriteLine(st);

    Console.WriteLine("Informe a data do nascimento");
    string s = Console.ReadLine();
    DateTime dn = DateTime.Parse(s);
    Console.WriteLine($"Você nasceu numa {dn:dddd}");


    DateTime x = DateTime.Parse("10/05/2021 07:00");
    DateTime y = DateTime.Now;
    DateTime z = new DateTime(2020, 1, 30);
    Console.WriteLine(z);
    z = z.AddDays(30);
    Console.WriteLine(z);

    Console.WriteLine(x);
    Console.WriteLine(y);
    Console.WriteLine(z);

    Console.WriteLine(z.ToString("dd/MM/yyyy"));
    Console.WriteLine(z.ToString("dd"));
    Console.WriteLine(z.ToString("ddd"));
    Console.WriteLine(z.ToString("dddd"));
    Console.WriteLine(z.ToString("MM"));
    Console.WriteLine(z.ToString("MMM"));
    Console.WriteLine(z.ToString("MMMM"));
    Console.WriteLine(z.ToString("hh"));
    Console.WriteLine(z.ToString("mm"));
    Console.WriteLine(z.ToString("ss"));

    TimeSpan t = new TimeSpan (2, 0, 0, 0);
    for (int i = 1; i <= 6; i++) {
      Console.WriteLine(z);
      z = z + t;
    }
    
    for (int i = 1; i <= 6; i++) {
      Console.WriteLine(z);
      z = z.AddMonths(1);
    }

    t = new TimeSpan (1, 6, 30, 50);
    Console.WriteLine(t);
    z = z.Add(t);
    Console.WriteLine(z);
    z = z + t;
    Console.WriteLine(z);
  */
    


  }
}
