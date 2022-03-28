using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class Service : System.Web.Services.WebService
{
    public Service () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }
	[WebMethod]
	public DateTime GetServerTime(string Url)
	{
		SampleWebServices m_SampleWebServices = new SampleWebServices(Url);
		return m_SampleWebServices.GetLocalDateTime();
	}
    
}
