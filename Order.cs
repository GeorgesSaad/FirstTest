public class Order
{
  public Order()
  {
    orderLines = new List<OrderLine>();
  }
  
  public Order(Customer c)
  {
    customer = c;
    orderLines = new List<OrderLine>();
  }

  public string Number { get; set;}
  public DateTime Date { get; set;}
  
  private Customer customer;
  public Customer Customer
  { 
    get
    {
      return customer;
    }
    set
    {
      customer = value;
    }
  }
  private List<OrderLine> lines;
  public List<OrderLine> Lines
  {
    get
    {
      return orderLines;
    }
  }
  
  public Decimal Total
  {
    get
    {
      Decimal total = 0;
      foreach(var line in Lines)
        total += line.Quantity * line.UnitPrice;
      return total;
    }
  }
}
