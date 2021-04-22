using DailyScrum.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DailyScrum.Model.Entities
{
    public class Issue:BaseEntity
    {
        public Status Status { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public User Author { get; set; }
        public Guid? AuthorId { get; set; }
        public string Label { get; set; }
        public IssueType Type { get; set; }
        public virtual IEnumerable<User> Assignees { get; set; }
        public virtual IEnumerable<Comment> Comments { get; set; }
        public Sprint Sprint { get; set; }
        public Guid? SprintId { get; set; }
        public Priority Priority { get; set; }
        public Project Project { get; set; }
        public Guid? ProjectId { get; set; }                     
    }
}
