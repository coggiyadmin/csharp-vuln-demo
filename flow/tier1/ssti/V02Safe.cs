using System.Net;
public class V02Safe { public string Run(string name) => "Hello " + WebUtility.HtmlEncode(name); }
