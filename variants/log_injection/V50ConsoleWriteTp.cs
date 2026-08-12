using System;
public class V50ConsoleWriteTp {
  public void Run(string user) => Console.WriteLine("login=" + user); // SINK CWE-117
}
