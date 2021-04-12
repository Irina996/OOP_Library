using System.Drawing;
using System.Windows.Forms;

namespace TextBoxExtension
{
    public static class TextBoxExtension
    {
        public static void Init(this TextBox textBox, string prompt, bool pswd)
        {
            textBox.Text = prompt;
            bool wma = true;
            textBox.ForeColor = Color.Gray;
            textBox.GotFocus += (source, ex) =>
            {
                if (textBox.ForeColor == Color.Black)
                    return;
                if (wma)
                {
                    wma = false;
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
                if (pswd)
                {
                    textBox.PasswordChar = '*';
                }
            };

            textBox.LostFocus += (source, ex) =>
            {
                if (textBox.Text.Length == 0)
                {
                    textBox.Text = prompt;
                    textBox.ForeColor = Color.Gray;
                    textBox.PasswordChar = '\0';
                    wma = true;
                    return;
                }
            };
            textBox.TextChanged += (source, ex) =>
            {
                if (textBox.Text.Length > 0)
                {
                    textBox.ForeColor = Color.Black;
                }
                if (pswd)
                {
                    textBox.PasswordChar = '*';
                }
            };
        }
    }
}
