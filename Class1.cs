using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class Dealer
    {
        private byte car_list_id = 0;
        public byte Car_list_id { get => car_list_id; set => car_list_id = value; }

        public class Car
        {
            private byte id;
            private string brand;
            private string model;
            private uint cost;

            public byte Id { get => id; set => id = value; }
            public string Brand { get => brand; set => brand = value; }
            public string Model { get => model; set => model = value; }
            public uint Cost { get => cost; set => cost = value; }
        }

        public List<Car> cars = [];

        public void Add(string brnd, string mdl, uint cst)
        {
            Car car = new Car();
            car.Id = Car_list_id;
            car.Brand = brnd; 
            car.Model = mdl; 
            car.Cost = cst;

            cars.Add(car);
            Car_list_id++;
        }

        public Car ReturnCar(int id)
        {
            return cars[id];
        }
    }
}
