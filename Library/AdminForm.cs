﻿using People;
using System;
using System.Drawing;
using System.Windows.Forms;
using Books;

namespace Library
{
    public partial class AdminForm : Form
    {
        Admin admin;

        public AdminForm()
        {
            InitializeComponent();
            admin = Admin.getInstance();
            genreComboBox.DataSource = Enum.GetValues(typeof(Genre));
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            cashLabel.Text = Convert.ToString(admin.cash);
            readersLabel.Text = Convert.ToString(admin.readersCount);
            librariansLabel.Text = Convert.ToString(admin.librariansCount);
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

            Librarian newLibrarian = admin.SearchLibrarian(librarian.Item1, librarian.Item6);
            if (newLibrarian != null)
            {
                MessageBox.Show("Библиотекарь с такими фамилией и паролем уже существует.");
            }
            else
            {
                if (librarian.Item1.Length < 3 && librarian.Item2.Length < 3 && librarian.Item3.Length < 3)
                {
                    MessageBox.Show("ФИО должно состоять из слов длиннее 2 букв.");
                    return;
                }

                if (librarian.Item4.Length < 4)
                {
                    MessageBox.Show("Адрес должен состоять минимум из 4 букв.");
                    return;
                }

                if (librarian.Item5 < 1000000 || librarian.Item5 > 9999999)
                {
                    MessageBox.Show("Телефонный номер должен состоять из 7 цифр.");
                    return;
                }

                if (admin.AddLibrarian(librarian))
                {
                    admin.librariansCount = admin.librariansCount + 1;
                    MessageBox.Show("Библиотекарь успешно добавлен.");
                }
                else
                    MessageBox.Show("Ошибка. Библиотекарь не был добавлен.");
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

            if (admin.DelLibrarian(librarian))
            {
                MessageBox.Show("Библиотекарь успешно удален.");
            }
            else
                MessageBox.Show("Ошибка. Библиотекарь не был удален.");
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
            if (admin.ChangePassword(oldpswd, pswd, pswd2))
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

            if (admin.AddBook(titleBox.Text, aSurnameBox.Text, aNameBox.Text, 
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
