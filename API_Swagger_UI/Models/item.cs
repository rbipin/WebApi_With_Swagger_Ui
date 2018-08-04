using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Swagger_UI.Models
{
    public class item
    {
        /// <summary>
        /// Item UPC
        /// </summary>
        public string upc { get; set; }

        /// <summary>
        /// Item Description
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// Item Price
        /// </summary>
        public double price { get; set; }
    }
}