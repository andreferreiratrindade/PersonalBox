using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBox.MVC.App_Start.AutoMapper
{
   public class AutoMapperConf
    {

        public static void RegisterAutoMarppings()
        {
            Mapper.Initialize(x=> {
                x.AddProfile<DomainToViewModelMappingProfile>();
                x.AddProfile<ViewModelToDomainMappingProfile>();
            }
            );
        }
    }
}
