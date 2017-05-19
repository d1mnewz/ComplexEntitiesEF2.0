using System;
using System.Collections.Generic;
using ComplexEntitiesEF2._0.Core.Entities.Abstract;

namespace ComplexEntitiesEF2._0.Core.Entities
{
    public class Blog : EntityGuid
    {
        public int BlogId { get; set; }
        public string Url { get; set; }

        public List<Post> Posts { get; set; }
    }
}
