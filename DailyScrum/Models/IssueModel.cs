using DailyScrum.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyScrum.Models
{
    public class IssueModel
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public Guid? AuthorId { get; set; }
        public string Label { get; set; }
        public IssueType Type { get; set; }

        public Guid? SprintId { get; set; } 

        public Priority Priority { get; set; }
        public Guid? ProjectId { get; set; }
    }
}
