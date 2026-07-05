public class OopSqliTp {
  class Holder { public string V; public Holder(string v){V=v;} }
  public void Run(string q) {
    var h = new Holder(q);
    new System.Data.SQLite.SQLiteCommand("SELECT * FROM u WHERE id='" + h.V + "'", null).ExecuteReader(); // SINK CWE-89
  }
}
