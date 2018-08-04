using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Swagger_UI.Models
{
    public class order
    {
        /// <summary>
        /// Order Id
        /// </summary>
        public string orderid { get; set; }

        /// <summary>
        /// Items in the order
        /// </summary>
        public List<item> items = new List<item>();
    }
}