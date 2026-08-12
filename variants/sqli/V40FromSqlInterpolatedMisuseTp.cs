using Microsoft.EntityFrameworkCore;
public class V40FromSqlInterpolatedMisuseTp {
  // Intentionally wrong — string concat into FromSqlRaw
  public void Run(DbSet<object> set, string id) {
    set.FromSqlRaw("SELECT * FROM u WHERE id=" + id); // SINK
  }
}
