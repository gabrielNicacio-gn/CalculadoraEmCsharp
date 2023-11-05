using CalculadoraApp.Model;
using System.Globalization;

namespace CalculadoraApp.Controller
{
    class CalculatorController : CalculatorBase 
    {
        private bool isDecimalPointController = false;
        private bool operationCompleted = true;
        private bool ErrorMessageWasShown = false;
        public void ProcessNumber(string textNumber)
        {
            if(decimal.TryParse(textNumber,CultureInfo.InvariantCulture, out decimal number)) 
            {
                SetNumber(number);
                DivisionByZeroAlert = null;
            }
        }
        public void ProcessClear()
        {
            Clear();
        }
        public decimal ProcessResult()
        {
            return GetResult();

        }
        public string? GetErrorMensage()
        {
            return DivisionByZeroAlert;
        }  
        public void PerformOperations(char operation)
        {
            switch (SetOperation(operation)) 
            {
                case '+':
                    Add();
                    break;
                case '-':
                    Subtract();
                    break;
                case '*':
                    Multiply();
                    break;
                case '/':
                    Divide();
                    break;
                case '%':
                    Percentage();
                    break;
            }
        }
    }
}
