using Core.DataAccess.EntityFreamwork;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFreamwork.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFreamwork
{
  public  class EfCategoryDal:EfEntityRepositoryBase<Category,NorthwindContext> ,ICategoryDal
    {

    }
}
