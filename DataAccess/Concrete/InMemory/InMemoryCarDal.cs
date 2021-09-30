using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
       

        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
            new Car {Id=1, BrandId=1, ColorId=1, ModelYear=2021, DailyPrice=500, Description="picap" },
            new Car {Id=2, BrandId=1, ColorId=2, ModelYear=2020, DailyPrice=400, Description="jeep" },
            new Car {Id=3, BrandId=2, ColorId=3, ModelYear=2019, DailyPrice=300, Description="mini" },
            new Car {Id=4, BrandId=2, ColorId=4, ModelYear=2018, DailyPrice=200, Description="punto" },
            new Car {Id=5, BrandId=2, ColorId=5, ModelYear=2017, DailyPrice=100, Description="corss" },

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
           Car carToDelete = _cars.SingleOrDefault(x=>x.Id == car.Id);
           
            _cars.Remove(carToDelete);

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(x => x.Id == car.Id);
        }

        public void GetById(int id)
        {
            _cars.Where(x => x.Id == id);
        }
       
    }
}
