using MongoDB.Bson;
using MongoDB.Driver;
namespace Demo.Xfile.Nosql;
public static class XfNosqlController {
  public static void Handle(IMongoCollection<BsonDocument> col, string q) => XfNosqlHelper.Find(col, q);
}
