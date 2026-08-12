public class ViewstateDeserSafe {
  public string Run(string payload) => System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(payload));
}
