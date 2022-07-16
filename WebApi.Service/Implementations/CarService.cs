using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.DAL.Interfaces;
using WebApi.Domain.Entity;
using WebApi.Service.Interfaces;

namespace WebApi.Service.Implementations
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public bool Create(Car entity)
        {
            _carRepository.Create(entity);
            return true;
        }

        public async Task<List<Car>> GetCars()
        {
            return await _carRepository.Select();
        }

        public Car Get(int id)
        {
            return _carRepository.Get(id);
        }

        public Car GetByName(string name)
        {
            return _carRepository.GetByName(name);
        }

        public Car Edit(int id, Car entity)
        {
            _carRepository.Update(entity);
            return entity;
        }

        public bool Delete(Car entity)
        {
            _carRepository.Delete(entity);
            return true;
        }
    }
}
