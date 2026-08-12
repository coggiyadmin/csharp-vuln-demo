public class V02ConnectionStringSafe {
  public string Run() => System.Environment.GetEnvironmentVariable("SECRET") ?? "";
}
