using MongoDB.Bson;
using MongoDB.Driver;
public class BenignFlow {
  public void Run() {
    col.Find(Builders<BsonDocument>.Filter.Eq("role", "user"));
  }
}
