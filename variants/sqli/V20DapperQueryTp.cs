using Dapper;
using System.Data;
public class V20DapperQueryTp {
  public object Run(IDbConnection db, string id) {
    var sql = "SELECT * FROM u WHERE id=" + id;
    return db.Query(sql); // SINK CWE-89 Dapper
  }
}
