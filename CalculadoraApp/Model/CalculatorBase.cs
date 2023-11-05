using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraApp.Model
{
    public abstract class CalculatorBase
    {
        private CalculatorModel _model = new CalculatorModel();
        private bool _IsNewOperation { get; set; }
        public string? DivisionByZeroAlert { get; set; }
        public void SetNumber(decimal number)
        {
            if (_IsNewOperation)
            {  
                _model.NumberFirst = number;
                _IsNewOperation = false;
            }
            else
            {
                _model.NumberSecond = number;
                _IsNewOperation = true;
            }
        }
        public char SetOperation(char operation)
        {
            return _model.Operation = operation;
        }
        public decimal GetResult()
        {
            return _model.Result;
        }
        public void Clear()
        {
            _model.NumberFirst = 0;
            _model.NumberSecond = 0;
            _model.Result = 0;
            _model.Operation = '\0';
            _IsNewOperation = true;
        }
        public void Add()
        {
            _model.Result = _model.NumberFirst + _model.NumberSecond;
        } 
        public void Subtract()
        {
            _model.Result = _model.NumberFirst - _model.NumberSecond;
        }
        public void Multiply()
        {
            _model.Result = _model.NumberFirst * _model.NumberSecond;
        }
        public void Divide()
        {
            try
            {
                if (_model.NumberSecond == 0)
                {
                    throw new DivideByZeroException("Não é possível dividir por zero");
                }

                _model.Result = _model.NumberFirst / _model.NumberSecond;
            }
            catch (DivideByZeroException ex)
            {
                DivisionByZeroAlert = ex.Message; 
            }
        }
        public void Percentage()
        {
            _model.Result = _model.NumberFirst * _model.NumberSecond / 100;
        }
    }
}
       