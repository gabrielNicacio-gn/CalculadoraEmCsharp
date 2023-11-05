using CalculadoraApp.Controller;
using System.Globalization;

namespace CalculadoraApp;

public partial class CalculatorView : Form
{
    private CalculatorController _controller;
    private char _operation = '\0';
    private Font _currentFont;
    private bool _isDecimalPointController = false;
    private bool _operationCompleted = true;
    private bool _errorMessageWasShown = false;
    public CalculatorView()
    {
        InitializeComponent();
        _controller = new();
        _currentFont = txtBoxMain.Font;
    }
    private void ButtomNumber_Click(object sender, EventArgs e)
    {
        txtBoxMain.ForeColor = Color.White;
        txtBoxMain.Font = _currentFont;
        labelOperation.ForeColor = Color.White;

        if (!_errorMessageWasShown)
        {
            txtBoxMain.Text = "";
            _controller.Clear();
            _errorMessageWasShown = true;
            labelOperation.Text = "";
        }
        Button buttonNumber = (Button)sender;
        string buttonText = buttonNumber.Text;
        if (_operationCompleted)
        {
            txtBoxMain.Text = "";
            _controller.Clear();
            _operationCompleted = false;
        }
        txtBoxMain.Text += buttonText;
    }
    private void ButtomOperation_Click(object sender, EventArgs e)
    {
        Button buttomOperation = (Button)sender;
        _operation = char.Parse(buttomOperation.Text);
        if (_operationCompleted)
        {
            _controller.ProcessNumber(txtBoxMain.Text);
            _operationCompleted = false;
        }
        _controller.ProcessNumber(txtBoxMain.Text);
        labelOperation.Text = txtBoxMain.Text + " " + _operation.ToString();
        txtBoxMain.Clear();
        _isDecimalPointController = false;
    }
    private void ButtomEqual_Click(object sender, EventArgs e)
    {
        _controller.ProcessNumber(txtBoxMain.Text.ToString());
        _controller.PerformOperations(_operation);
        if (_controller.GetErrorMensage() != null)
        {
            txtBoxMain.Text = _controller.GetErrorMensage();
            txtBoxMain.ForeColor = Color.Red;
            labelOperation.ForeColor = Color.Red;
            txtBoxMain.Font = new(txtBoxMain.Font.FontFamily, 12);
            _errorMessageWasShown = false;
        }
        else
        {
            txtBoxMain.Font = _currentFont;
            txtBoxMain.ForeColor = Color.White;
            decimal result = _controller.ProcessResult();
            txtBoxMain.Text = result.ToString();
            labelOperation.Text = "";
        }
        _isDecimalPointController = false;
        _operationCompleted = true;
    }
    private void ButtomClear_Click(object sender, EventArgs e)
    {
        _controller.Clear();
        txtBoxMain.Clear();
        labelOperation.Text = "";
        _isDecimalPointController = false;
    }
    private void ButtomPoint_Click(object sender, EventArgs e)
    {
        if (!_isDecimalPointController)
        {
            Button buttonClick = (Button)sender;
            txtBoxMain.Text += buttonClick.Text;
            _isDecimalPointController = true;
        }
    }
}
