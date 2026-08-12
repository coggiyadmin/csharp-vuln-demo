using Microsoft.EntityFrameworkCore;
public class V40FromSqlInterpolatedSafe {
  public void Run(DbSet<object> set, string id) {
    set.FromSqlInterpolated($"SELECT * FROM u WHERE id={id}");
  }
}
