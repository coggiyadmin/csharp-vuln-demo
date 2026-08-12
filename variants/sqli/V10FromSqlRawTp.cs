using Microsoft.EntityFrameworkCore;
public class V10FromSqlRawTp {
  public void Run(DbSet<object> set, string id) {
    var sql = "SELECT * FROM u WHERE id=" + id;
    set.FromSqlRaw(sql); // SINK CWE-89
  }
}
