using System.Net.Mail;
public class V42SmtpHeaderTp {
  public void Run(string subject) {
    var msg = new MailMessage();
    msg.Subject = subject; // SINK CRLF mail header
  }
}
