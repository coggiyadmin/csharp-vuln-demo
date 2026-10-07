using System.Data;
public class V42DataTableExprTp {
  public object Run(string expr) {
    return new DataTable().Compute(expr, ""); // SINK expression eval
  }
}
