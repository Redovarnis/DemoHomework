using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UyeManager : IUyeService
    {
        private IUyeDal _uyeDal;

        public UyeManager(IUyeDal categoryDal)
        {
            _uyeDal = categoryDal;
        }

        public List<Uye> GetAll()
        {
            return _uyeDal.GetAll();
        }
    }
}
