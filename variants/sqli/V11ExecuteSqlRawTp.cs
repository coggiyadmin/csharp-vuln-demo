using Microsoft.EntityFrameworkCore;
public class V11ExecuteSqlRawTp {
  public void Run(DbContext db, string id) {
    var sql = "DELETE FROM u WHERE id=" + id;
    db.Database.ExecuteSqlRaw(sql); // SINK CWE-89
  }
}
