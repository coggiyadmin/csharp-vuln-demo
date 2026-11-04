using System.Web;
public class Cases
{
    public void GoodG2B(HttpRequest req, HttpResponse resp)
    {
        string data = "foo";
        Sinks.GoodG2BSink(data, req, resp);
    }
}
