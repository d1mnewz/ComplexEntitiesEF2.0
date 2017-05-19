using ComplexEntitiesEF2._0.Core.Entities.Abstract;

namespace ComplexEntitiesEF2._0.Core.Entities
{
    public class Post : EntityGuid
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public Blog Blog { get; set; }
    }
}
