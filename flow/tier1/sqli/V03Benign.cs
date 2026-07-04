using System.Data.SQLite;
public class V03Benign {
  public void Run() { new SQLiteCommand("SELECT 1", conn).ExecuteScalar(); }
  static SQLiteConnection conn = new SQLiteConnection("Data Source=:memory:");
}
