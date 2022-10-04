using System;
using System.Collections.Generic;

#nullable disable

namespace prjWebApplication1.Models
{
    public partial class Discount
    {
        public Discount()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int RoomDiscountId { get; set; }
        public string DiscountName { get; set; }
        public string DiscountInfo { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
