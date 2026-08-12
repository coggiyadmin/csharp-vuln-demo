using Microsoft.EntityFrameworkCore;
public class EfRawSqliTp {
  public void Run(DatabaseFacade db, string id) {
    db.ExecuteSqlRaw("SELECT * FROM u WHERE id=" + id); // SINK
  }
}
