using System.Data.SqlClient;
using System.Web;
public class Sinks
{
    public static void BadSink(string data, HttpRequest req, HttpResponse resp)
    {
        using (SqlCommand cmd = new SqlCommand(null, Db.Conn()))
        {
            cmd.CommandText = "select * from users where name='" + data + "'";
            object r = cmd.ExecuteScalar();
        }
    }
}
