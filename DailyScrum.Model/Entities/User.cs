using System;
using System.Collections.Generic;
using System.Text;

namespace DailyScrum.Model.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Team Team { get; set; }
        public Guid? TeamID { get; set; }
        public virtual IEnumerable<Comment> Comments { get; set; }
        public virtual IEnumerable<Project> Projects { get; set; }
        public virtual IEnumerable<Issue> Issues { get; set; }
        
    }
}
