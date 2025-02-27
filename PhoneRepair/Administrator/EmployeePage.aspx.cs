using System;
using System.Configuration;
namespace PhoneRepair.Administrator
{
    public partial class EmployeePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pnlEmployeeDetails.Visible = false;
        }

        protected void btnFindEmployee_Click(object sender, EventArgs e)
        {
            if (long.TryParse(txtEmployeeId.Text, out long employeeId))
            {
                var repository = new EmployeeRepository(ConfigurationManager.ConnectionStrings["defaultConnection"].ToString());
                var employee = repository.GetEmployeeById(employeeId);

                if (employee != null)
                {
                    
                    txtEmployeeName.Text = employee.EmployeeName;
                    pnlEmployeeDetails.Visible = true;
                }
                else
                {
                    pnlEmployeeDetails.Visible = false;
                    
                }
            }
            else
            {
                
            }
        }

        protected void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (long.TryParse(txtEmployeeId.Text, out long employeeId))
            {
                var repository = new EmployeeRepository(ConfigurationManager.ConnectionStrings["defaultConnection"].ToString());

                var employee = new Employee
                {
                    EmployeeId = employeeId,
                    EmployeeName = txtEmployeeName.Text
                };

                repository.UpdateEmployy(employee);
                
            }
            else
            {
                // Обработка ошибки при обновлении
               
            }
        }
    }
}
