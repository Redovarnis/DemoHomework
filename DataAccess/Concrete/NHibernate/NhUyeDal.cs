using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.NHibernate
{
    public class NhUyeDal : IUyeDal
    {
        public List<Uye> GetAll(Expression<Func<Uye, bool>> filter = null)
        {
            List<Uye> products = new List<Uye>()
            {
                new Uye()
                {
                    ID = 1,
                    Ad = "Sait Ahmet",
                    Soyad = "Delice",
                    Meslek = "Öğrenci",
                    CezaPuani = 0
                }
            };
            return products;
        }

        public Uye Get(Expression<Func<Uye, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Uye entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Uye entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Uye entity)
        {
            throw new NotImplementedException();
        }
    }
}