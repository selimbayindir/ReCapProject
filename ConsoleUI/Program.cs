// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.InMemory;

///InMemoryGetAllCar();

static void InMemoryGetAllCar()
{
    CarManager carManager = new CarManager(new InMemoryCarDal());
    foreach (var car in carManager.GetList())
    {
        Console.WriteLine(car.Name);
    }
}

CarManager carManager = new CarManager(new InMemoryCarDal());
foreach (var car in carManager.GetList())
{
    Console.WriteLine(car.Name);
}
///InMemoryCarDelete(carManager);

static void InMemoryCarDelete(CarManager carManager)
{
    CarManager carManager1 = new CarManager(new InMemoryCarDal());
    carManager.GetCar(1);
}
