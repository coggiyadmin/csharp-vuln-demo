using MongoDB.Bson;
using MongoDB.Driver;
public class V01BaselineTp {
  public void Run(string input) {
    var filter = "{ role: '" + input + "' }";
        col.Find(filter); // SINK CWE-943
  }
}
