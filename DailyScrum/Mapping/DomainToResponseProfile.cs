using AutoMapper;
using DailyScrum.Model.Entities;
using DailyScrum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyScrum.Mapping
{
    public class DomainToResponseProfile : Profile
    {
        public DomainToResponseProfile()
        {
            CreateMap<Issue, IssueModel>();             
            CreateMap<Comment, CommentModel>();
            CreateMap<Project, ProjectModel>();
            CreateMap<Sprint, SprintModel>();
            CreateMap<User, UserModel>();
            CreateMap<Team, TeamModel>();
        }
    }
}
