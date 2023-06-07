namespace Calculator;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private bool ContainsOperationsMPDU(string Text)
    {
        bool contains = false;

        if (Text == null) return contains;

        if(Text.Contains("+") || Text.Contains("-") || Text.Contains("*") || Text.Contains("/")) { contains = true; }

        return contains;
    }

    private int FindIndexOfMPDU(string Text)
    {
        if(Text.Contains('+')) return Text.IndexOf('+');
        if(Text.Contains('-')) return Text.IndexOf('-');
        if(Text.Contains('*')) return Text.IndexOf('*');
        if(Text.Contains('/')) return Text.IndexOf('/');
        return -1;
    }

    private void ButtonClicked(object sender, EventArgs e)
    {// сделать все нормально, для равно чтобы выходило решение, после равно кнопка все стирает и пишет свой текст
        if(sender is Button senderButton)
        {
            if(senderButton.Text == "C")
            {
                labelInputandRes.ResetText();
                return;
            }

            if (senderButton.Text == "=" && (!ContainsOperationsMPDU(labelInputandRes.Text) || !double.TryParse(labelInputandRes.Text[(FindIndexOfMPDU(labelInputandRes.Text))..], out double d))) return;
            
            if (senderButton.Text == "+" && ContainsOperationsMPDU(labelInputandRes.Text)) return;
            if (senderButton.Text == "-" && ContainsOperationsMPDU(labelInputandRes.Text)) return;
            if (senderButton.Text == "*" && ContainsOperationsMPDU(labelInputandRes.Text)) return;
            if (senderButton.Text == "/" && ContainsOperationsMPDU(labelInputandRes.Text)) return;

            if (senderButton.Text == "+" && string.IsNullOrEmpty(labelInputandRes.Text)) return;
            if (senderButton.Text == "-" && string.IsNullOrEmpty(labelInputandRes.Text)) return;
            if (senderButton.Text == "*" && string.IsNullOrEmpty(labelInputandRes.Text)) return;
            if (senderButton.Text == "/" && string.IsNullOrEmpty(labelInputandRes.Text)) return;
            if (senderButton.Text == "." && string.IsNullOrEmpty(labelInputandRes.Text)) return;

            if (senderButton.Text == "+" && labelInputandRes.Text[labelInputandRes.Text.Length - 1] == '.') return;
            if (senderButton.Text == "-" && labelInputandRes.Text[labelInputandRes.Text.Length - 1] == '.') return;
            if (senderButton.Text == "*" && labelInputandRes.Text[labelInputandRes.Text.Length - 1] == '.') return;
            if (senderButton.Text == "/" && labelInputandRes.Text[labelInputandRes.Text.Length - 1] == '.') return;
            

            if (senderButton.Text == "." && labelInputandRes.Text[labelInputandRes.Text.Length - 1] == '+') return;
            if (senderButton.Text == "." && labelInputandRes.Text[labelInputandRes.Text.Length - 1] == '-') return;
            if (senderButton.Text == "." && labelInputandRes.Text[labelInputandRes.Text.Length - 1] == '*') return;
            if (senderButton.Text == "." && labelInputandRes.Text[labelInputandRes.Text.Length - 1] == '/') return;

            if (senderButton.Text == "." && !ContainsOperationsMPDU(labelInputandRes.Text) && labelInputandRes.Text.Contains(".")) return;

            if (senderButton.Text == "." && ContainsOperationsMPDU(labelInputandRes.Text) && labelInputandRes.Text[FindIndexOfMPDU(labelInputandRes.Text)..].Contains(".")) return;

            labelInputandRes.Text += senderButton.Text;

            

            //if(!int.TryParse(senderButton.Text, out int tmp)){
            //    if(senderButton.Text == "C")
            //    {
            //        labelInputandRes.ResetText();
            //    }

            //    if ((senderButton.Text == "=") && (!ContainsOperationsMPDU(labelInputandRes.Text) || !double.TryParse(labelInputandRes.Text[(FindIndexOfMPDU(labelInputandRes.Text) + 1)..], out double d))) return;

            //    if (string.IsNullOrEmpty(labelInputandRes.Text) || string.IsNullOrWhiteSpace(labelInputandRes.Text))   return;

            //    if ((ContainsOperationsMPDU(labelInputandRes.Text) && ContainsOperationsMPDU(senderButton.Text))) return;

            //    if (senderButton.Text == "." && !ContainsOperationsMPDU(labelInputandRes.Text) && labelInputandRes.Text.Contains(".") ) return;

            //    if (senderButton.Text == "." && ContainsOperationsMPDU(labelInputandRes.Text) && labelInputandRes.Text[FindIndexOfMPDU(labelInputandRes.Text)..].Contains(".")) return;
            //}

        
            
            //if( (string.IsNullOrEmpty(labelInputandRes.Text) || string.IsNullOrWhiteSpace(labelInputandRes.Text)) && int.TryParse(senderButton.Text, out int tmp))
            //{
            //    labelInputandRes.Text += senderButton.Text;
            //    return;
            //}

            //if (labelInputandRes.Text[labelInputandRes.Text.Length - 1] && int.TryParse(senderButton.Text, out int tmp))
            //{
            //    labelInputandRes.Text += senderButton.Text;
            //    return;
            //}
        }
    }


}