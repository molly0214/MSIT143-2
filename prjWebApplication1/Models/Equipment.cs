using System;
using System.Collections.Generic;

#nullable disable

namespace prjWebApplication1.Models
{
    public partial class Equipment
    {
        public Equipment()
        {
            EquipmentReferences = new HashSet<EquipmentReference>();
        }

        public int EquipmentId { get; set; }
        public string EquipmentName { get; set; }
        public int EquipmentCatergoryId { get; set; }

        public virtual EquipmentCatergory EquipmentCatergory { get; set; }
        public virtual ICollection<EquipmentReference> EquipmentReferences { get; set; }
    }
}
