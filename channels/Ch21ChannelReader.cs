using System.Diagnostics; using System.Threading.Channels; using System.Threading.Tasks;
public class Ch21ChannelReader {
  public async Task Run(ChannelReader<string> r) {
    var cmd = await r.ReadAsync();
    Process.Start("sh", "-c " + cmd); // SINK Channel<T>
  }
}
