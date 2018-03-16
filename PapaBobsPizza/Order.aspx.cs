using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PapaBobsPizza
{
    public partial class Order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var orders = Domain.OrderManager.GetOrders();

            orderGrid.DataSource = orders.Where(p => p.Status == false).ToList();
            orderGrid.DataBind();
        }

        protected void orderGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = orderGrid.Rows[index];
            Guid orderID = Guid.Parse(row.Cells[1].Text.ToString());

            Domain.OrderManager.MarkComplete(orderID);
        }
    }
}