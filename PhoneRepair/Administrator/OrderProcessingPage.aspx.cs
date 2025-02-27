using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Configuration;

namespace PhoneRepair.Administrator
{
    public partial class OrderProcessingPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            // Добавляем обработчики для кнопок
            btnSubmit.Click += BtnSubmit_Click;
            ButtonIsCompleted.Click += ButtonIsCompleted_Click;
        }
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            
                var orderProcessing = new OrderProcessing
                {
                    OrderId = long.Parse(txtOrderId.Text),
                    EmployeeId = long.Parse(txtEmployeeId.Text),
                    IsCompleted = false 
                };

                var repository = new OrderProcessingRepository(ConfigurationManager.ConnectionStrings["defaultConnection"].ToString());
                repository.CreateOrderProcessing(orderProcessing);
               


        }
        private void ButtonIsCompleted_Click(object sender, EventArgs e)
        {
            
            if (long.TryParse(OrderProcessingID.Text, out long orderProcessingId))
            {
                var repo = new OrderProcessingRepository(ConfigurationManager.ConnectionStrings["defaultConnection"].ToString());
                bool isCompleted = chkIsCompleted.Checked;
                repo.UpdateOrderProcessingStatus(orderProcessingId, isCompleted);
                
            }
            else
            {
                
            }
           
        }
    }
}