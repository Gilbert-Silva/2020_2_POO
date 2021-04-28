using System;
using System.IO;
using System.Collections.Generic;

class MainClass {
  public static void Main() {
    int erro;
    Diretoria d = new Diretoria();
    d.AbrirAmbientes("./Aula 04_28/diretoria.txt", out erro);
    foreach (Ambiente amb in d.Ambs)
      Console.WriteLine(amb.Id + " " + amb.Descricao);
    Console.WriteLine(erro); 
    throw new StudentQueryException("Teste"); 
  }
}

class Diretoria {
  private List<Ambiente> ambs = new List<Ambiente>();
  public List<Ambiente> Ambs { get { return ambs; } }
  public bool AbrirAmbientes(string arquivo, out int erro) {
    erro = 0;
    try {
      StreamReader f = new StreamReader(arquivo);
      string s = f.ReadLine();
      while (s != null) {
        string[] v = s.Split(',');
        int id = int.Parse(v[0]);
        string desc = v[1];
        Ambiente amb = new Ambiente();
        amb.Id = id;
        amb.Descricao = desc;
        ambs.Add(amb);
        s = f.ReadLine();
      }
      f.Close();
    }
    catch(ArgumentNullException) { erro = 1; }
    catch(FileNotFoundException) { erro = 2; }
    catch(DirectoryNotFoundException) { erro = 3; }
    catch(OutOfMemoryException) { erro = 4; }
    catch(IOException) { erro = 5; }
    return erro == 0;
  }
}

class Ambiente {
  public int Id { get; set; }
  public string Descricao { get; set; }
}
/*
class StudentQueryException : Exception {
  private string mensagem;
  public StudentQueryException(string msg) {
    mensagem = msg;
  }
  public string GetMensagem() {
    return mensagem;
  }
}
*/
class StudentQueryException : Exception {
  public StudentQueryException(string msg) : base(msg) {
  }
}
/* StudentQueryException em Java
class StudentQueryException : Exception {
  public StudentQueryException(string msg) {
    super(msg);
  }
}
*/
