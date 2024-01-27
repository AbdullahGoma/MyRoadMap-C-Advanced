using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSecond
{
    enum Grade
    {
        Excelent = 0,
        VeryGood,
        Good,
    }

    //Atribute
    [Flags]
    enum Color
    {
        Red = 1,
        Green = 2,
        Blue = 4,
    }
}
