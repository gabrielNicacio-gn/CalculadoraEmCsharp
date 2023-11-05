using System.Windows.Forms.VisualStyles;

namespace CalculadoraApp;

partial class CalculatorView
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        txtBoxMain = new TextBox();
        buttonClear = new Button();
        buttonOperationPercentage = new Button();
        buttonOperationAdd = new Button();
        buttonOperationSubtract = new Button();
        buttonOperationMultiply = new Button();
        buttonNumberThree = new Button();
        buttonNumberTwo = new Button();
        buttonNumberOne = new Button();
        buttonOperationDivide = new Button();
        buttonNumberSix = new Button();
        buttonNumberFive = new Button();
        buttonNumberFour = new Button();
        buttonEqual = new Button();
        buttonNumberNine = new Button();
        buttonNumberEight = new Button();
        buttonNumberSeven = new Button();
        buttonClearC = new Button();
        buttonNumberZero = new Button();
        buttonDecimalPoint = new Button();
        labelOperation = new Label();
        SuspendLayout();
        // 
        // txtBoxMain
        // 
        txtBoxMain.BackColor = Color.FromArgb(52, 57, 87);
        txtBoxMain.BorderStyle = BorderStyle.None;
        txtBoxMain.Font = new Font("Century Gothic", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
        txtBoxMain.ForeColor = SystemColors.Window;
        txtBoxMain.Location = new Point(6, 70);
        txtBoxMain.Margin = new Padding(4);
        txtBoxMain.Multiline = true;
        txtBoxMain.Name = "txtBoxMain";
        txtBoxMain.ScrollBars = ScrollBars.Horizontal;
        txtBoxMain.Size = new Size(403, 137);
        txtBoxMain.TabIndex = 0;
        txtBoxMain.TextAlign = HorizontalAlignment.Right;
        // 
        // buttonClear
        // 
        buttonClear.BackColor = Color.FromArgb(99, 104, 126);
        buttonClear.FlatAppearance.BorderSize = 0;
        buttonClear.FlatStyle = FlatStyle.Flat;
        buttonClear.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
        buttonClear.ForeColor = Color.FromArgb(255, 54, 100);
        buttonClear.Location = new Point(6, 148);
        buttonClear.Margin = new Padding(4);
        buttonClear.Name = "buttonClear";
        buttonClear.Size = new Size(95, 84);
        buttonClear.TabIndex = 1;
        buttonClear.Text = "AC";
        buttonClear.UseVisualStyleBackColor = false;
        buttonClear.Click += ButtomClear_Click;
        // 
        // buttonOperationPercentage
        // 
        buttonOperationPercentage.BackColor = Color.FromArgb(99, 104, 126);
        buttonOperationPercentage.FlatAppearance.BorderSize = 0;
        buttonOperationPercentage.FlatStyle = FlatStyle.Flat;
        buttonOperationPercentage.ForeColor = Color.FromArgb(255, 54, 100);
        buttonOperationPercentage.Location = new Point(109, 148);
        buttonOperationPercentage.Margin = new Padding(4);
        buttonOperationPercentage.Name = "buttonOperationPercentage";
        buttonOperationPercentage.Size = new Size(95, 84);
        buttonOperationPercentage.TabIndex = 2;
        buttonOperationPercentage.Text = "%";
        buttonOperationPercentage.UseVisualStyleBackColor = false;
        buttonOperationPercentage.Click += ButtomOperation_Click;
        // 
        // buttonOperationAdd
        // 
        buttonOperationAdd.BackColor = Color.FromArgb(99, 104, 126);
        buttonOperationAdd.FlatAppearance.BorderSize = 0;
        buttonOperationAdd.FlatStyle = FlatStyle.Flat;
        buttonOperationAdd.ForeColor = Color.FromArgb(255, 54, 100);
        buttonOperationAdd.Location = new Point(211, 148);
        buttonOperationAdd.Margin = new Padding(4);
        buttonOperationAdd.Name = "buttonOperationAdd";
        buttonOperationAdd.Size = new Size(95, 84);
        buttonOperationAdd.TabIndex = 3;
        buttonOperationAdd.Text = "+";
        buttonOperationAdd.UseVisualStyleBackColor = false;
        buttonOperationAdd.Click += ButtomOperation_Click;
        // 
        // buttonOperationSubtract
        // 
        buttonOperationSubtract.BackColor = Color.FromArgb(99, 104, 126);
        buttonOperationSubtract.FlatAppearance.BorderSize = 0;
        buttonOperationSubtract.FlatStyle = FlatStyle.Flat;
        buttonOperationSubtract.ForeColor = Color.FromArgb(255, 54, 100);
        buttonOperationSubtract.Location = new Point(314, 148);
        buttonOperationSubtract.Margin = new Padding(4);
        buttonOperationSubtract.Name = "buttonOperationSubtract";
        buttonOperationSubtract.Size = new Size(95, 84);
        buttonOperationSubtract.TabIndex = 4;
        buttonOperationSubtract.Text = "-";
        buttonOperationSubtract.UseVisualStyleBackColor = false;
        buttonOperationSubtract.Click += ButtomOperation_Click;
        // 
        // buttonOperationMultiply
        // 
        buttonOperationMultiply.BackColor = Color.FromArgb(99, 104, 126);
        buttonOperationMultiply.FlatAppearance.BorderSize = 0;
        buttonOperationMultiply.FlatStyle = FlatStyle.Flat;
        buttonOperationMultiply.ForeColor = Color.FromArgb(255, 54, 100);
        buttonOperationMultiply.Location = new Point(314, 240);
        buttonOperationMultiply.Margin = new Padding(4);
        buttonOperationMultiply.Name = "buttonOperationMultiply";
        buttonOperationMultiply.Size = new Size(95, 84);
        buttonOperationMultiply.TabIndex = 8;
        buttonOperationMultiply.Text = "*";
        buttonOperationMultiply.UseVisualStyleBackColor = false;
        buttonOperationMultiply.Click += ButtomOperation_Click;
        // 
        // buttonNumberThree
        // 
        buttonNumberThree.BackColor = Color.FromArgb(58, 63, 93);
        buttonNumberThree.FlatAppearance.BorderSize = 0;
        buttonNumberThree.FlatStyle = FlatStyle.Flat;
        buttonNumberThree.ForeColor = Color.Transparent;
        buttonNumberThree.Location = new Point(211, 240);
        buttonNumberThree.Margin = new Padding(4);
        buttonNumberThree.Name = "buttonNumberThree";
        buttonNumberThree.Size = new Size(95, 84);
        buttonNumberThree.TabIndex = 7;
        buttonNumberThree.Text = "3";
        buttonNumberThree.UseVisualStyleBackColor = false;
        buttonNumberThree.Click += ButtomNumber_Click;
        // 
        // buttonNumberTwo
        // 
        buttonNumberTwo.BackColor = Color.FromArgb(58, 63, 93);
        buttonNumberTwo.FlatAppearance.BorderSize = 0;
        buttonNumberTwo.FlatStyle = FlatStyle.Flat;
        buttonNumberTwo.ForeColor = Color.Transparent;
        buttonNumberTwo.Location = new Point(109, 240);
        buttonNumberTwo.Margin = new Padding(4);
        buttonNumberTwo.Name = "buttonNumberTwo";
        buttonNumberTwo.Size = new Size(95, 84);
        buttonNumberTwo.TabIndex = 6;
        buttonNumberTwo.Text = "2";
        buttonNumberTwo.UseVisualStyleBackColor = false;
        buttonNumberTwo.Click += ButtomNumber_Click;
        // 
        // buttonNumberOne
        // 
        buttonNumberOne.BackColor = Color.FromArgb(58, 63, 93);
        buttonNumberOne.FlatAppearance.BorderColor = Color.FromArgb(58, 63, 93);
        buttonNumberOne.FlatAppearance.BorderSize = 0;
        buttonNumberOne.FlatStyle = FlatStyle.Flat;
        buttonNumberOne.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
        buttonNumberOne.ForeColor = Color.Transparent;
        buttonNumberOne.Location = new Point(5, 240);
        buttonNumberOne.Margin = new Padding(4);
        buttonNumberOne.Name = "buttonNumberOne";
        buttonNumberOne.Size = new Size(95, 84);
        buttonNumberOne.TabIndex = 5;
        buttonNumberOne.Text = "1";
        buttonNumberOne.UseVisualStyleBackColor = false;
        buttonNumberOne.Click += ButtomNumber_Click;
        // 
        // buttonOperationDivide
        // 
        buttonOperationDivide.BackColor = Color.FromArgb(99, 104, 126);
        buttonOperationDivide.FlatAppearance.BorderSize = 0;
        buttonOperationDivide.FlatStyle = FlatStyle.Flat;
        buttonOperationDivide.ForeColor = Color.FromArgb(255, 54, 100);
        buttonOperationDivide.Location = new Point(314, 330);
        buttonOperationDivide.Margin = new Padding(4);
        buttonOperationDivide.Name = "buttonOperationDivide";
        buttonOperationDivide.Size = new Size(95, 84);
        buttonOperationDivide.TabIndex = 12;
        buttonOperationDivide.Text = "/";
        buttonOperationDivide.UseVisualStyleBackColor = false;
        buttonOperationDivide.Click += ButtomOperation_Click;
        // 
        // buttonNumberSix
        // 
        buttonNumberSix.BackColor = Color.FromArgb(58, 63, 93);
        buttonNumberSix.FlatAppearance.BorderSize = 0;
        buttonNumberSix.FlatStyle = FlatStyle.Flat;
        buttonNumberSix.ForeColor = Color.Transparent;
        buttonNumberSix.Location = new Point(211, 330);
        buttonNumberSix.Margin = new Padding(4);
        buttonNumberSix.Name = "buttonNumberSix";
        buttonNumberSix.Size = new Size(95, 84);
        buttonNumberSix.TabIndex = 11;
        buttonNumberSix.Text = "6";
        buttonNumberSix.UseVisualStyleBackColor = false;
        buttonNumberSix.Click += ButtomNumber_Click;
        // 
        // buttonNumberFive
        // 
        buttonNumberFive.BackColor = Color.FromArgb(58, 63, 93);
        buttonNumberFive.FlatAppearance.BorderSize = 0;
        buttonNumberFive.FlatStyle = FlatStyle.Flat;
        buttonNumberFive.ForeColor = Color.Transparent;
        buttonNumberFive.Location = new Point(109, 330);
        buttonNumberFive.Margin = new Padding(4);
        buttonNumberFive.Name = "buttonNumberFive";
        buttonNumberFive.Size = new Size(95, 84);
        buttonNumberFive.TabIndex = 10;
        buttonNumberFive.Text = "5";
        buttonNumberFive.UseVisualStyleBackColor = false;
        buttonNumberFive.Click += ButtomNumber_Click;
        // 
        // buttonNumberFour
        // 
        buttonNumberFour.BackColor = Color.FromArgb(58, 63, 93);
        buttonNumberFour.FlatAppearance.BorderSize = 0;
        buttonNumberFour.FlatStyle = FlatStyle.Flat;
        buttonNumberFour.ForeColor = Color.Transparent;
        buttonNumberFour.Location = new Point(5, 330);
        buttonNumberFour.Margin = new Padding(4);
        buttonNumberFour.Name = "buttonNumberFour";
        buttonNumberFour.Size = new Size(95, 84);
        buttonNumberFour.TabIndex = 9;
        buttonNumberFour.Text = "4";
        buttonNumberFour.UseVisualStyleBackColor = false;
        buttonNumberFour.Click += ButtomNumber_Click;
        // 
        // buttonEqual
        // 
        buttonEqual.BackColor = Color.FromArgb(255, 54, 100);
        buttonEqual.FlatAppearance.BorderSize = 0;
        buttonEqual.FlatStyle = FlatStyle.Flat;
        buttonEqual.ForeColor = Color.Transparent;
        buttonEqual.Location = new Point(314, 421);
        buttonEqual.Margin = new Padding(4);
        buttonEqual.Name = "buttonEqual";
        buttonEqual.Size = new Size(95, 174);
        buttonEqual.TabIndex = 16;
        buttonEqual.Text = "=";
        buttonEqual.UseVisualStyleBackColor = false;
        buttonEqual.Click += ButtomEqual_Click;
        // 
        // buttonNumberNine
        // 
        buttonNumberNine.BackColor = Color.FromArgb(58, 63, 93);
        buttonNumberNine.FlatAppearance.BorderSize = 0;
        buttonNumberNine.FlatStyle = FlatStyle.Flat;
        buttonNumberNine.ForeColor = Color.Transparent;
        buttonNumberNine.Location = new Point(211, 421);
        buttonNumberNine.Margin = new Padding(4);
        buttonNumberNine.Name = "buttonNumberNine";
        buttonNumberNine.Size = new Size(95, 84);
        buttonNumberNine.TabIndex = 15;
        buttonNumberNine.Text = "9";
        buttonNumberNine.UseVisualStyleBackColor = false;
        buttonNumberNine.Click += ButtomNumber_Click;
        // 
        // buttonNumberEight
        // 
        buttonNumberEight.BackColor = Color.FromArgb(58, 63, 93);
        buttonNumberEight.FlatAppearance.BorderSize = 0;
        buttonNumberEight.FlatStyle = FlatStyle.Flat;
        buttonNumberEight.ForeColor = Color.Transparent;
        buttonNumberEight.Location = new Point(109, 421);
        buttonNumberEight.Margin = new Padding(4);
        buttonNumberEight.Name = "buttonNumberEight";
        buttonNumberEight.Size = new Size(95, 84);
        buttonNumberEight.TabIndex = 14;
        buttonNumberEight.Text = "8";
        buttonNumberEight.UseVisualStyleBackColor = false;
        buttonNumberEight.Click += ButtomNumber_Click;
        // 
        // buttonNumberSeven
        // 
        buttonNumberSeven.BackColor = Color.FromArgb(58, 63, 93);
        buttonNumberSeven.FlatAppearance.BorderSize = 0;
        buttonNumberSeven.FlatStyle = FlatStyle.Flat;
        buttonNumberSeven.ForeColor = Color.Transparent;
        buttonNumberSeven.Location = new Point(6, 421);
        buttonNumberSeven.Margin = new Padding(4);
        buttonNumberSeven.Name = "buttonNumberSeven";
        buttonNumberSeven.Size = new Size(95, 84);
        buttonNumberSeven.TabIndex = 13;
        buttonNumberSeven.Text = "7";
        buttonNumberSeven.UseVisualStyleBackColor = false;
        buttonNumberSeven.Click += ButtomNumber_Click;
        // 
        // buttonClearC
        // 
        buttonClearC.BackColor = Color.FromArgb(58, 63, 93);
        buttonClearC.FlatAppearance.BorderSize = 0;
        buttonClearC.FlatStyle = FlatStyle.Flat;
        buttonClearC.ForeColor = Color.FromArgb(255, 54, 100);
        buttonClearC.Location = new Point(211, 512);
        buttonClearC.Margin = new Padding(4);
        buttonClearC.Name = "buttonClearC";
        buttonClearC.Size = new Size(95, 84);
        buttonClearC.TabIndex = 19;
        buttonClearC.Text = "C";
        buttonClearC.UseVisualStyleBackColor = false;
        // 
        // buttonNumberZero
        // 
        buttonNumberZero.BackColor = Color.FromArgb(58, 63, 93);
        buttonNumberZero.FlatAppearance.BorderSize = 0;
        buttonNumberZero.FlatStyle = FlatStyle.Flat;
        buttonNumberZero.ForeColor = Color.Transparent;
        buttonNumberZero.Location = new Point(109, 512);
        buttonNumberZero.Margin = new Padding(4);
        buttonNumberZero.Name = "buttonNumberZero";
        buttonNumberZero.Size = new Size(95, 84);
        buttonNumberZero.TabIndex = 18;
        buttonNumberZero.Text = "0";
        buttonNumberZero.UseVisualStyleBackColor = false;
        buttonNumberZero.Click += ButtomNumber_Click;
        // 
        // buttonDecimalPoint
        // 
        buttonDecimalPoint.BackColor = Color.FromArgb(58, 63, 93);
        buttonDecimalPoint.FlatAppearance.BorderSize = 0;
        buttonDecimalPoint.FlatStyle = FlatStyle.Flat;
        buttonDecimalPoint.ForeColor = Color.FromArgb(255, 54, 100);
        buttonDecimalPoint.Location = new Point(5, 512);
        buttonDecimalPoint.Margin = new Padding(4);
        buttonDecimalPoint.Name = "buttonDecimalPoint";
        buttonDecimalPoint.Size = new Size(95, 84);
        buttonDecimalPoint.TabIndex = 17;
        buttonDecimalPoint.Text = ".";
        buttonDecimalPoint.UseVisualStyleBackColor = false;
        buttonDecimalPoint.Click += ButtomPoint_Click;
        // 
        // labelOperation
        // 
        labelOperation.AutoSize = true;
        labelOperation.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
        labelOperation.ForeColor = SystemColors.ControlLightLight;
        labelOperation.Location = new Point(304, 9);
        labelOperation.Name = "labelOperation";
        labelOperation.Size = new Size(0, 27);
        labelOperation.TabIndex = 20;
        // 
        // CalculadoraView
        // 
        AutoScaleDimensions = new SizeF(10F, 23F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(52, 57, 87);
        ClientSize = new Size(415, 604);
        Controls.Add(labelOperation);
        Controls.Add(buttonClearC);
        Controls.Add(buttonNumberZero);
        Controls.Add(buttonDecimalPoint);
        Controls.Add(buttonEqual);
        Controls.Add(buttonNumberNine);
        Controls.Add(buttonNumberEight);
        Controls.Add(buttonNumberSeven);
        Controls.Add(buttonOperationDivide);
        Controls.Add(buttonNumberSix);
        Controls.Add(buttonNumberFive);
        Controls.Add(buttonNumberFour);
        Controls.Add(buttonOperationMultiply);
        Controls.Add(buttonNumberThree);
        Controls.Add(buttonNumberTwo);
        Controls.Add(buttonNumberOne);
        Controls.Add(buttonOperationSubtract);
        Controls.Add(buttonOperationAdd);
        Controls.Add(buttonOperationPercentage);
        Controls.Add(buttonClear);
        Controls.Add(txtBoxMain);
        Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(4);
        MaximizeBox = false;
        Name = "CalculadoraView";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Calculadora";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox txtBoxMain;
    private Button buttonClear;
    private Button buttonOperationPercentage;
    private Button buttonOperationAdd;
    private Button buttonOperationSubtract;
    private Button buttonOperationMultiply;
    private Button buttonNumberThree;
    private Button buttonNumberTwo;
    private Button buttonNumberOne;
    private Button buttonOperationDivide;
    private Button buttonNumberSix;
    private Button buttonNumberFive;
    private Button buttonNumberFour;
    private Button buttonEqual;
    private Button buttonNumberNine;
    private Button buttonNumberEight;
    private Button buttonNumberSeven;
    private Button buttonClearC;
    private Button buttonNumberZero;
    private Button buttonDecimalPoint;
    private Label labelOperation;
}
