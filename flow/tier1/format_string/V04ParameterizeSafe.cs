// SAFE — format_string: constant composite format with input supplied positionally
public class V04ParameterizeSafe {
  static string Message;
  public void Run(string input) {
    Message = string.Format("{0} / {1}", input, 1);
  }
}
