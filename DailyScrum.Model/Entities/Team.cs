using System;
using System.Collections.Generic;
using System.Text;

namespace DailyScrum.Model.Entities
{
    public class Team:BaseEntity
    {
        public string Name { get; set; }
        public virtual IEnumerable<User> Users { get; set; }
    }
}
