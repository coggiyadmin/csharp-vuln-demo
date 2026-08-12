using Dapper;
using System.Data;
public class V21DapperExecuteTp {
  public int Run(IDbConnection db, string id) {
    var sql = "DELETE FROM u WHERE id=" + id;
    return db.Execute(sql); // SINK CWE-89
  }
}
