using System;
using System.Web.UI;
public class index : Page{
    public String orderId;
    public int a = 100;

    protected void Page_Load(object sender, EventArgs e){
        Guid uuid = Guid.NewGuid();
        orderId = uuid.ToString();
    }
}
