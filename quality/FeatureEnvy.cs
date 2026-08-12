// Hygiene — feature envy: method uses other type's data heavily.
public class Customer {
  public string Name, Email, Phone, Address, Zip;
}
public class ReportPrinter {
  public string PrintHeader(Customer c) =>
    c.Name + c.Email + c.Phone + c.Address + c.Zip; // envy of Customer fields
}
