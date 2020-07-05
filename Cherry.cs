using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_010720
{
    class Cherry : Fruit
    {
        public bool _isRed;
        public float _size;

        public override bool IsThisMyFavorite()
        {
            return true;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Is It Red : {_isRed}, Size : {_size}";
        }
    }
}
