using DailyScrum.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyScrum.Models
{
    public class ProjectModel
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public Guid? AuthorId { get; set; }
        public Status Status { get; set; }
      
    }
}
