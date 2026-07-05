public class WrongSqliTp {
  public void Run(string q) {
    var v = q.Replace(";", ""); // wrong sanitizer
    new System.Data.SQLite.SQLiteCommand("SELECT * FROM u WHERE id='" + v + "'", null).ExecuteReader(); // SINK CWE-89
  }
}
