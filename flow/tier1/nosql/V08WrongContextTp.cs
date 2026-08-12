using MongoDB.Bson;
using MongoDB.Driver;
public class V08WrongContextTp {
  public void Run(string input) {
    var v = input.Replace(";", "");
        var filter = "{ role: '" + v + "' }";
            col.Find(filter); // SINK CWE-943
  }
}
