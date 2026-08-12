public class V02ConnectionStringTp {
  const string Conn = "Server=db;User Id=sa;Password=SuperSecret123!;"; // SINK CWE-798
  public string Run() => Conn;
}
