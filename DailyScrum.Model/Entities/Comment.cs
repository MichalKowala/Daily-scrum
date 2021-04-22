using System;
using System.Collections.Generic;
using System.Text;

namespace DailyScrum.Model.Entities
{
    public class Comment:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public User Author { get; set; }
        public Guid? AuthorId { get; set; }
        public Issue Issue { get; set; }
        public Guid? IssueId { get; set; }
    }
}
