using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        // InMemory formatta GetById, GetAll, Add, Update, Delete oprasyonlarını yazınız.
        List<Car> GetAll(Expression<Func<Car, bool>> filter = null);
        List<Car> GetById(int id);
        void Add(Car car);
        void Update(Car car);
        void Remove(Car car);



    }
}
