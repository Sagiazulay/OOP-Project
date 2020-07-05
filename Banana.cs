using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_010720
{
    class Banana : Fruit
    {
        public bool hasBlackSpots;
        public bool isGreen;
        public float size;

        public override bool IsThisMyFavorite()
        {
            return true;
        }

        public override string ToString()
        {
            return $"{base.ToString()}  My {_name} has black spots : [{hasBlackSpots}], it is green[{isGreen}] and it's size is : {size} ";
        }
    }
}
