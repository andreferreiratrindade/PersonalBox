using PersonalBox.Application.Appications.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBox.Application.Appications
{
  public  class AppBase<TEntity> : IAppBase<TEntity> where TEntity : class
    {

    }
}
