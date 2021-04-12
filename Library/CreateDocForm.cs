﻿using People;
using System;
using System.Windows.Forms;
using Books;

namespace Library
{
    public partial class CreateDocForm : Form
    {
        Librarian librarian;
        Reader reader;

        public CreateDocForm()
        {
            InitializeComponent();
        }
        public CreateDocForm(Librarian libr, Reader read)
        {
            InitializeComponent();
            librarian = libr;
            reader = read;
        }

        private void CreateDocForm_Load(object sender, EventArgs e)
        {

        }

        private void CreateDocForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form libraryForm = Application.OpenForms[1];
            libraryForm.Show();
        }

        private void createLibCallBtn_Click(object sender, EventArgs e)
        {
            (int, int, string, DateTime) libCall = (reader.ReaderID, librarian.LibID, 
                libCallGoalBox.Text, DateTime.Now);

            if (librarian.CreateLibCall(libCall))
            {
                MessageBox.Show("Обращение зафиксированно.");
            }
            else
                MessageBox.Show("Ошибка. Обращение не зафиксированно.");
        }

        private void createIssuingBookBtn_Click(object sender, EventArgs e)
        {
            if (statusBox.Text == "Выдача" || statusBox.Text == "выдача")
            {
                int authorID = librarian.SearchAuthor(authorSurnameBox.Text, authorNameBox.Text);
                if (authorID == 0)
                {
                    MessageBox.Show("Автор не найден.");
                    return;
                }

                Book book = librarian.SearchBook(TitleBox.Text, authorID);
                if (book == null)
                {
                    MessageBox.Show("Книга не найдена");
                    return;
                }

                string goal = "Выдача книги";
                (int, int, string, DateTime) libCall = (reader.ReaderID, librarian.LibID, goal, DateTime.Now);
                if (!librarian.CreateLibCall(libCall))
                {
                    MessageBox.Show("Не удалось зафиксировать обращение в библиотеку.");
                    return;
                }

                int libCallID = librarian.LastlibCallID();

                (int, int, DateTime, DateTime) issuingBook = (book.BookID, libCallID,
                    DateTime.Now, DateTime.Now.AddDays(4));

                if (librarian.CreateIssuingBook(issuingBook))
                {
                    MessageBox.Show("Документ создан.");
                    book.Amount -= 1;
                    librarian.ChangeBookAmount(book.BookID, book.Amount);
                    Admin.cash += book.CollateralValue;
                }
                else
                    MessageBox.Show("Ошибка.Документ не создан");
            }
            else if (statusBox.Text == "Возврат" || statusBox.Text == "возврат")
            {
                int authorID = librarian.SearchAuthor(authorSurnameBox.Text, authorNameBox.Text);
                if (authorID == 0)
                {
                    MessageBox.Show("Автор не найден.");
                    return;
                }

                Book book = librarian.SearchBook(TitleBox.Text, authorID);
                if (book == null)
                {
                    MessageBox.Show("Книга не найдена");
                    return;
                }

                string goal = "Возврат книги";
                (int, int, string, DateTime) libCall = (reader.ReaderID, librarian.LibID, goal, DateTime.Now);
                if (!librarian.CreateLibCall(libCall))
                {
                    MessageBox.Show("Не удалось зафиксировать обращение в библиотеку.");
                    return;
                }

                book.Amount += 1;
                librarian.ChangeBookAmount(book.BookID, book.Amount);
                Admin.cash -= book.CollateralValue;
            }
            else
                MessageBox.Show("Неправильный ввод");
        }
    }
}