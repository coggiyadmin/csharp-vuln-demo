// SAFE — documented public APIs.
/// <summary>Order totaling helpers.</summary>
public class SafeDocumentedApi {
  /// <summary>Return order total including tax and shipping.</summary>
  public double ComputeTotal(double[] prices, double taxRate, double ship) {
    double sub = 0; foreach (var p in prices) sub += p;
    return sub + sub * taxRate + ship;
  }
  /// <summary>Serialize rows to CSV using delimiter.</summary>
  public string ExportCsv(string[][] rows, string delimiter) {
    var lines = new System.Collections.Generic.List<string>();
    foreach (var r in rows) lines.Add(string.Join(delimiter, r));
    return string.Join("\n", lines);
  }
}
