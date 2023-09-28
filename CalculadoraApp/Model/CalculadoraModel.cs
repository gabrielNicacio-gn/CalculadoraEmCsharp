using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CalculadoraApp.Model
{
    class CalculadoraModel
    {
        public double NumberFirst { get; private set; }
        public double NumberSecond { get; private set; }
        public char Operation { get; private set; }
        public double Result { get; private set; }
        public string? divisionByZeroAlert { get; set; }

        public CalculadoraModel() 
        {
            divisionByZeroAlert = null;
        }

        public bool isNewOperation = true;

        public void SetNumber(double number)
        {
            if (isNewOperation)
            {
                NumberFirst = number;
                isNewOperation = false;
            }
            else
            {
                NumberSecond = number;
                isNewOperation = true;
            }
        }
        public char SetOperation(char operation) 
        {
             return Operation = operation;
        }
        public void Clear() 
        {
            NumberFirst = 0;
            NumberSecond = 0;
            Result = 0;
            Operation = '\0';
            isNewOperation = true;
        }
        public void Add()
        {
            Result = NumberFirst + NumberSecond;
        }
        public void Subtrac()
        {
            Result = NumberFirst - NumberSecond;
        }
        public void Multiply()
        {
            Result = NumberFirst * NumberSecond;
        }
        public void Divide()
        {
            if (NumberSecond == 0)
            {
                divisionByZeroAlert = "Não é possivel divir por zero";
            }
            else
            {
                Result = NumberFirst / NumberSecond;
            }
        }
        public void Percentage()
        {
            if (NumberSecond != 0 )
            {
                Result = NumberFirst * NumberSecond / 100;
            }
        }
    }
}
