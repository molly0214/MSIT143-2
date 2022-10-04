using System;
using System.Collections.Generic;

#nullable disable

namespace prjWebApplication1.Models
{
    public partial class EquipmentReference
    {
        public int EquipmentId { get; set; }
        public int RoomId { get; set; }
        public int EquipmentReferenceId { get; set; }

        public virtual Equipment Equipment { get; set; }
        public virtual Room Room { get; set; }
    }
}
