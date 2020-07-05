using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_010720
{
    class Apple : Fruit
    {
        public String _color;
        public bool _pinkLady;
        public override bool IsThisMyFavorite()
        {
            return false;
        }

        public override string ToString()
        {
            return $"{base.ToString()} My {_name} color is : {_color}";
        }
    }
}
