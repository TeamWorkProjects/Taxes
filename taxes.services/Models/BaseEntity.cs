using System;
using System.Collections.Generic;
using System.Text;

namespace taxes.services.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public int Creater { get; set; } //User Id
        public int Modifier { get; set; } //User Id
    }
}
