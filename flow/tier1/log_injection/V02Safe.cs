public class V02Safe {
  public void Run(string user) => Console.WriteLine("login user=" + new string(user.Where(char.IsLetterOrDigit).ToArray()));
}
