using DailyScrum.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DailyScrum.Model.Entities
{
    public class Project:BaseEntity
    {
        public string Name { get; set; }
        public User Author { get; set; }
        public Guid? AuthorId { get; set;}
        public Status Status { get; set; }
        public virtual IEnumerable<Sprint> Sprints { get; set; }
        public virtual IEnumerable<Issue> Issues { get; set; }
    }
}
