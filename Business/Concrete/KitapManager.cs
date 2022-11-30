using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class KitapManager : IKitapService
    {
        private IKitapDal _productDal;

        public KitapManager(IKitapDal productDal)
        {
            _productDal = productDal;
        }

        public List<Kitap> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Kitap> GetKitapByUye(int uyeId)
        {
            return _productDal.GetAll(p => p.ID == uyeId);
        }

        public List<Kitap> GetKitapByKitapAdı(string kitapAdi)
        {
            return _productDal.GetAll(p => p.KitapAdi.ToLower().Contains(kitapAdi.ToLower()));
        }

        public void Add(Kitap kitap)
        {
            _productDal.Add(kitap);
        }

        public void Update(Kitap kitap)
        {
            _productDal.Update(kitap);
        }

        public void Delete(Kitap kitap)
        {
            _productDal.Delete(kitap);
        }
    }
}
