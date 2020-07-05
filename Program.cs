using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_010720
{
    class Program
    {
        static void PrintAppleColor(Apple a)
        {
            Console.WriteLine($"The Apple color is : {a._color}");
        }
        static void BananaSize(Banana b)
        {
            Console.WriteLine($"The Banana Size is : {b.size}");
        }
        static void FruitSaladCalories(FruitSalad f)
        {
            Console.WriteLine($"The Total Calories Of The Salad is : {f.GetTotalCalories()}");
        }
        static void IsMyFavoriteFruitIn(FruitSalad fs)
        {
            Console.WriteLine($"Is My Favorite fruit in : [{fs.ContainsMyFavoriteFruit()}");
        }

        static void Main(string[] args)
        {

            Apple apple = new Apple()
            {
                _name = "myApple",
                _calories = 200,
                _color = "Red",
                _pinkLady = false
            };
            PrintAppleColor(apple);
            Banana banana = new Banana()
            {
                _name = "myBanana",
                _calories = 350,
                hasBlackSpots = false,
                isGreen = false,
                size = 6.0f
            };
            BananaSize(banana);

            FruitSalad salad = new FruitSalad()
            {
                fruits = new Fruit[] 
                {
                    new Banana()
                    {
                        _name = "myBanana",
                        _calories = 350,
                        hasBlackSpots = false,
                        isGreen = false,
                        size = 6.0f
                    },
                    new Apple()
                    {
                        _name = "myApple",
                        _calories = 200,
                        _color = "Red",
                        _pinkLady = false
                    },
                    new Cherry()
                    {
                        _size = 1.0f,
                        _isRed = true,
                        _calories = 70,
                        _name = "Cherry"
                    }
                    
                }
            };
            FruitSaladCalories(salad);
            IsMyFavoriteFruitIn(salad);
        }
    }
}
