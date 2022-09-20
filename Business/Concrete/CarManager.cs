using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _cardal;

        public CarManager(ICarDal cardal)
        {
            _cardal = cardal;
        }

        public void Add(Car car)
        {
            _cardal.Add(car);
        }

        public void Delete(Car car)
        {
            _cardal.Remove(car);
        }

        public List<Car> GetCar(int id)
        {
          return _cardal.GetById(id);
        }

        public List<Car> GetList()
        {
            return _cardal.GetAll();
        }

        public void Update(Car car)
        {
            _cardal.Update(car);
        }
    }
}
