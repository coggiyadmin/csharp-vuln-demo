using MongoDB.Bson;
using MongoDB.Driver;
public class WrongSanNosqlTp {
  public void Run(string input, IMongoCollection<BsonDocument> col) {
    var v = input.Replace(";", ""); // wrong/partial
    col.Find(v); // SINK string filter
  }
}
