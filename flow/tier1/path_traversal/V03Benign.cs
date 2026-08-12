using System.IO;
public class V03Benign {
  public void Run() {
    var txt = File.ReadAllText("/data/index.html");
  }
}
