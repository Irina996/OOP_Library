using People;
using System;
using System.Windows.Forms;
using TextBoxExtension;
using System.Drawing;

namespace Library
{
    public partial class EntryForm : Form
    {
        Admin admin;

        public EntryForm()
        {
            InitializeComponent();
            this.ActiveControl = label1;
            loginBox.Init("Логин", false);
            passwordBox.Init("Пароль", true);
            admin = Admin.getInstance();
            admin.ReadInfo();
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

                if (pswd == 110321)
                {
                    MessageBox.Show("Владимир Михайлович???");
                    return;
                }
  
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
                if (!admin.IsPasswordCorrect(pswd))
                {
                    MessageBox.Show("Неверный пароль.");
                    return;
                }
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Hide();
            }

            // Sign in as librarian
            else if (loginBox.ForeColor != Color.Gray && passwordBox.Text != "Пароль")
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

                Librarian librarian = admin.SearchLibrarian(loginBox.Text, pswd);

                if (librarian != null)
                {
                    LibrarianForm librarianForm = new LibrarianForm(librarian);
                    librarianForm.Show();
                    this.Hide();
                    return;
                }

                pswd ^= 9512;
                Reader reader = admin.SearchReaderByID(loginBox.Text, Convert.ToInt32(pswd / 1000));
                if (reader != null && pswd == reader.GetPswd())
                {
                    ReaderForm readerForm = new ReaderForm(reader);
                    readerForm.Show();
                    this.Hide();
                    return;
                }
                else
                {
                    MessageBox.Show("Ошибка. Неправильный логин или пароль.");
                }
            }
            else
            {
                MessageBox.Show("Введите логин и пароль.");
            }
        }

        private void EntryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string error = admin.WriteInfo();
            if (error != null)
            {
                MessageBox.Show(error);
            }
        }
    }
}
