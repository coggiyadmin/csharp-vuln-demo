using System;
using System.Web;
public class Cases
{
    public void Bad(HttpRequest req, HttpResponse resp)
    {
        string data = Console.ReadLine();
        Sinks.BadSink(data, req, resp);
    }
}
