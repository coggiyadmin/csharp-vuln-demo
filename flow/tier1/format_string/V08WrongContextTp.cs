public class V08WrongContextTp {
  public void Run(string input) {
    var v = input.Replace(";", "");
        String.Format(v, 1); // SINK CWE-134
  }
}
