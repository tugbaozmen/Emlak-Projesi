using System;
using System.Collections.Generic;
using System.Text;

namespace EstateProject.Entities
{
    public class EntityBase
    {
        public EntityBase()
        {
            IsActive = true;
            IsDeleted = false;
            CreatedDate = DateTime.Now;
        }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
