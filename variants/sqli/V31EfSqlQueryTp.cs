using Microsoft.EntityFrameworkCore;
public class V31EfSqlQueryTp {
  public void Run(DatabaseFacade db, string id) {
    var sql = "SELECT * FROM u WHERE id=" + id;
    db.ExecuteSqlRaw(sql); // SINK CWE-89
  }
}
