using People;
using System;
using System.Windows.Forms;

namespace Library
{
    public partial class LibrarianForm : Form
    {
        Librarian librarian;
        Admin admin;

        public LibrarianForm()
        {
            InitializeComponent();
        }

        public LibrarianForm(Librarian libr)
        {
            InitializeComponent();
            librarian = libr;
            admin = Admin.getInstance();
        }

        private void LibrarianForm_Load(object sender, EventArgs e)
        {

        }

        private void LibrarianForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form entryForm = Application.OpenForms[0];
            entryForm.Show();
        }

        private void searchReaderBtn_Click(object sender, EventArgs e)
        {
            int number;
            try
            {
                number = Convert.ToInt32(phoneNumBox.Text);
            }
            catch
            {
                MessageBox.Show("Номер телефона должен состоять только из цифр.");
                return;
            }
            Reader reader = librarian.SearchReader(surnameBox.Text, number);
            if (reader != null)
            {
                CreateDocForm createDocForm = new CreateDocForm(librarian, reader);
                createDocForm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Нет такого читателя.");
        }

        private void createReaderBtn_Click(object sender, EventArgs e)
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

            (string, string, string, string, int) readerFields = (newSurnameBox.Text, newNameBox.Text,
                newPatrBox.Text, newAddressBox.Text, number);
            Reader newReader = librarian.SearchReader(readerFields.Item1, readerFields.Item5);
            if (newReader != null)
            {
                MessageBox.Show("Читатель с такими фамилией и номером уже существует.");
            }
            else
            {
                if (readerFields.Item1.Length < 3 && readerFields.Item2.Length < 3 && readerFields.Item3.Length < 3)
                {
                    MessageBox.Show("ФИО должно состоять из слов длиннее 2 букв.");
                    return;
                }

                if (readerFields.Item4.Length < 4)
                {
                    MessageBox.Show("Адрес должен состоять минимум из 4 букв.");
                    return;
                }

                if (readerFields.Item5 < 1000000 || readerFields.Item5 > 9999999)
                {
                    MessageBox.Show("Телефонный номер должен состоять из 7 цифр.");
                }

                if (librarian.AddReader(readerFields))
                {
                    admin.readersCount = admin.readersCount + 1;
                }
                else
                    MessageBox.Show("Ошибка. Читатель не был добавлен.");

                newReader = librarian.SearchReader(readerFields.Item1, readerFields.Item5);
                if (newReader != null)
                {
                    CreateDocForm createDocForm = new CreateDocForm(librarian, newReader);
                    createDocForm.Show();
                    this.Hide();
                }
            }
        }

        private void delReaderBtn_Click(object sender, EventArgs e)
        {
            int number;
            try
            {
                number = Convert.ToInt32(delPhoneBox.Text);
            }
            catch
            {
                MessageBox.Show("Номер телефона должен состоять только из цифр.");
                return;
            }

            (string, int) reader = (delSurnameBox.Text, number);

            if (librarian.DelReader(reader))
            {
                admin.readersCount += 1;
                MessageBox.Show("Читатель успешно удален.");
            }
            else
                MessageBox.Show("Ошибка. Читатель не был удален.");
        }
    }
}
