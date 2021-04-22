using System;
using System.Collections.Generic;
using System.Text;

namespace DailyScrum.Model.Entities
{
    public class Sprint:BaseEntity
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public Project Project { get; set; }
        public Guid? ProjectId { get; set; }
        public virtual IEnumerable<Issue> Issues { get; set; }
    }
}
