using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_010720
{
    class Kiwi : Fruit
    {
        public float _radios;
        public bool _isReady;
        public override bool IsThisMyFavorite()
        {
            return false;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Radios is : {_radios}, Is It Ready : {_isReady}";
        }
    }
}
