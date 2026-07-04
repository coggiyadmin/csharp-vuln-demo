using System.Data.SQLite;
public class V02Safe {
  public void Run(string id) {
    var cmd = new SQLiteCommand("SELECT * FROM u WHERE id=@id", conn);
    cmd.Parameters.AddWithValue("@id", id);
    cmd.ExecuteReader();
  }
  static SQLiteConnection conn = new SQLiteConnection("Data Source=:memory:");
}
