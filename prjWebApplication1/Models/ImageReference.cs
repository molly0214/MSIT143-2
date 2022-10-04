using System;
using System.Collections.Generic;

#nullable disable

namespace prjWebApplication1.Models
{
    public partial class ImageReference
    {
        public int ImageId { get; set; }
        public int RoomId { get; set; }
        public int ImageReferenceId { get; set; }

        public virtual Image Image { get; set; }
        public virtual Room Room { get; set; }
    }
}
