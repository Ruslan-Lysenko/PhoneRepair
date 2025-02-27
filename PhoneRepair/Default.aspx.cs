using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PhoneRepair
{
    public partial class _Default : Page
    {
        public string LastOrderName
        {
            get;
            set;
        }
        public string LastOrderNumber
        {
            get;
            set;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                DisplayOrderInf();   
            }
            btnSubmit.Click += BtnSubmit_Click;
            CheckBox1.CheckedChanged += CheckBoxOrderInf_CheckedChanged;
        }

        private void CheckBoxOrderInf_CheckedChanged(object sender, EventArgs e)
        {
            DisplayOrderInf();
        }

        private void DisplayOrderInf()
        {
            pnlOrder.Visible = CheckBox1.Checked;
        }
            

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            var order = new PhoneOrder()
            {
                PhoneManufacturer = txtManufacturer.Text,
                PhoneModel = txtModel.Text,
                Breaking = BreakingControl.BreakingInfo,
                OrderName = txtName.Text,
                OrderPhoneNumber = txtNumber.Text
            };

            var repo = new OrderRepository(ConfigurationManager.ConnectionStrings["defaultConnection"].ToString());
            repo.CreatOrder(order);
            pnlOrder.Visible = false;
            pnlOrderCreated.Visible = true;
            LastOrderName = txtName.Text;
            LastOrderNumber = txtNumber.Text;
             
        }
    }
}
