using System;
using System.Windows.Forms;

namespace Number_Systems
{
    public partial class MainForm : Form
    {
        private Number numberMathFirst = new(0);
        private Number numberMathSecond = new (0);
        private Number numberComparisonFirst = new(0);
        private Number numberComparisonSecond = new(0);

        public MainForm()
        {
            InitializeComponent();
        }

        //стандартные значния comboBox при запуске
        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBoxFirstNumber.SelectedItem = "10";
            comboBoxSecondNumber.SelectedItem = "10";
            comboBoxComparisonFirstValue.SelectedItem = "10";
            comboBoxComparisonSecondValue.SelectedItem = "10";
        }

        //расчёт математических операций
        private void ComboBoxFirstNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            long number = Convert.ToInt64(numberMathFirst.Value, numberMathFirst.System);
            byte system = byte.Parse(comboBoxFirstNumber.Text);
            numberMathFirst = new Number(Convert.ToString(number, system).ToUpper(), system);
            textBoxFirstNumber.Text = numberMathFirst.Value;
        }

        private void ComboBoxSecondNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            long number = Convert.ToInt64(numberMathSecond.Value, numberMathSecond.System);
            byte system = byte.Parse(comboBoxSecondNumber.Text);
            numberMathSecond = new Number(Convert.ToString(number, system).ToUpper(), system);
            textBoxSecondNumber.Text = numberMathSecond.Value;
        }

        private void MathChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxFirstNumber.Text) && !String.IsNullOrEmpty(textBoxSecondNumber.Text))
            {
                numberMathFirst = new(textBoxFirstNumber.Text, byte.Parse(comboBoxFirstNumber.Text));
                numberMathSecond = new(textBoxSecondNumber.Text, byte.Parse(comboBoxSecondNumber.Text));

                LabelMathAnswer.Text = comboBoxMathOperation.Text switch
                {
                    "+" => (numberMathFirst + numberMathSecond).Value,
                    "-" => (numberMathFirst - numberMathSecond).Value,
                    "*" => (numberMathFirst * numberMathSecond).Value,
                    "/" when comboBoxSecondNumber.SelectedItem.ToString() != "0" => (numberMathFirst / numberMathSecond).Value,
                    _ => "",
                };
            }
            else
            {
                LabelMathAnswer.Text = "";
            }
        }

        //сравнение двух чисел
        private void ComboBoxComparisonFirstValue_SelectedValueChanged(object sender, EventArgs e)
        {
            long number = Convert.ToInt64(numberComparisonFirst.Value, numberComparisonFirst.System);
            byte system = byte.Parse(comboBoxComparisonFirstValue.Text);
            numberComparisonFirst = new Number(Convert.ToString(number, system).ToUpper(), system);
            textBoxComparisonFirstValue.Text = numberComparisonFirst.Value;
        }

        private void ComboBoxComparisonSecondValue_SelectedValueChanged(object sender, EventArgs e)
        {
            long number = Convert.ToInt64(numberComparisonSecond.Value, numberComparisonSecond.System);
            byte system = byte.Parse(comboBoxComparisonSecondValue.Text);
            numberComparisonFirst = new Number(Convert.ToString(number, system).ToUpper(), system);
            textBoxComparisonSecondValue.Text = numberComparisonSecond.Value;
        }

        private void ComparisonChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxComparisonFirstValue.Text) && !String.IsNullOrEmpty(textBoxComparisonSecondValue.Text))
            {
                numberComparisonFirst = new(textBoxComparisonFirstValue.Text, byte.Parse(comboBoxComparisonFirstValue.Text));
                numberComparisonSecond = new(textBoxComparisonSecondValue.Text, byte.Parse(comboBoxComparisonSecondValue.Text));

                labelComparisonAnswer.Text = comboBoxComparison.Text switch
                {
                    "=" => numberComparisonFirst == numberComparisonSecond ? $"{numberComparisonFirst.Value} равно {numberComparisonSecond.Value}" : $"{numberComparisonFirst.Value} не равно {numberComparisonSecond.Value}",
                    "≠" => numberComparisonFirst != numberComparisonSecond ? $"{numberComparisonFirst.Value} не равно {numberComparisonSecond.Value}" : $"{numberComparisonFirst.Value} равно {numberComparisonSecond.Value}",
                    "<" => numberComparisonFirst < numberComparisonSecond ? $"{numberComparisonFirst.Value} меньше {numberComparisonSecond.Value}" : $"{numberComparisonFirst.Value} больше или равно {numberComparisonSecond.Value}",
                    "≤" => numberComparisonFirst <= numberComparisonSecond ? $"{numberComparisonFirst.Value} меньше или равно {numberComparisonSecond.Value}" : $"{numberComparisonFirst.Value} больше {numberComparisonSecond.Value}",
                    ">" => numberComparisonFirst > numberComparisonSecond ? $"{numberComparisonFirst.Value} больше {numberComparisonSecond.Value}" : $"{numberComparisonFirst.Value} меньше или равно {numberComparisonSecond.Value}",
                    "≥" => numberComparisonFirst >= numberComparisonSecond ? $"{numberComparisonFirst.Value} больше или равно {numberComparisonSecond.Value}" : $"{numberComparisonFirst.Value} Меньше {numberComparisonSecond.Value}",
                    _ => "",
                };
            }
            else
            {
                labelComparisonAnswer.Text = "";
            }
        }

        //преобразование в другие системы счисления
        private void NumberChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxNumber.Text))
            {
                Number number = new(textBoxNumber.Text, 10);

                labelBinary.Text = $"Двоичная {number.ConvertFromDecimal(2)}";
                labelОctal.Text = $"Восмеричная {number.ConvertFromDecimal(8)}";
                labeHexadecimal.Text = $"Шестнадцатеричная {number.ConvertFromDecimal(16)}";
            }
            else
            {
                labelBinary.Text = "";
                labelОctal.Text = "";
                labeHexadecimal.Text = "";
            }
        }

        //проверки ввода
        private void TextBoxFirstNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !CheckInput(comboBoxFirstNumber.Text, e.KeyChar);
            numberMathFirst = new(textBoxFirstNumber.Text, byte.Parse(comboBoxFirstNumber.Text));
        }

        private void TextBoxSecondNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !CheckInput(comboBoxSecondNumber.Text, e.KeyChar);
            numberMathSecond = new(textBoxSecondNumber.Text, byte.Parse(comboBoxSecondNumber.Text));
        }

        private void TextBoxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !CheckInput("10", e.KeyChar);
        }

        private void TextBoxComparisonFirstValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !CheckInput(comboBoxComparisonFirstValue.Text, e.KeyChar);
            numberComparisonFirst = new(textBoxComparisonFirstValue.Text, byte.Parse(comboBoxComparisonFirstValue.Text));
        }

        private void TextBoxComparisonSecondValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !CheckInput(comboBoxComparisonSecondValue.Text, e.KeyChar);
            numberComparisonSecond = new(textBoxComparisonSecondValue.Text, byte.Parse(comboBoxComparisonSecondValue.Text));

        }

        private static bool CheckInput(string system, char KeyChar)
        {
            return system switch
            {
                "2" => KeyChar == '0' || KeyChar == '1' || Char.IsControl(KeyChar),
                "8" => KeyChar == '0' ||
                       KeyChar == '1' ||
                       KeyChar == '2' ||
                       KeyChar == '3' ||
                       KeyChar == '4' ||
                       KeyChar == '5' ||
                       KeyChar == '6' ||
                       KeyChar == '7' ||
                       Char.IsControl(KeyChar),
                "10" => Char.IsNumber(KeyChar) || Char.IsControl(KeyChar),
                "16" => KeyChar == 'A' ||
                        KeyChar == 'B' ||
                        KeyChar == 'C' ||
                        KeyChar == 'D' ||
                        KeyChar == 'E' ||
                        KeyChar == 'F' ||
                        KeyChar == 'a' ||
                        KeyChar == 'b' ||
                        KeyChar == 'c' ||
                        KeyChar == 'd' ||
                        KeyChar == 'e' ||
                        KeyChar == 'f' ||
                        Char.IsNumber(KeyChar) || Char.IsControl(KeyChar),
                _ => false,
            };
        }
    }
}