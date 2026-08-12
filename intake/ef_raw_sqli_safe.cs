using Microsoft.EntityFrameworkCore;
public class EfRawSqliSafe {
  public void Run(DatabaseFacade db, string id) {
    db.ExecuteSqlInterpolated($"SELECT * FROM u WHERE id={id}");
  }
}
