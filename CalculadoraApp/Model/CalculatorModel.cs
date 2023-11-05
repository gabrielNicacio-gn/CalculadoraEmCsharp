using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CalculadoraApp.Model
{
    class CalculatorModel
    {
        public decimal NumberFirst { get; set; }
        public decimal NumberSecond { get; set; }
        public char Operation { get; set; }
        public decimal Result { get; set; }
    }
}

       