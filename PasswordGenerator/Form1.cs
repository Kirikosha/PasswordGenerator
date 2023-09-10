using PasswordCreator;


namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InputAnalyser(object sender, EventArgs e)
        {
            string input = paswordLengthField.Text;
            if (input == null)
            {
                paswordLengthField.Text = "6";
            }
            else
            {
                bool isDigit = input.All(char.IsDigit);
                if (!isDigit)
                {
                    paswordLengthField.Text = "6";
                }
                else if (input.StartsWith("0"))
                {
                    paswordLengthField.Text = "6";
                }
            }
        }

        private void PasswordGenerateClick(object sender, EventArgs e)
        {
            bool[] conditions = new bool[] { uppercaseCondition.Checked, numberCondition.Checked, symbolsCondition.Checked };
            string length = paswordLengthField.Text;
            string password = PasswordCreator.RPasswordCreator.Create(length, conditions);
            passwordField.Text = password;
        }

        private void CopyPassword(object sender, EventArgs e)
        {
            if(passwordField.Text.Length >= 6)
            {
                System.Windows.Forms.Clipboard.SetText(passwordField.Text);
            }
        }
    }
}