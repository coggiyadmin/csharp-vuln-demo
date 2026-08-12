using MongoDB.Bson;
using MongoDB.Driver;
public class V01BaselineSafe {
  public void Run(string input) {
    col.Find(Builders<BsonDocument>.Filter.Eq("role", input));
  }
}
