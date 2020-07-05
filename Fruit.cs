using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_010720
{
    abstract class Fruit
    {
        public String _name;
        public int _calories;

        public abstract bool IsThisMyFavorite();

        public override string ToString()
        {
            return $"Fruit Name : {_name} Fruit Calories : {_calories}";
        }
    }
}
