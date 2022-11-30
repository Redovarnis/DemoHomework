using System;
using System.Collections.Generic;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfKitapDal : EfEntityRepositoryBase<Kitap,NorthwindContext>, IKitapDal
    {
    }
}
