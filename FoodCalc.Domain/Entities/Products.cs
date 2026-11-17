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

        // Калорийность (на 100г продукта)
        public decimal Calories => (Protein * 4.0m) + (Fat * 9.0m) + (Carbohydrates * 4.0m);

        // Вычисление веса после кулинарной обработки
        // На вход принимает исходный вес (initialWeight) и процент потерь (lossRate)
        public decimal CalculateWeightAfterLoss(decimal initialWeight, decimal lossRate)
        // Формула: делим проценты на 100 получаем доли и вычитаем из единицы. 
            // Исходный вес умножаем на получившийся остаток.
        {
            return initialWeight * (1m - (lossRate / 100m));
        }
    }

    
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal DishYield { get; set; } // Планируемый итоговый вес порции 
        // Продукт + его чистый вес в блюде.
        // связываем в пару Продукт и его чистый вес в блюде.
        public List<(Product ProductItem, decimal NetWeight)> Ingredients { get; set; } = new List<(Product ProductItem, decimal NetWeight)>();

        //  Общий чистый вес всех ингредиентов
        public decimal CalculateTotalNetWeight()
        {
            return Ingredients.Sum(ingredient => ingredient.NetWeight);
        }

        // Общая калорийность всего блюда
        public decimal CalculateTotalCalories()
        {
            // Берем чистый вес продукта, делим на 100 и умножаем на его калорийность
            return Ingredients.Sum(ingredient => (ingredient.NetWeight / 100m) * ingredient.ProductItem.Calories);
        }
    }
    
    
}
