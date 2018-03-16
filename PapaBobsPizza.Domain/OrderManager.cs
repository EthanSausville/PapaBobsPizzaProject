using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PapaBobsPizza;

namespace PapaBobsPizza.Domain
{
    public class OrderManager
    {
        public static List<DTO.DtoOrder> GetOrders()
        {
            return Persistance.OrderRepo.GetOrders();
        }

        public static void AddOrder(DTO.DtoOrder newOrder)
        {
            newOrder.Cost = GetCost(newOrder);
            Persistance.OrderRepo.AddOrder(newOrder);
        }

        public static double GetCost(DTO.DtoOrder newOrder)
        {
            double cost = 0;

            if (newOrder.Size == DTO.Enums.PizzaSize.Small) cost += 12;
            else if (newOrder.Size == DTO.Enums.PizzaSize.Medium) cost += 14;
            else if (newOrder.Size == DTO.Enums.PizzaSize.Large) cost += 16;

            if (newOrder.Crust == DTO.Enums.CrustType.Thick) cost += 2;

            if (newOrder.Sausage) cost += 2;
            if (newOrder.Pepperoni) cost += 1.5;
            if (newOrder.Onions) cost += 1;
            if (newOrder.Green_Peppers) cost += 1;

            return cost;
        }

        public static void MarkComplete(Guid orderID)
        {
            Persistance.OrderRepo.MarkComplete(orderID);
        }
    }
}
