using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PhoneRepair.Controls
{
    public partial class OrderControl : System.Web.UI.UserControl
    {
        public PhoneOrder Data 
        { 
            get;
            set; 
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Data != null)
            
                RenderData();
            
        }
        protected void RenderData()
        {
            lblID.Text = Data.Id.ToString();
            lblPhoneManufacturer.Text = Data.PhoneManufacturer;
            lblPhoneModel.Text = Data.PhoneModel;
            lblBreaking.Text = Data.Breaking;
            lblOrderName.Text = Data.OrderName;
            lblOrderPhone.Text = Data.OrderPhoneNumber;

            // Set IsCompleted text and color
            if (Data.IsCompleted)
            {
                lblIsCompleted.InnerText = "Completed";
                lblIsCompleted.Style["color"] = "green";
            }
            else
            {
                lblIsCompleted.InnerText = "Not completed";
                lblIsCompleted.Style["color"] = "red";
            }
        }

    }
}