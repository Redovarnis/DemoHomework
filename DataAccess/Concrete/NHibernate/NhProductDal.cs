using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.NHibernate
{
    public class NhProductDal : IKitapDal
    {
        public List<Kitap> _products = new List<Kitap>()
        {
            new Kitap()
            {
                ID = 1,
                KitapAdi = "Soğuk Odalar",
                Yazar = "Sait Ahmet Delice",
                Tur = "Komedi",
                Sayfa = 300,
                Uygunluk = true
            }
        };

        public List<Kitap> GetAll(Expression<Func<Kitap, bool>> filter = null)
        {
            return _products;
        }

        public Kitap Get(Expression<Func<Kitap, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Kitap product)
        {
            product.ID = 2;
            _products.Add(product);
        }

        public void Update(Kitap product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Kitap product)
        {
            throw new NotImplementedException();
        }
    }
}
