using MongoDB.Bson;
using MongoDB.Driver;
namespace Demo.Xfile.Nosql;
public static class XfNosqlHelper {
  public static void Find(IMongoCollection<BsonDocument> col, string q) { col.Find(q); } // SINK
}
