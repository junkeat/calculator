using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{

    public partial class Form1 : Form
    {
        public string stringNum1 = "";
        public string operation;
        public double final;
        public double num1;
        public double num2;
        public double result;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            textBox1.Text = "0";
        }

        private void BtnNum0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            } else
            {
                textBox1.Text += "0";
            }
            label1.Focus();
        }

        private void BtnNum1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
            label1.Focus();
        }

        private void BtnNum2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
            label1.Focus();
        }

        private void BtnNum3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
            label1.Focus();
        }

        private void BtnNum4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
            label1.Focus();
        }

        private void BtnNum5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
            label1.Focus();
        }

        private void BtnNum6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
            label1.Focus();
        }

        private void BtnNum7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
            label1.Focus();
        }

        private void BtnNum8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
            label1.Focus();
        }

        private void BtnNum9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
            label1.Focus();
        }

        private void BtnBackspace_Click(object sender, EventArgs e)
        {
            if (stringNum1 == "")
            {
                decimalLock = false;
            }
            if (stringNum1.Length != 0)
            {
                if (stringNum1.Substring(stringNum1.Length - 1, 1) == ".")
                {
                    decimalLock = false;
                }
                stringNum1 = stringNum1.Substring(0, stringNum1.Length - 1);
            }
            if (textBox1.Text == "0")
            {
                stringNum1 = "0";
            }
            textBox1.Text = stringNum1;
            label1.Focus();
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            operation = "SUM";
            label1.Text = textBox1.Text + " +";
            if (textBox1.Text != "")
            {
                try
                {
                    num1 = double.Parse(textBox1.Text);
                }
                catch
                {
                    //System.Windows.Forms.MessageBox.Show("Invalid Syntax");
                    stringNum1 = "";
                    textBox1.Text = "";
                    label1.Text = "Invalid Syntax";
                }
            }
            textBox1.Text = "";
            stringNum1 = "";
            decimalLock = false;
            label1.Focus();
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            operation = "MIN";
            label1.Text = textBox1.Text + " -";
            if (textBox1.Text != "")
            {
                try
                {
                    num1 = double.Parse(textBox1.Text);
                }
                catch
                {
                    stringNum1 = "";
                    textBox1.Text = "";
                    label1.Text = "Invalid Syntax";
                }
            }
            textBox1.Text = "";
            stringNum1 = "";
            decimalLock = false;
            label1.Focus();
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            operation = "MUL";
            label1.Text = textBox1.Text + " x";
            if (textBox1.Text != "")
            {
                try
                {
                    num1 = double.Parse(textBox1.Text);
                }
                catch
                {
                    stringNum1 = "";
                    textBox1.Text = "";
                    label1.Text = "Invalid Syntax";
                }
            }
            textBox1.Text = "";
            stringNum1 = "";
            decimalLock = false;
            label1.Focus();
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            operation = "DIV";
            label1.Text = textBox1.Text + " /";
            if (textBox1.Text != "")
            {
                try
                {
                    num1 = double.Parse(textBox1.Text);
                }
                catch
                {
                    stringNum1 = "";
                    textBox1.Text = "";
                    label1.Text = "Invalid Syntax";
                }
            }
            textBox1.Text = "";
            stringNum1 = "";
            decimalLock = false;
            label1.Focus();
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "SUM":
                    if (textBox1.Text == result.ToString())
                    {
                        result += num2;
                        textBox1.Text = result.ToString();
                    }
                    else
                    {
                        try
                        {
                            num2 = double.Parse(textBox1.Text);
                            result = num1 + num2;
                        }
                        catch
                        {
                            operation = "";
                            stringNum1 = "";
                            textBox1.Text = "";
                            label1.Text = "Invalid Syntax";
                        }
                    }
                    break;
                case "MIN":
                    if (textBox1.Text == result.ToString())
                    {
                        result -= num2;
                        textBox1.Text = result.ToString();
                    }
                    else
                    {
                        try
                        {
                            num2 = double.Parse(textBox1.Text);
                            result = num1 - num2;
                        }
                        catch
                        {
                            operation = "";
                            stringNum1 = "";
                            textBox1.Text = "";
                            label1.Text = "Invalid Syntax";
                        }
                    }
                    break;
                case "MUL":
                    if (textBox1.Text == result.ToString())
                    {
                        result *= num2;
                        textBox1.Text = result.ToString();
                    }
                    else
                    {
                        try
                        {
                            num2 = double.Parse(textBox1.Text);
                            result = num1 * num2;
                        }
                        catch
                        {
                            operation = "";
                            stringNum1 = "";
                            textBox1.Text = "";
                            label1.Text = "Invalid Syntax";
                        }
                    }
                    break;
                case "DIV":
                    if (textBox1.Text == result.ToString())
                    {
                        result /= num2;
                        textBox1.Text = result.ToString();
                    }
                    else
                    {
                        try
                        {
                            num2 = double.Parse(textBox1.Text);
                            result = num1 / num2;
                        }
                        catch
                        {
                            operation = "";
                            stringNum1 = "";
                            textBox1.Text = "";
                            label1.Text = "Invalid Syntax";
                        }
                    }
                    break;
                default:
                    break;
            }
            label1.Text = "";
            stringNum1 = "";
            decimalLock = false;
            for (int x = 1; result.ToString().Length >= x; x++)
            {
                if (result.ToString().Substring(x - 1, 1) == ".")
                {
                    decimalLock = true;
                }
            }
            textBox1.Text = result.ToString();
            label1.Focus();
        }

        private void BtnDot_Click(object sender, EventArgs e)
        {
            for (int x = 1; textBox1.Text.Length >= x; x++)
            {
                string z = textBox1.Text.Substring(x - 1, 1);

                if (z == ".")
                {
                    decimalLock = true;
                }

                if (!decimalLock)
                {
                    textBox1.Text += ".";
                    decimalLock = true;
                }
            }
            label1.Focus();
        }

        private void BtnNegative_Click(object sender, EventArgs e)
        {
            stringNum1 = textBox1.Text;
            try
            {
                if (stringNum1.Substring(0, 1) == "-")
                {
                    stringNum1 = stringNum1.Substring(1, stringNum1.Length - 1);
                }
                else
                {
                    if (stringNum1 != "0")
                    {
                        stringNum1 = "-" + stringNum1;
                    }
                }
            }
            catch
            {
                textBox1.Text = "0";
            }
            textBox1.Text = stringNum1;
            label1.Focus();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            stringNum1 = "";
            textBox1.Text = "0";
            num1 = 0;
            num2 = 0;
            operation = "";
            decimalLock = false;
            label1.Text = "";
            result = 0;
            label1.Focus();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            stringNum1 = textBox1.Text;
            try
            {
                double num = double.Parse(stringNum1);
            }
            catch
            {
                stringNum1 = textBox1.Text;
            }
        }

        private void BtnSquare_Click(object sender, EventArgs e)
        {
            try
            {
                double num = double.Parse(textBox1.Text);
                stringNum1 = textBox1.Text;
                textBox1.Text = (num * num).ToString();
                decimalLock = false;
                for (int x = 1; textBox1.Text.Length >= x; x++)
                {
                    if (textBox1.Text.Substring(x - 1, 1) == ".")
                    {
                        decimalLock = true;
                    }
                }
            } 
            catch
            {

            }
            label1.Focus();
        }

        bool decimalLock = false;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            string keyCode = e.KeyCode.ToString();
            switch (keyCode)
            {
                case "D0":
                case "NumPad0":
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "0";
                    }
                    else
                    {
                        textBox1.Text += "0";
                    }
                    break;
                case "D1":
                case "NumPad1":
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "1";
                    }
                    else
                    {
                        textBox1.Text += "1";
                    }
                    break;
                case "D2":
                case "NumPad2":
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "2";
                    }
                    else
                    {
                        textBox1.Text += "2";
                    }
                    break;
                case "D3":
                case "NumPad3":
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "3";
                    }
                    else
                    {
                        textBox1.Text += "3";
                    }
                    break;
                case "D4":
                case "NumPad4":
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "4";
                    }
                    else
                    {
                        textBox1.Text += "4";
                    }
                    break;
                case "D5":
                case "NumPad5":
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "5";
                    }
                    else
                    {
                        textBox1.Text += "5";
                    }
                    break;
                case "D6":
                case "NumPad6":
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "6";
                    }
                    else
                    {
                        textBox1.Text += "6";
                    }
                    break;
                case "D7":
                case "NumPad7":
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "7";
                    }
                    else
                    {
                        textBox1.Text += "7";
                    }
                    break;
                case "D8":
                case "NumPad8":
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "8";
                    }
                    else
                    {
                        textBox1.Text += "8";
                    }
                    break;
                case "D9":
                case "NumPad9":
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "9";
                    }
                    else
                    {
                        textBox1.Text += "9";
                    }
                    break;
                case "OemPeriod":
                case "Decimal":
                    for (int x = 1; textBox1.Text.Length >= x; x++)
                    {
                        string z = textBox1.Text.Substring(x - 1, 1);

                        if (z == ".")
                        {
                            decimalLock = true;
                        }

                        if (!decimalLock)
                        {
                            textBox1.Text += ".";
                            decimalLock = true;
                        }
                    }
                    break;
                case "Back":
                    if (stringNum1 == "")
                    {
                        decimalLock = false;
                    }
                    if (stringNum1.Length != 0)
                    {
                        if (stringNum1.Substring(stringNum1.Length - 1, 1) == ".")
                        {
                            decimalLock = false;
                        }
                        stringNum1 = stringNum1.Substring(0, stringNum1.Length - 1);
                    }
                    if (textBox1.Text == "0")
                    {
                        stringNum1 = "0";
                    }
                    textBox1.Text = stringNum1;
                    break;
                case "C":
                    stringNum1 = "";
                    textBox1.Text = "0";
                    num1 = 0;
                    num2 = 0;
                    operation = "";
                    decimalLock = false;
                    label1.Text = "";
                    result = 0;
                    label1.Focus();
                    break;
            }

            if (e.KeyCode == Keys.Oemplus)
            {
                if (e.Modifiers == Keys.Shift)
                {
                    operation = "SUM";
                    label1.Text = textBox1.Text + " +";
                    if (textBox1.Text != "")
                    {
                        try
                        {
                            num1 = double.Parse(textBox1.Text);
                        }
                        catch
                        {
                            //System.Windows.Forms.MessageBox.Show("Invalid Syntax");
                            stringNum1 = "";
                            textBox1.Text = "";
                            label1.Text = "Invalid Syntax";
                        }
                    }
                    textBox1.Text = "";
                    stringNum1 = "";
                    decimalLock = false;
                }
            }
            else if (e.KeyCode == Keys.Add)
            {
                operation = "SUM";
                label1.Text = textBox1.Text + " +";
                if (textBox1.Text != "")
                {
                    try
                    {
                        num1 = double.Parse(textBox1.Text);
                    }
                    catch
                    {
                        //System.Windows.Forms.MessageBox.Show("Invalid Syntax");
                        stringNum1 = "";
                        textBox1.Text = "";
                        label1.Text = "Invalid Syntax";
                    }
                }
                textBox1.Text = "";
                stringNum1 = "";
                decimalLock = false;
            }

            if (e.KeyCode == Keys.OemMinus || e.KeyCode == Keys.Subtract)
            {
                operation = "MIN";
                label1.Text = textBox1.Text + " -";
                if (textBox1.Text != "")
                {
                    try
                    {
                        num1 = double.Parse(textBox1.Text);
                    }
                    catch
                    {
                        stringNum1 = "";
                        textBox1.Text = "";
                        label1.Text = "Invalid Syntax";
                    }
                }
                textBox1.Text = "";
                stringNum1 = "";
                decimalLock = false;
            }

            if (e.KeyCode == Keys.D8)
            {
                if (e.Modifiers == Keys.Shift)
                {
                    operation = "MUL";
                    label1.Text = textBox1.Text + " x";
                    if (textBox1.Text != "")
                    {
                        try
                        {
                            num1 = double.Parse(textBox1.Text);
                        }
                        catch
                        {
                            stringNum1 = "";
                            textBox1.Text = "";
                            label1.Text = "Invalid Syntax";
                        }
                    }
                    textBox1.Text = "";
                    stringNum1 = "";
                    decimalLock = false;
                }
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                operation = "MUL";
                label1.Text = textBox1.Text + " x";
                if (textBox1.Text != "")
                {
                    try
                    {
                        num1 = double.Parse(textBox1.Text);
                    }
                    catch
                    {
                        stringNum1 = "";
                        textBox1.Text = "";
                        label1.Text = "Invalid Syntax";
                    }
                }
                textBox1.Text = "";
                stringNum1 = "";
                decimalLock = false;
            }

            if (e.KeyCode == Keys.OemQuestion)
            {
                operation = "DIV";
                label1.Text = textBox1.Text + " /";
                if (textBox1.Text != "")
                {
                    try
                    {
                        num1 = double.Parse(textBox1.Text);
                    }
                    catch
                    {
                        stringNum1 = "";
                        textBox1.Text = "";
                        label1.Text = "Invalid Syntax";
                    }
                }
                textBox1.Text = "";
                stringNum1 = "";
                decimalLock = false;
            }
            else if (e.KeyCode == Keys.Divide)
            {
                operation = "DIV";
                label1.Text = textBox1.Text + " /";
                if (textBox1.Text != "")
                {
                    try
                    {
                        num1 = double.Parse(textBox1.Text);
                    }
                    catch
                    {
                        stringNum1 = "";
                        textBox1.Text = "";
                        label1.Text = "Invalid Syntax";
                    }
                }
                textBox1.Text = "";
                stringNum1 = "";
                decimalLock = false;
            }

            if (e.KeyCode == Keys.Enter)
            {
                switch (operation)
                {
                    case "SUM":
                        if (textBox1.Text == result.ToString())
                        {
                            result += num2;
                            textBox1.Text = result.ToString();
                        }
                        else
                        {
                            try
                            {
                                num2 = double.Parse(textBox1.Text);
                                result = num1 + num2;
                            }
                            catch
                            {
                                operation = "";
                                stringNum1 = "";
                                textBox1.Text = "";
                                label1.Text = "Invalid Syntax";
                            }
                        }
                        break;
                    case "MIN":
                        if (textBox1.Text == result.ToString())
                        {
                            result -= num2;
                            textBox1.Text = result.ToString();
                        }
                        else
                        {
                            try
                            {
                                num2 = double.Parse(textBox1.Text);
                                result = num1 - num2;
                            }
                            catch
                            {
                                operation = "";
                                stringNum1 = "";
                                textBox1.Text = "";
                                label1.Text = "Invalid Syntax";
                            }
                        }
                        break;
                    case "MUL":
                        if (textBox1.Text == result.ToString())
                        {
                            result *= num2;
                            textBox1.Text = result.ToString();
                        }
                        else
                        {
                            try
                            {
                                num2 = double.Parse(textBox1.Text);
                                result = num1 * num2;
                            }
                            catch
                            {
                                operation = "";
                                stringNum1 = "";
                                textBox1.Text = "";
                                label1.Text = "Invalid Syntax";
                            }
                        }
                        break;
                    case "DIV":
                        if (textBox1.Text == result.ToString())
                        {
                            result /= num2;
                            textBox1.Text = result.ToString();
                        }
                        else
                        {
                            try
                            {
                                num2 = double.Parse(textBox1.Text);
                                result = num1 / num2;
                            }
                            catch
                            {
                                operation = "";
                                stringNum1 = "";
                                textBox1.Text = "";
                                label1.Text = "Invalid Syntax";
                            }
                        }
                        break;
                    default:
                        break;
                }
                label1.Text = "";
                stringNum1 = "";
                decimalLock = false;
                for (int x = 1; result.ToString().Length >= x; x++)
                {
                    if (result.ToString().Substring(x - 1, 1) == ".")
                    {
                        decimalLock = true;
                    }
                }
                textBox1.Text = result.ToString();
                label1.Focus();
            }
        }
    }
}