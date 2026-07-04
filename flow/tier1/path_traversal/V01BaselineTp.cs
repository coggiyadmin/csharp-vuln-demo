public class V01BaselineTp {
  public byte[] Run(string p) => File.ReadAllBytes("/var/www/" + p); // SINK CWE-22
}
