using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using PhoneRepair.Controls;
using static System.Net.Mime.MediaTypeNames;

namespace PhoneRepair.Administrator
{
    public partial class OrdersPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var repo = new OrderRepository(ConfigurationManager.ConnectionStrings["defaultConnection"].ToString());
                var orders = repo.GetAllOrders();
                Session["Orders"] = orders;
                rptOrders.ItemDataBound += rptOrders_ItemDataBound;
                rptOrders.DataSource = orders;
                rptOrders.DataBind();
               
            }
            
        }

        public void Change_Order_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == null)
                return;
           
            long orderID = long.Parse(btn.CommandArgument);
            Session["EditingOrderId"] = orderID;
            Response.Redirect($"SessionEditorOrderPage.aspx");
            
        }

        private void rptOrders_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            var order = e.Item.DataItem as PhoneOrder;
            var control = e.Item.FindControl("orderEditor") as OrderControl;
            control.Data = order;
            control.DataBind();
            var button = e.Item.FindControl("btnChangeOrder") as Button;
            button.CommandArgument = order.Id.ToString();
           


        }

    }
}