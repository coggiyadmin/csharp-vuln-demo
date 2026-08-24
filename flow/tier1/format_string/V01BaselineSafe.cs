// SAFE — format_string: format string is a literal; input is an argument
public class V01BaselineSafe {
  static string Message;
  public void Run(string input) {
    Message = string.Format("value: {0}", input);
  }
}
