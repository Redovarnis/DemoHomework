using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUyeService
    {
        List<Uye> GetAll();
    }
}
