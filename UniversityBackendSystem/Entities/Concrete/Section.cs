using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Section : IEntity
    {
        public int Id { get; set; }
        public string SectionName { get; set; }
        public int SectionPoint { get; set; }
        public string SectionPresident { get; set; }

    }
}
