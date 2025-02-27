using PhoneRepair.Exseptions;
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
    public partial class SessionEditorOrderPage : System.Web.UI.Page
    {
        public long orderId
        {
            get
            {
                if (Session["EditingOrderId"] == null)
                    return 0;
                return (long)Session["EditingOrderId"] ;
            }
        }
        public string PhoneNumber
        {
            get; set;
        }
        public string ErrorText
        {
            get;
            set;
        }

        public string ErrorDetails 
        {
            get;
            set;
        }

        public bool HasError 
        {
            get; 
            set;
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
            
            var order = Session["Order"] as PhoneOrder;
            order.Id = orderId;
            order.Breaking = BreakingControl1.BreakingInfo;
            
            
            try 
            {
                var repo = new OrderRepository(ConfigurationManager.ConnectionStrings["defaultConnection"].ToString());
                repo.UpdateOrder(order);
            }
            catch (OrderRepositoryException ex)
            {
                ShowOrderException(ex);
                return;
            }
            catch (DBException ex)
            {
                
                throw ex;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            Response.Redirect("OrdersPage.aspx");
        }

        private void ShowOrderException(OrderRepositoryException ex)
        {
            HasError = true;
            ErrorText = string.Format("Error #(2) for order #{0} client phone {1}", 
                ex.Order.Id, ex.Order.OrderPhoneNumber, ex.ID);
#if DEBUG
            ErrorDetails = string.Format("<b>Exceprion:</b> {0} <br/> <b>InnerException</b> {1}!",
                ex.ToString(), ex.InnerException == null ? "none" : ex.InnerException.ToString());
#endif
        }

        private void fillOrderData(long id)
        {
            var orders = (List < PhoneOrder >) Session["Orders"];
            var order = (from o in orders where o.Id == orderId select o).Single();
            Session["Order"] = order;
            BreakingControl1.SetBreakingInfo(order.Breaking);
      
            PhoneNumber = order.OrderPhoneNumber;
        }
    }
}