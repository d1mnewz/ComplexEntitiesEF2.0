using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexEntitiesEF2._0.Core.Entities.Abstract
{
    public class Metadata
    {
        public DateTime CreatedDateUtc { get; set; }
        public DateTime? ModifiedDateUtc { get; set; }
        public DateTime? DeletedDateUtc { get; set; }
    
        public Metadata()
        {
            this.CreatedDateUtc = DateTime.Now;
        }
    }
}
