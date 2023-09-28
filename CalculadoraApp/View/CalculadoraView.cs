using CalculadoraApp.Controller;
using System.Globalization;

namespace CalculadoraApp;

public partial class CalculadoraView : Form
{
    CalculadoraController controller;
    private char operation = '\0';
    private Font currentFont;
    private bool isDecimalPointController = false;
    private bool operationCompleted = true;
    private bool ErrorMessageWasShown = false;
    public CalculadoraView()
    {
        InitializeComponent();
        controller = new();
        currentFont = txtBoxMain.Font;
    }
    private void ButtomNumber_Click(object sender, EventArgs e)
    {
        txtBoxMain.ForeColor = Color.White;
        txtBoxMain.Font = currentFont;
        labelOperation.ForeColor = Color.White;

        if (!ErrorMessageWasShown)
        {
            txtBoxMain.Text = "";
            controller.Clear();
            ErrorMessageWasShown = true;
            labelOperation.Text = "";
        }
        Button buttonNumber = (Button)sender;
        string buttonText = buttonNumber.Text;
        if (operationCompleted)
        {
            txtBoxMain.Text = "";
            controller.Clear();
            operationCompleted = false;
        }
        txtBoxMain.Text += buttonText;
    }
    private void ButtomOperation_Click(object sender, EventArgs e)
    {
        Button buttomOperation = (Button)sender;
        operation = char.Parse(buttomOperation.Text);
        if (operationCompleted)
        {
            controller.ProcessNumber(txtBoxMain.Text);
            operationCompleted = false;
        }
        controller.ProcessNumber(txtBoxMain.Text);
        labelOperation.Text = txtBoxMain.Text + " " + operation.ToString();
        txtBoxMain.Clear();
        isDecimalPointController = false;
    }
    private void ButtomEqual_Click(object sender, EventArgs e)
    {
        controller.ProcessNumber(txtBoxMain.Text.ToString());
        controller.PerformOperations(operation);
        if (controller.GetErrorMensage() != null)
        {
            txtBoxMain.Text = controller.GetErrorMensage();
            txtBoxMain.ForeColor = Color.Red;
            labelOperation.ForeColor = Color.Red;
            txtBoxMain.Font = new(txtBoxMain.Font.FontFamily, 12);
            ErrorMessageWasShown = false;
        }
        else
        {
            txtBoxMain.Font = currentFont;
            txtBoxMain.ForeColor = Color.White;
            double result = controller.GetResult();
            txtBoxMain.Text = result.ToString();
            labelOperation.Text = "";
        }
        isDecimalPointController = false;
        operationCompleted = true;
    }
    private void ButtomClear_Click(object sender, EventArgs e)
    {
        controller.Clear();
        txtBoxMain.Clear();
        labelOperation.Text = "";
        isDecimalPointController = false;
    }
    private void ButtomPoint_Click(object sender, EventArgs e)
    {
        if (!isDecimalPointController)
        {
            Button buttonClick = (Button)sender;
            txtBoxMain.Text += buttonClick.Text;
            isDecimalPointController = true;
        }
    }
}
