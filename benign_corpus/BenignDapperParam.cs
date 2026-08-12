using Dapper;
using System.Data;
public class BenignDapperParam {
  public object Run(IDbConnection db, int id) =>
    db.Query("SELECT name FROM users WHERE id=@id", new { id });
}
