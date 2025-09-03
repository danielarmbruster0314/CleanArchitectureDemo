using CleanArchitectureDemo.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureDemo.Domain.Entities
{
    public class Category : AuditableEntity
    {
        public Guid CategoryID { get; set; }
        public string Name { get; set; }
        public ICollection<Event>? Events { get; set; }
    }
}
