using MongoDB.Bson;
using MongoDB.Driver;
public class V02ValidateSafe {
  public void Run(string input) {
    col.Find(Builders<BsonDocument>.Filter.Eq("role", input));
  }
}
