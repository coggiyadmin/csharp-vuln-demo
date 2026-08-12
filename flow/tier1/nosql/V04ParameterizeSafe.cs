using MongoDB.Bson;
using MongoDB.Driver;
public class V04ParameterizeSafe {
  public void Run(string input) {
    col.Find(Builders<BsonDocument>.Filter.Eq("role", input));
  }
}
