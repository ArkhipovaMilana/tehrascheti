using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCalc.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Protein { get; set; }
        public decimal Fat { get; set; }
        public decimal Carbohydrates { get; set; }

        public decimal Calories => (Protein * 4.0m) + (Fat * 9.0m) + (Carbohydrates * 4.0m);

        public List<ProductProcessing> Processings { get; set; } = new List<ProductProcessing>();
    }

    public class ProductProcessing
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public decimal LossRate { get; set; }
        public int ProductId { get; set; }

        public decimal CalculateWeightAfterLoss(decimal initialWeight)
        {
            return initialWeight * (1m - (LossRate / 100m));
        }
    }
}
