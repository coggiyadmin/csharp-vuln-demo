using Dapper; using System.Data;
public class V30DapperQueryFirstTp {
  public object Run(IDbConnection db, string id) {
    var sql = "SELECT * FROM u WHERE id=" + id;
    return db.QueryFirst(sql); // SINK CWE-89
  }
}
