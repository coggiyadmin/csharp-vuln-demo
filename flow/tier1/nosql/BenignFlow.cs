using MongoDB.Bson;
using MongoDB.Driver;
public class V03Benign {
  public void Run() {
    col.Find(Builders<BsonDocument>.Filter.Eq("role", "user"));
  }
}
