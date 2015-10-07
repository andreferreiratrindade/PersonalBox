using AutoMapper;
using PersonalBox.Domain.Entities;
using PersonalBox.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBox.MVC.App_Start.AutoMapper
{
   public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMapping"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<RegisterViewModel,User>();
        }
    }
}
