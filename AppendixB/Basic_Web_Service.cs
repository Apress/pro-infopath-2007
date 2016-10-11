 [WebMethod(Description = "Get a Customer's Detail")]
 public Customer GetCustomer(string CustomerID)
 {
        Customer cust = new Customer(CustomerID);

        return cust;
 }

public class Customer
{
    public Customer()
    {
        //default empty constructor
    }

    public Customer(string CustomerID)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString; 

        SqlConnection cxn = new SqlConnection(connectionString);

        string sqlQuery = "SELECT [CustomerID] " +
            ",[CompanyName] " +
            ",[ContactName] " +
            ",[ContactTitle] " +
            ",[Address] " +
            ",[City] " +
            ",[Region] " +
            ",[PostalCode] " +
            ",[Country] " +
            ",[Phone] " +
            ",[Fax] " +
            "FROM [Northwind].[dbo].[Customers] " +
            "WHERE CustomerID='" + CustomerID + "'";

        SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cxn);
        DataTable dt = new DataTable();
        da.Fill(dt);

        this.m_CustomerID = CustomerID;
        this.m_CompanyName = dt.Rows[0]["CompanyName"].ToString();
        this.m_ContactName = dt.Rows[0]["ContactName"].ToString();
        this.m_ContactTitle = dt.Rows[0]["ContactTitle"].ToString();
        this.m_Address = dt.Rows[0]["Address"].ToString();
        this.m_City = dt.Rows[0]["City"].ToString();
        this.m_Region = dt.Rows[0]["Region"].ToString();
        this.m_PostalCode = dt.Rows[0]["PostalCode"].ToString();
        this.m_Country = dt.Rows[0]["Country"].ToString();
        this.m_Phone = dt.Rows[0]["Phone"].ToString();
    }

    private string m_CustomerID;
    private string m_CompanyName;

    public string CompanyName
    {
        get { return m_CompanyName; }
        set { m_CompanyName = value; }
    }
    private string m_ContactName;

    public string ContactName
    {
        get { return m_ContactName; }
        set { m_ContactName = value; }
    }
    private string m_ContactTitle;

    public string ContactTitle
    {
        get { return m_ContactTitle; }
        set { m_ContactTitle = value; }
    }
    private string m_Address;

    public string Address
    {
        get { return m_Address; }
        set { m_Address = value; }
    }
    private string m_City;

    public string City
    {
        get { return m_City; }
        set { m_City = value; }
    }
    private string m_Region;

    public string Region
    {
        get { return m_Region; }
        set { m_Region = value; }
    }
    private string m_PostalCode;

    public string PostalCode
    {
        get { return m_PostalCode; }
        set { m_PostalCode = value; }
    }
    private string m_Country;

    public string Country
    {
        get { return m_Country; }
        set { m_Country = value; }
    }
    private string m_Phone;

    public string Phone
    {
        get { return m_Phone; }
        set { m_Phone = value; }
    }

    public string CustomerID
    {
        get { return m_CustomerID; }
        set { m_CustomerID = value; }
    }

}
