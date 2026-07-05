public class LoopSqliTp {
  public void Run(string q) {
    var acc = "";
    foreach (var ch in q) acc += ch; // loop-carried
    new System.Data.SQLite.SQLiteCommand("SELECT * FROM u WHERE id='" + acc + "'", null).ExecuteReader(); // SINK CWE-89
  }
}
