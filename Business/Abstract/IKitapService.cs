using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IKitapService
    {
        List<Kitap> GetAll();
        List<Kitap> GetKitapByUye(int categoryId);
        List<Kitap> GetKitapByKitapAdı(string productName);
        void Add(Kitap product);
        void Update(Kitap product);
        void Delete(Kitap product);
    }
}
