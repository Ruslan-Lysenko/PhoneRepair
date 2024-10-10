using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PhoneRepair.Administrator
{
    public class OrderInfo
    {
        public string LastOrderName { get; set; }
        public string LastOrderNumber { get; set; }
    }
    public partial class OrdersPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string lastOrderName = Session["LastOrderName"] as string;
                string lastOrderNumber = Session["LastOrderNumber"] as string;

                
                var ordersList = new List<OrderInfo>
                {
                    new OrderInfo
                    {
                        LastOrderName = lastOrderName,
                        LastOrderNumber = lastOrderNumber
                    }
                };

                rptOrders.DataSource = ordersList;
                rptOrders.DataBind();
            }
        }
    }
}
