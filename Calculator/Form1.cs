namespace Calculator;

public partial class Form1 : Form
{
    private List<int> indexesOfOperations = new List<int>();
    public Form1()
    {
        InitializeComponent();
    }

    //private bool ContainsOperationsMPDU(string Text)
    //{
    //    bool contains = false;

    //    if (Text == null) return contains;

    //    if (Text.Contains("+") || Text.Contains("-") || Text.Contains("*") || Text.Contains("/")) { contains = true; }

    //    return contains;
    //}

    //private int FindIndexOfMPDU(string Text)
    //{
    //    if (Text.Contains('+')) return Text.IndexOf('+');
    //    if (Text.Contains('-')) return Text.IndexOf('-');
    //    if (Text.Contains('*')) return Text.IndexOf('*');
    //    if (Text.Contains('/')) return Text.IndexOf('/');
    //    return -1;
    //}

    private void ButtonClickedDeleteButton(object sender, EventArgs e)
    {// сделать все нормально, для равно чтобы выходило решение, после равно кнопка все стирает и пишет свой текст
        if (sender is Button senderButton)
        {
            labelInputandRes.ResetText();

            //if (senderButton.Text == "=" && (!ContainsOperationsMPDU(labelInputandRes.Text) || !double.TryParse(labelInputandRes.Text[(FindIndexOfMPDU(labelInputandRes.Text))..], out double d))) return;

            //if (senderButton.Text == "+" && ContainsOperationsMPDU(labelInputandRes.Text)) return;
            //if (senderButton.Text == "-" && ContainsOperationsMPDU(labelInputandRes.Text)) return;
            //if (senderButton.Text == "*" && ContainsOperationsMPDU(labelInputandRes.Text)) return;
            //if (senderButton.Text == "/" && ContainsOperationsMPDU(labelInputandRes.Text)) return;

            //if (senderButton.Text == "+" && string.IsNullOrEmpty(labelInputandRes.Text)) return;
            //if (senderButton.Text == "-" && string.IsNullOrEmpty(labelInputandRes.Text)) return;
            //if (senderButton.Text == "*" && string.IsNullOrEmpty(labelInputandRes.Text)) return;
            //if (senderButton.Text == "/" && string.IsNullOrEmpty(labelInputandRes.Text)) return;
            //if (senderButton.Text == "." && string.IsNullOrEmpty(labelInputandRes.Text)) return;

            //if (senderButton.Text == "+" && labelInputandRes.Text[labelInputandRes.Text.Length - 1] == '.') return;
            //if (senderButton.Text == "-" && labelInputandRes.Text[labelInputandRes.Text.Length - 1] == '.') return;
            //if (senderButton.Text == "*" && labelInputandRes.Text[labelInputandRes.Text.Length - 1] == '.') return;
            //if (senderButton.Text == "/" && labelInputandRes.Text[labelInputandRes.Text.Length - 1] == '.') return;


            //if (senderButton.Text == "." && labelInputandRes.Text[labelInputandRes.Text.Length - 1] == '+') return;
            //if (senderButton.Text == "." && labelInputandRes.Text[labelInputandRes.Text.Length - 1] == '-') return;
            //if (senderButton.Text == "." && labelInputandRes.Text[labelInputandRes.Text.Length - 1] == '*') return;
            //if (senderButton.Text == "." && labelInputandRes.Text[labelInputandRes.Text.Length - 1] == '/') return;

            //if (senderButton.Text == "." && !ContainsOperationsMPDU(labelInputandRes.Text) && labelInputandRes.Text.Contains(".")) return;

            //if (senderButton.Text == "." && ContainsOperationsMPDU(labelInputandRes.Text) && labelInputandRes.Text[FindIndexOfMPDU(labelInputandRes.Text)..].Contains(".")) return;

            //labelInputandRes.Text += senderButton.Text;
        }
    }

    private void ButtonClickedNumber(object sender, EventArgs e)
    {
        if (sender is Button senderButton)
            labelInputandRes.Text += senderButton.Text;
    }

    private void ButtonClickedOperations(object sender, EventArgs e)
    {
        if (sender is Button senderButton)
        {
            if (string.IsNullOrEmpty(labelInputandRes.Text) || string.IsNullOrWhiteSpace(labelInputandRes.Text))
                return;

            int lastIndexOfText = labelInputandRes.Text.Length - 1;

            if (char.IsDigit(labelInputandRes.Text[lastIndexOfText]))
            {
                labelInputandRes.Text += senderButton.Text;
                indexesOfOperations.Add(lastIndexOfText + 1);
            }
        }
    }

    private void ButtonClickedDot(object sender, EventArgs e)
    {
        if (sender is Button senderButton) {
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