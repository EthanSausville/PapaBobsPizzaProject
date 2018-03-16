using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobsPizza.Persistance
{
    public class OrderRepo
    {
        public static List<DTO.DtoOrder> GetOrders()
        {
            PizzaOrderEntities db = new PizzaOrderEntities();
            var dbOrders = db.Orders.ToList();

            var dtoOrders = new List<DTO.DtoOrder>();

            foreach (var dbOrder in dbOrders)
            {
                var dtoOrder = new DTO.DtoOrder();

                dtoOrder.OrderID = dbOrder.OrderID;
                dtoOrder.Size = dbOrder.Size;
                dtoOrder.Crust = dbOrder.Crust;
                dtoOrder.Sausage = dbOrder.Sausage;
                dtoOrder.Pepperoni = dbOrder.Pepperoni;
                dtoOrder.Onions = dbOrder.Onions;
                dtoOrder.Green_Peppers = dbOrder.Green_Peppers;
                dtoOrder.Cost = dbOrder.Cost;
                dtoOrder.Name = dbOrder.Name;
                dtoOrder.Address = dbOrder.Address;
                dtoOrder.Zip = dbOrder.Zip;
                dtoOrder.Phone = dbOrder.Phone;
                dtoOrder.Status = dbOrder.Status;

                dtoOrders.Add(dtoOrder);
            }

            return dtoOrders;
        }

        public static void AddOrder(DTO.DtoOrder newOrder)
        {
            PizzaOrderEntities database = new PizzaOrderEntities();
            var databaseOrders = database.Orders;

            Persistance.Order order = new Persistance.Order();

            order.OrderID = newOrder.OrderID;
            order.Size = newOrder.Size;
            order.Crust = newOrder.Crust;
            order.Sausage = newOrder.Sausage;
            order.Pepperoni = newOrder.Pepperoni;
            order.Onions = newOrder.Onions;
            order.Green_Peppers = newOrder.Green_Peppers;
            order.Cost = newOrder.Cost;
            order.Name = newOrder.Name;
            order.Address = newOrder.Address;
            order.Zip = newOrder.Zip;
            order.Phone = newOrder.Phone;
            order.Status = newOrder.Status;


            try
            {
                databaseOrders.Add(order);
                database.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void MarkComplete(Guid orderID)
        {
            PizzaOrderEntities db = new PizzaOrderEntities();
            var order = db.Orders.First(p => p.OrderID == orderID);

            order.Status = true;
            db.SaveChanges();
        }
    }
}
