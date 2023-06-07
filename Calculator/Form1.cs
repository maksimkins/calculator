namespace Calculator;

public partial class Form1 : Form
{
    private List<int> indexesOfOperations = new List<int>();
    private bool wasEqualsClicked = false;

    public Form1()
    {
        InitializeComponent();
    }

    private List<double> ConvertOperandsToDouble()
    {
        string equation = labelInputandRes.Text;

        List<string> operands = new List<string>();

        for (int i = 0; i < indexesOfOperations.Count; i++)
        {
            if (i == 0)
            {
                operands.Add(equation[0..indexesOfOperations[i]]);

                if (i == indexesOfOperations.Count - 1)
                    operands.Add(equation[(indexesOfOperations[i] + 1)..]);

                continue;
            }
            operands.Add(equation[(indexesOfOperations[i - 1] + 1)..indexesOfOperations[i]]);

            if (i == indexesOfOperations.Count - 1)
                operands.Add(equation[(indexesOfOperations[i] + 1)..]);
        }

        List<double> operandsDouble = new List<double>();

        foreach (var item in operands)
        {
            operandsDouble.Add(double.Parse(item));
        }

        return operandsDouble;
    }
    private string DoCalculations()
    {
        string equation = labelInputandRes.Text;

        List<double> operands = ConvertOperandsToDouble();

        List<char> operations = new List<char>();

        foreach (var i in indexesOfOperations)
        {
            operations.Add(equation[i]);
        }

        for (int i = 0; i < operations.Count; i++)
        {
            if (operations[i] == '*' || operations[i] == '/')
            {
                double tmp = operands[i];

                switch (operations[i])
                {
                    case '*':
                        tmp *= operands[i + 1];
                        break;
                    case '/':
                        tmp /= operands[i + 1];
                        break;
                }
                operands.RemoveAt(i);
                operands.RemoveAt(i);
                operands.Insert(i, tmp);
                operations.RemoveAt(i);
                i--;
            }
        }

        double res = operands[0];

        for (int i = 1; i < operands.Count; i++)
        {
            switch (operations[i - 1])
            {
                case '+':
                    res += operands[i];
                    break;
                case '-':
                    res -= operands[i];
                    break;
            }
        }

        return $"{res}";
    }

    private void ButtonClickedEquals(object sender, EventArgs e)
    {
        if (sender is Button senderButton)
        {
            if (string.IsNullOrEmpty(labelInputandRes.Text) || string.IsNullOrWhiteSpace(labelInputandRes.Text))
                return;

            if (indexesOfOperations.Count < 1)
                return;

            int lastIndexOfText = labelInputandRes.Text.Length - 1;

            if (!char.IsDigit(labelInputandRes.Text[lastIndexOfText]))
                return;

            string result = DoCalculations();

            labelInputandRes.Text += senderButton.Text;
            labelInputandRes.Text += result;

            labelHistory.Text += $"{labelInputandRes.Text}\n";///////DOWITHLOQS

            indexesOfOperations.Clear();
            wasEqualsClicked = true;

        }
    }
    private void ButtonClickedDeleteButton(object sender, EventArgs e)
    {
        if (sender is Button senderButton)
        {
            labelInputandRes.ResetText();
        }
    }

    private void ButtonClickedNumber(object sender, EventArgs e)
    {
        if (sender is Button senderButton)
        {

            if (wasEqualsClicked)
            {
                ButtonClickedDeleteButton(sender, e);
                wasEqualsClicked = false;
            }

            labelInputandRes.Text += senderButton.Text;
        }
    }

    private void ButtonClickedOperations(object sender, EventArgs e)
    {
        if (sender is Button senderButton)
        {
            if (string.IsNullOrEmpty(labelInputandRes.Text) || string.IsNullOrWhiteSpace(labelInputandRes.Text))
                return;

            int lastIndexOfText = labelInputandRes.Text.Length - 1;

            if (!char.IsDigit(labelInputandRes.Text[lastIndexOfText]))
                return;

            labelInputandRes.Text += senderButton.Text;
            indexesOfOperations.Add(lastIndexOfText + 1);
        }
    }

    private void ButtonClickedDot(object sender, EventArgs e)
    {
        if (sender is Button senderButton)
        {
            if (string.IsNullOrEmpty(labelInputandRes.Text) || string.IsNullOrWhiteSpace(labelInputandRes.Text))
                return;

            int indexOfLastOper = indexesOfOperations.LastOrDefault();

            int lastIndexOfText = labelInputandRes.Text.Length - 1;

            bool inNumAlreadyHasdot = labelInputandRes.Text[indexOfLastOper..lastIndexOfText].Contains(".");

            if (char.IsDigit(labelInputandRes.Text[lastIndexOfText]) && !inNumAlreadyHasdot)
                labelInputandRes.Text += senderButton.Text;
        }
    }

}