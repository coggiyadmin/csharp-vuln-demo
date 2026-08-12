using Dapper; using System.Data;
public class V30DapperParamSafe {
  public object Run(IDbConnection db, string id) =>
    db.Query("SELECT * FROM u WHERE id=@id", new { id });
}
