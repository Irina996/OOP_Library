using People;
using System;
using System.Windows.Forms;

namespace Library
{
    public partial class LibrarianForm : Form
    {
        Librarian librarian;

        public LibrarianForm()
        {
            InitializeComponent();
        }

        public LibrarianForm(Librarian libr)
        {
            InitializeComponent();
            librarian = libr;
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
                string addReaderResult = librarian.AddReader(readerFields);
                MessageBox.Show(addReaderResult);

                newReader = librarian.SearchReader(readerFields.Item1, readerFields.Item5);
                if (newReader != null)
                {
                    CreateDocForm createDocForm = new CreateDocForm(librarian, newReader);
                    createDocForm.Show();
                    this.Hide();
                }
            }
        }
    }
}
