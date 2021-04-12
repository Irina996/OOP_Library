using People;
using System;
using System.Windows.Forms;

namespace Library
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            cashLabel.Text = Convert.ToString(Admin.cash);
            readersLabel.Text = Convert.ToString(Admin.readersCount);
            librariansLabel.Text = Convert.ToString(Admin.librariansCount);
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form entryForm = Application.OpenForms[0];
            entryForm.Show();
        }

        private void createLibrarianBtn_Click(object sender, EventArgs e)
        {
            int number;
            try
            {
                number = Convert.ToInt32(newPhoneBox.Text);
            }
            catch
            {
                MessageBox.Show("Номер телефона должен состоять только из цифр.");
                return;
            }

            int pswd;
            try
            {
                pswd = Convert.ToInt32(newPswdBox.Text);
            }
            catch
            {
                MessageBox.Show("Пароль должен состоять только из цифр.");
                return;
            }
            pswd ^= 9512; //encrypt password

            (string, string, string, string, int, int) librarian = (newSurnameBox.Text, newNameBox.Text,
                newPatrBox.Text, newAddressBox.Text, number, pswd);
            Librarian newLibrarian = Admin.SearchLibrarian(librarian.Item1, librarian.Item6);
            if (newLibrarian != null)
            {
                MessageBox.Show("Библиотекарь с такими фамилией и паролем уже существует.");
            }
            else
            {
                string addLibrarian = Admin.AddLibrarian(librarian);
                MessageBox.Show(addLibrarian);
            }
        }

        private void delLibrarianBt_Click(object sender, EventArgs e)
        {
            int pswd;
            try
            {
                pswd = Convert.ToInt32(pswdBox.Text);
            }
            catch
            {
                MessageBox.Show("Пароль должен состоять только из цифр.");
                return;
            }
            pswd ^= 9512; //encrypt password

            (string, int) librarian = (surnameBox.Text, pswd);
            MessageBox.Show(Admin.DelLibrarian(librarian));
        }
    }
}
