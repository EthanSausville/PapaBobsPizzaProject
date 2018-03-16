using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PapaBobsPizza
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void orderButton_Click(object sender, EventArgs e)
        {
            DTO.DtoOrder newOrder = NewOrder();

            if (newOrder.Name == "") errorLabel.Text = "Please input a name.";
            else if (newOrder.Address == "") errorLabel.Text = "Please input an address.";
            else if (newOrder.Zip == "") errorLabel.Text = "Please input a zipcode.";
            else if (newOrder.Phone == "") errorLabel.Text = "Please input a phone.";
            else
            {
                errorLabel.Text = "";
                Domain.OrderManager.AddOrder(newOrder);
                costLabel.Text = string.Format("{0:C}", Domain.OrderManager.GetCost(newOrder));
            }

            Server.Transfer("Success.aspx", true);
        }

        private DTO.DtoOrder NewOrder()
        {
            DTO.DtoOrder newOrder = new DTO.DtoOrder();

            newOrder.OrderID = Guid.NewGuid();
            newOrder.Size = GetPizzaSize(int.Parse(sizeDropDown.SelectedValue));
            newOrder.Crust = GetCrustType(int.Parse(crustDropDown.SelectedValue));
            newOrder.Sausage = (sausageCheckBtn.Checked) ? true : false;
            newOrder.Pepperoni = (peperoniCheckBtn.Checked) ? true : false;
            newOrder.Onions = (onionsCheckBtn.Checked) ? true : false;
            newOrder.Green_Peppers = (greenPeppersCheckBtn.Checked) ? true : false;
            newOrder.Cost = 0; // See Domain Logic
            newOrder.Name = nameBox.Text;
            newOrder.Address = addressBox.Text;
            newOrder.Zip = zipBox.Text;
            newOrder.Phone = phoneBox.Text;
            newOrder.Status = false;

            return newOrder;
        }

        private DTO.Enums.PizzaSize GetPizzaSize(int index)
        {
            if (index == 0) return DTO.Enums.PizzaSize.Small;
            else if (index == 1) return DTO.Enums.PizzaSize.Medium;
            else return DTO.Enums.PizzaSize.Large;
        }

        private DTO.Enums.CrustType GetCrustType(int index)
        {
            if (index == 0) return DTO.Enums.CrustType.Regular;
            else if (index == 1) return DTO.Enums.CrustType.Thin;
            else return DTO.Enums.CrustType.Thick;
        }
    }
}