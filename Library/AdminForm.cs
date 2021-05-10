using People;
using System;
using System.Drawing;
using System.Windows.Forms;
using Books;

namespace Library
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();

            genreComboBox.DataSource = Enum.GetValues(typeof(Genre));
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
            int number; // telephone number
            try
            {
                number = Convert.ToInt32(newPhoneBox.Text);
            }
            catch
            {
                MessageBox.Show("Номер телефона должен состоять только из цифр.");
                return;
            }

            int pswd; // password
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

        private void chngPswdBtn_Click(object sender, EventArgs e)
        {
            // пасхалка)
            if (oldPswdBox.Text == "irina996" && adminPswdBox.Text == "irina996" && adminPswdBox2.Text == "irina996")
            {
                pictureBox1.Image = Image.FromFile(@"..\..\..\People\Zaslavl.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                MessageBox.Show("Любуйтесь)");
                return;
            }

            // change admin password
            int oldpswd, pswd, pswd2;
            try
            {
                oldpswd = Convert.ToInt32(oldPswdBox.Text);
                pswd = Convert.ToInt32(adminPswdBox.Text);
                pswd2 = Convert.ToInt32(adminPswdBox2.Text);
            }
            catch
            {
                MessageBox.Show("Пароль должен состоять только из цифр.");
                return;
            }
            if (Admin.ChangePassword(oldpswd, pswd, pswd2))
            {
                MessageBox.Show("Пароль успешно изменен.");
            }
            else
            {
                MessageBox.Show("Ошибка. Пароль не был изменен.");
            }
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            double collateral, rental;
            int amount;

            try
            {
                collateral = Convert.ToDouble(collateralBox.Text);
                rental = Convert.ToDouble(rentalBox.Text);
                amount = Convert.ToInt32(amountBox.Text);
            }
            catch
            {
                MessageBox.Show("Стоимость и количество должны быть числами.");
                return;
            }

            Genre genre = (Genre)genreComboBox.SelectedItem;

            if (Admin.AddBook(titleBox.Text, aSurnameBox.Text, aNameBox.Text, 
                genre, collateral, rental, amount))
            {
                MessageBox.Show("Книга успешно добавлена.");
            }
            else
            {
                MessageBox.Show("Ошибка. Книга не была добавлена.");
            }
        }
    }
}
