namespace Demo.Xfile.Ldap;
public static class XfLdapController {
  public static void Handle(string user) => XfLdapHelper.Search(user);
}
