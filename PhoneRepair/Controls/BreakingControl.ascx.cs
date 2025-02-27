using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;

namespace PhoneRepair.Controls
{
    public partial class BreakingControl : UserControl
    {
        // Свойство для получения информации о поломках
        public string BreakingInfo
        {
            get
            {
                var brokenParts = new List<string>();
                if (ckbxButton.Checked) brokenParts.Add("Button");
                if (ckbxDisplay.Checked) brokenParts.Add("Display");
                if (ckbxCamera.Checked) brokenParts.Add("Camera");
                return brokenParts.Any() ? string.Join(", ", brokenParts) : null;
            }
        }

        
        protected void OnCheckBoxChanged(object sender, EventArgs e)
        {
           
        }
        public void SetBreakingInfo(string breakingInfo)
        {
            if(string.IsNullOrEmpty(breakingInfo))
            {
                // Сбрасываем состояние чекбоксов, если информация о поломках пуста
                ckbxButton.Checked = false;
                ckbxDisplay.Checked = false;
                ckbxCamera.Checked = false;
                return;
            }

            var brokenParts = breakingInfo.Split(',');

            
            ckbxButton.Checked = brokenParts.Contains("Button");
            ckbxDisplay.Checked = brokenParts.Contains("Display");
            ckbxCamera.Checked = brokenParts.Contains("Camera");
        }
    }
}
