using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Domain.Entity;

namespace WebApi.Service.Interfaces
{
    public interface ICarService
    {
        Task<List<Car>> GetCars();
        bool Create(Car entity);
        Car Get(int id);
        Car Edit(int id, Car entity);
        bool Delete(Car entity);
    }
}
