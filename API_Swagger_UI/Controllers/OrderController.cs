using API_Swagger_UI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace API_Swagger_UI.Controllers
{
    public class OrdersController : ApiController
    {
        IList<order> allOrders = CreateFakeOrder();

        /// <summary>
        /// Return a particular Order
        /// </summary>
        /// <param name="id">Order Id</param>
        /// <returns></returns>
        [Route("orders/{orderid}")]
        public IHttpActionResult GetOrders(string orderid)
        {
            order ord = allOrders.Where(x => x.orderid == orderid).First<order>();
            return Ok(ord);
        }

        /// <summary>
        /// Return all orders
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetOrders()
        {
            return Ok(allOrders);
        }

        /// <summary>
        /// Return all  items in a particular Order
        /// </summary>
        /// <param name="id">Order it</param>
        /// <returns></returns>
        [Route("orders/{orderid}/items")]
        public IHttpActionResult GetItemsInOrder(string orderid)
        {
            IList<item> itemsinorder = (allOrders.Where(x => x.orderid == orderid).First<order>()).items;
            return Ok(itemsinorder);
        }

        /// <summary>
        /// Create Fake Orders
        /// </summary>
        /// <returns></returns>
        private static IList<order> CreateFakeOrder()
        {
            List<order> allOrders = new List<order>();

            order order1 = new order();
            order1.orderid = "WES12309145";
            order1.items.Add(new item { upc = "2345", description = "Banana", price = 4.50 });
            order1.items.Add(new item { upc = "11234", description = "Kale", price = 15.25 });
            order1.items.Add(new item { upc = "7867", description = "Water Purifier", price = 7.35 });
            order1.items.Add(new item { upc = "98754", description = "Kitchen Knief", price = 10.13 });
            order1.items.Add(new item { upc = "55435", description = "Charcoal", price = 5.34 });
      

            order order2 = new order();
            order2.orderid = "WES123981";
            order2.items.Add(new item { upc = "2345", description = "Pear", price = 4.50 });
            order2.items.Add(new item { upc = "4567", description = "Apple", price = 15.25 });
            order2.items.Add(new item { upc = "7867", description = "Notepad", price = 7.35 });
            order2.items.Add(new item { upc = "98754", description = "Toy", price = 10.13 });
            order2.items.Add(new item { upc = "55435", description = "Magazine", price = 5.34 });

            order order3 = new order();
            order3.orderid = "OL7645891";
            order3.items.Add(new item { upc = "1245", description = "Hershey Chocolate", price = 4.50 });
            order3.items.Add(new item { upc = "4568", description = "Flask", price = 15.25 });
            order3.items.Add(new item { upc = "9807", description = "Organic Milk", price = 7.35 });
            order3.items.Add(new item { upc = "8905", description = "Venison - Meat", price = 10.13 });
            order3.items.Add(new item { upc = "6678", description = "Light", price = 5.34 });

            allOrders.Add(order1);
            allOrders.Add(order2);
            allOrders.Add(order3);

            return allOrders;

        }
    }
}
