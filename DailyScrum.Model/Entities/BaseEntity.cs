using System;
using System.Collections.Generic;
using System.Text;

namespace DailyScrum.Model.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
      //  public DateTime ModifiedAt { get; set; }
        protected BaseEntity()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.UtcNow;
        //    ModifiedAt = DateTime.UtcNow;
        }
    }
}
