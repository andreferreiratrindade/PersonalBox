using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBox.MVC.App_Start.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
           get { return "DomainToViewModelMapping"; }
        }

        protected override void Configure()
        {

        }
    }
}
