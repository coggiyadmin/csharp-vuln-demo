using System.Data.SQLite;
public class V01BaselineTp {
  public void Run(string id) {
    new SQLiteCommand("SELECT * FROM u WHERE id='" + id + "'", conn).ExecuteReader(); // SINK
  }
  static SQLiteConnection conn = new SQLiteConnection("Data Source=:memory:");
}
