using System;
using System.Collections.Generic;
using System.Configuration;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PhoneRepair.Administrator
{
    public partial class EditorOrder : System.Web.UI.Page
    {
        public long orderId
        {
            get
            {
                long id = 0;
                if (long.TryParse(Request.Params["id"], out id))
                    return id;
                else return 0;
            }
        }
        public string PhoneNumber
        {
            get; set;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (orderId != 0)
                {
                    fillOrderData(orderId);
                }
                else
                {
                    Response.Redirect("OrdersPage.aspx");
                }
            }
            btnSave.Click += BtnSave_Click;
     
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            
            var repo = new OrderRepository(ConfigurationManager.ConnectionStrings["defaultConnection"].ToString());
            var order = repo.GetOrder(orderId); ;
            order.Breaking = BreakingControl1.BreakingInfo;
            repo.UpdateOrder(order);

            Response.Redirect("OrdersPage.aspx");
        }

        private void fillOrderData(long id)
        {
            var repo = new OrderRepository(ConfigurationManager.ConnectionStrings["defaultConnection"].ToString());
            var order = repo.GetOrder(id);
            BreakingControl1.SetBreakingInfo(order.Breaking);
      
            PhoneNumber = order.OrderPhoneNumber;
        }
    }
}