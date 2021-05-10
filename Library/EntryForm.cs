using People;
using System;
using System.Windows.Forms;
using TextBoxExtension;
using System.Drawing;

namespace Library
{
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
            this.ActiveControl = label1;
            loginBox.Init("Логин", false);
            passwordBox.Init("Пароль", true);
            Admin.ReadInfo();
        }

        private void entryButton_Click(object sender, EventArgs e)
        {
            // пасхалка)
            if (loginBox.Text == "Логин" && loginBox.ForeColor != Color.Gray)
            {
                int pswd;
                try
                {
                    pswd = Convert.ToInt32(passwordBox.Text);
                }
                catch
                {
                    MessageBox.Show("Пароль должен состоять только из цифр");
                    return;
                }
                MessageBox.Show("Владимир Михайлович???");
                return;
            }    
           
            // Sign in as admin
            if (loginBox.Text == "Admin" || loginBox.Text == "Админ")
            {
                int pswd;
                try
                {
                    pswd = Convert.ToInt32(passwordBox.Text);
                }
                catch
                {
                    MessageBox.Show("Пароль должен состоять только из цифр");
                    return;
                }
                if (!Admin.IsPasswordCorrect(pswd))
                {
                    MessageBox.Show("Неверный пароль.");
                    return;
                }
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Hide();
            }

            // Sign in as librarian
            else if (loginBox.Text != "Логин" && passwordBox.Text != "Пароль")
            {
                int pswd;
                try
                {
                    pswd = Convert.ToInt32(passwordBox.Text);
                }
                catch
                {
                    MessageBox.Show("Пароль должен состоять только из цифр");
                    return;
                }

                pswd ^= 9512;

                Librarian librarian = Admin.SearchLibrarian(loginBox.Text, pswd);

                if (librarian != null)
                {
                    LibrarianForm librarianForm = new LibrarianForm(librarian);
                    librarianForm.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Ошибка. Неправильный логин или пароль.");
            }
        }

        private void EntryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string error = Admin.WriteInfo();
            if (error != null)
            {
                MessageBox.Show(error);
            }
        }
    }
}
