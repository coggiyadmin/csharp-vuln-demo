using MongoDB.Bson;
using MongoDB.Driver;
public class SafeSanitizerNosql {
  public void Run(string input, IMongoCollection<BsonDocument> col) {
    _ = input; // sanitized / no sink
  }
}
