// SAFE — sqli variant: Dapper with a DynamicParameters bag.
using Dapper;
using System.Data;
public class V30DapperParamSafe {
  public object Run(IDbConnection db, string id) {
    var p = new DynamicParameters();
    p.Add("@id", id, DbType.String, size: 64);
    return db.Query("SELECT * FROM u WHERE id=@id", p);
  }
}
