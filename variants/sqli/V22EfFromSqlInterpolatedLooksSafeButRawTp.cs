using Microsoft.EntityFrameworkCore;
// Architect note: FromSqlRaw with concat is the real TP; Interpolated is safe — this file is Raw.
public class V22EfFromSqlInterpolatedLooksSafeButRawTp {
  public void Run(DbSet<object> set, string id) {
    var sql = $"SELECT * FROM u WHERE id={id}"; // still concatenated into Raw
    set.FromSqlRaw(sql); // SINK CWE-89
  }
}
