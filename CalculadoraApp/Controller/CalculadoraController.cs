using CalculadoraApp.Model;
using System.Globalization;

namespace CalculadoraApp.Controller
{
    class CalculadoraController
    {
        private CalculadoraModel model;
        public CalculadoraController()
        {
            model = new();
        }
        public void ProcessNumber(string textNumber)
        {
            if(double.TryParse(textNumber,CultureInfo.InvariantCulture, out double number)) 
            {
                model.SetNumber(number);
                model.divisionByZeroAlert = null;
            }
        }
        public void Clear()
        {
            model.Clear();
        }
        public double GetResult()
        {
            return model.Result;
        }
        public string? GetErrorMensage()
        {
            return model.divisionByZeroAlert;
        }  
        public void PerformOperations(char operation)
        {
            switch (model.SetOperation(operation)) 
            {
                case '+':
                    model.Add();
                    break;
                case '-':
                    model.Subtrac();
                    break;
                case '*':
                    model.Multiply();
                    break;
                case '/':
                    model.Divide();
                    break;
                case '%':
                    model.Percentage();
                    break;
            }
        }
     }
}
