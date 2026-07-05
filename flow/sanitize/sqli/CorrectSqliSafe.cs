public class CorrectSqliSafe {
  public void Run(string q) {
    var cmd = new System.Data.SQLite.SQLiteCommand("SELECT * FROM u WHERE id=@id", null);
    cmd.Parameters.AddWithValue("@id", q);
    cmd.ExecuteReader();
  }
}
