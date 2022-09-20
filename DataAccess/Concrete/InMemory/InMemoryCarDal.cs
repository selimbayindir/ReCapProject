using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new ("Mercedes",1,1,2022,110,"BestSeller",10),
                new ("Renault",4,5,2022,110,"iyi",10),
                new ("Honda",2,7,2022,110,"çok iyi",10),
                new ("Fiat",8,9,2022,110,"Müthiş",10),
            };
        }

        public void Add(Car car)
        {
           _cars.Add(car);  
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            var result = _cars.Where(p => p.Id == id).ToList();


            return result;
        }

        public void Remove(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(car);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.Id=car.Id;
        }
    }
}
