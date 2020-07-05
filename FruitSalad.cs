using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_010720
{
    class FruitSalad
    {
        public Fruit[] fruits;
        

        public int GetTotalCalories()
        {
            int totalcalories = 0;
            for (int i = 0; i < fruits.Length; i++)
            {
                totalcalories = totalcalories + fruits[i]._calories;
            } 
            return totalcalories;
        }
        public bool ContainsMyFavoriteFruit() 
        {
            for (int i = 0; i < fruits.Length; i++)
            {
                if (ContainsMyFavoriteFruit()== true)
                {
                    Console.WriteLine($"My Favorite Fruit Is Inside");
                    return true;
                }
            }
            return false;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
