using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {

    }
    protected void ASPxGridView1_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e) {
        decimal totalPrice = 0;
        int startIndex = ((ASPxGridView)sender).PageIndex * ((ASPxGridView)sender).SettingsPager.PageSize;
        int endIndex = startIndex + ((ASPxGridView)sender).SettingsPager.PageSize;
        for(int i = startIndex; i < endIndex; i++) {
            decimal currentPrice = Convert.ToDecimal(((ASPxGridView)sender).GetRowValues(i, "UnitPrice"));
            totalPrice = totalPrice + currentPrice;
        }
        e.TotalValue = totalPrice;
    }
}