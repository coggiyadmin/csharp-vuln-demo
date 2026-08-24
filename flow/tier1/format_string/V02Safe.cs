// SAFE — format_string: a second literal format — input stays in the argument list
public class V02Safe {
  static string Message;
  public void Run(string input) {
    Message = string.Format("user {0} signed in", input);
  }
}
