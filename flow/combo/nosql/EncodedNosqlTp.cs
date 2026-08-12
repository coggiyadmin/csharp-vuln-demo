using MongoDB.Bson;
using MongoDB.Driver;
public class EncodedNosqlTp {
  public void Run(string input, IMongoCollection<BsonDocument> col) {
    var v = System.Uri.UnescapeDataString(System.Uri.EscapeDataString(input));
    col.Find(v); // SINK string filter
  }
}
