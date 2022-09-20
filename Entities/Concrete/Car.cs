using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car
    {
        public Car()
        {
                
        }
        public Car(string name, int brandId, int colorId, int modelYear, decimal dailyPrice, string description, int unitsInStock)
        {
      
            Name = name;
            BrandId = brandId;
            ColorId = colorId;
            ModelYear = modelYear;
            DailyPrice = dailyPrice;
            Description = description;
            UnitsInStock = unitsInStock;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
        public int UnitsInStock { get; set; }

    }
}
