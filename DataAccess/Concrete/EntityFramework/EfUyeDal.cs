﻿using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUyeDal : EfEntityRepositoryBase<Uye, NorthwindContext>, IUyeDal
    {
    }
}
