using System;
using System.Windows.Forms;
using System.IO;
using People;
using Books;
using System.Security.AccessControl;
using System.Linq;

namespace Library
{
    public partial class ReaderForm : Form
    {
        Admin admin = Admin.getInstance();
        Reader reader;
        Book book = null;
        bool canListen = false;
        string path = @"..\..\..\AudioBooks\";
        string audioBookpath = @"..\..\..\AudioBooks\2";
        string[] paths;
        int maxPage, audioBookPage, readerBookPage;
        Book[] books, audioBooks, readerBooks;
        Author[][] authors, audioBooksAuthors, readerBooksAuthors;

        public ReaderForm()
        {
            InitializeComponent();
        }

        public ReaderForm(Reader rdr)
        {
            InitializeComponent();
            reader = rdr;

            if (Convert.ToInt32(admin.booksCount / 5) < Convert.ToDouble(admin.booksCount) / 5)
            {
                maxPage = Convert.ToInt32(admin.booksCount / 5) + 1;
            }
            else
                maxPage = Convert.ToInt32(admin.booksCount / 5);

            maxPageBtn.Text = maxPageBtn.Text + Convert.ToString(maxPage);

            (books, authors) = admin.GetListOfBooks(0, 5);

            int i = 0;
            foreach ( var book in books)
            {
                if (book == null)
                {
                    break;
                }

                string info = getBookInfo(authors[i], book);

                booksListBox.Items.Add(info);

                i++;
            }

            audioBookPage = 1;
            (audioBooks, audioBooksAuthors) = admin.GetListOfReaderAudioBooks(0, 5, reader.ReaderID);

            i = 0;
            foreach (var book in audioBooks)
            {
                if(book == null)
                {
                    break;
                }

                string info = getBookInfo(audioBooksAuthors[i], book);

                audioBooksListBox.Items.Add(info);

                i++;
            } 

            readerBookPage = 1;
            (readerBooks, readerBooksAuthors) = admin.GetListOfReaderBooks(0, 5, reader.ReaderID);

            i = 0;
            foreach (var book in readerBooks)
            {
                if (book == null)
                {
                    break;
                }

                string info = getBookInfo(readerBooksAuthors[i], book);

                readerBooksListBox.Items.Add(info);

                i++;
            }
        }

        private void ReaderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string adminUserName = Environment.UserName;// getting your adminUserName
            DirectorySecurity dirSecurity = Directory.GetAccessControl(audioBookpath);

            FileSystemAccessRule rule1 = new FileSystemAccessRule(adminUserName,
            FileSystemRights.FullControl, AccessControlType.Deny);
            dirSecurity.AddAccessRule(rule1);

            Directory.SetAccessControl(audioBookpath, dirSecurity);

            Form entryForm = Application.OpenForms[0];
            entryForm.Show();
        }

        /*private void getPayBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(reader.Pay));
        }*/

        private void searchBookBtn_Click(object sender, EventArgs e)
        {
            int authorId = admin.SearchAuthor(authorSurnameBox.Text, authorNameBox.Text);

            if (authorId == 0)
            {
                MessageBox.Show("Автор не найден. Проверьте введенные данные.");
                return;
            }

            book = admin.SearchBook(TitleBox.Text, authorId);

            if (book == null)
            {
                MessageBox.Show("Книга не найдена.");
                return;
            }
            else
            {
                MessageBox.Show($"Название: {TitleBox.Text}\nАвтор: {authorSurnameBox.Text} {authorNameBox.Text}\n" +
                    $"Залоговая стоимость: {book.CollateralValue}\nАрендная стоимость: {book.RentalCoast}\n"+
                    $"Количество: {book.Amount}");
            }

            canListen = admin.AudioBookIsPaidByReader(reader, book);


            string adminUserName = Environment.UserName;// getting your adminUserName
            DirectorySecurity dirSecurity = Directory.GetAccessControl(audioBookpath);

            FileSystemAccessRule rule1 = new FileSystemAccessRule(adminUserName,
            FileSystemRights.FullControl, AccessControlType.Deny);
            dirSecurity.AddAccessRule(rule1);

            Directory.SetAccessControl(audioBookpath, dirSecurity);
        }

        private void minPageBtn_Click(object sender, EventArgs e)
        {
            booksListBox.Items.Clear();

            (books, authors) = admin.GetListOfBooks(0, 5);

            int i = 0;
            foreach (var book in books)
            {
                if (book == null)
                {
                    break;
                }

                string info = getBookInfo(authors[i], book);

                booksListBox.Items.Add(info);

                i++;
            }
        }

        private void maxPageBtn_Click(object sender, EventArgs e)
        {
            booksListBox.Items.Clear();

            (books, authors) = admin.GetListOfBooks((maxPage - 1)*5, 5);

            int i = 0;
            foreach (var book in books)
            {
                if (book == null)
                {
                    break;
                }

                string info = getBookInfo(authors[i], book);

                booksListBox.Items.Add(info);

                i++;
            }
        }

        private void selectPageBtn_Click(object sender, EventArgs e)
        {
            int page;
            try
            {
                page = Convert.ToInt32(pageBox.Text);
            }
            catch
            {
                MessageBox.Show("Страница должна быть числом");
                return;
            }

            if (page > maxPage || page < 1)
            {
                MessageBox.Show($"Страница должна быть числом от 1 до {maxPage}");
            }

            booksListBox.Items.Clear();

            (books, authors) = admin.GetListOfBooks((page - 1) * 5, 5);

            int i = 0;
            foreach (var book in books)
            {
                if (book == null)
                {
                    break;
                }

                string info = getBookInfo(authors[i], book);

                booksListBox.Items.Add(info);

                i++;
            }
        }

        private void listBoxChapters_SelectedIndexChanged(object sender, EventArgs e)
        {
            // play audio book
            axWindowsMediaPlayerBooks.URL = paths[listBoxChapters.SelectedIndex];
        }

        private void nextAudioBooksBtn_Click(object sender, EventArgs e)
        {
            audioBookPage++;
            audioBooksListBox.Items.Clear();
            (books, authors) = admin.GetListOfReaderAudioBooks((audioBookPage - 1) * 5, 5, reader.ReaderID);

            int i = 0;
            foreach (var book in books)
            {
                if (book == null)
                {
                    if (i == 0)
                    {
                        MessageBox.Show("Это последняя страница");
                        prevAudioBooksBtn_Click(null, null);
                    }
                    break;
                }

                string info = getBookInfo(authors[i], book);

                audioBooksListBox.Items.Add(info);
              
                i++;
            }
        }

        private void audioBooksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = audioBooksListBox.SelectedIndex;

            book = audioBooks[index];

            canListen = admin.AudioBookIsPaidByReader(reader, book);

            string adminUserName = Environment.UserName;// getting your adminUserName
            DirectorySecurity dirSecurity = Directory.GetAccessControl(audioBookpath);

            FileSystemAccessRule rule1 = new FileSystemAccessRule(adminUserName,
            FileSystemRights.FullControl, AccessControlType.Deny);
            dirSecurity.AddAccessRule(rule1);

            Directory.SetAccessControl(audioBookpath, dirSecurity);
        }

        private void PaySearchedBtn_Click(object sender, EventArgs e)
        {
            Librarian systemLibr = admin.SearchLibrarian("Система", 8575); // admin pswd^9512

            int authorID = systemLibr.SearchAuthor(authorSurnameBox.Text, authorNameBox.Text);
            if (authorID == 0)
            {
                MessageBox.Show("Автор не найден.");
                return;
            }

            book = systemLibr.SearchBook(TitleBox.Text, authorID);
            if (book == null)
            {
                MessageBox.Show("Книга не найдена");
                return;
            }

            PayAudioBook(systemLibr);
        }

        private void nextReaderBooksBtn_Click(object sender, EventArgs e)
        {
            readerBookPage++;
            readerBooksListBox.Items.Clear();
            (books, authors) = admin.GetListOfReaderBooks((readerBookPage - 1) * 5, 5, reader.ReaderID);

            int i = 0;
            foreach (var book in books)
            {
                if (book == null)
                {
                    if (i == 0)
                    {
                        MessageBox.Show("Это последняя страница");
                        prevReaderBooksBtn_Click(null, null);
                    }
                    break;
                }

                string info = getBookInfo(authors[i], book);

                readerBooksListBox.Items.Add(info);

                i++;
            }
        }

        private void prevAudioBooksBtn_Click(object sender, EventArgs e)
        {
            if (audioBookPage == 1)
            {
                MessageBox.Show("Это первая страница");
                return;
            }

            audioBookPage--;
            audioBooksListBox.Items.Clear();
            (books, authors) = admin.GetListOfReaderAudioBooks((audioBookPage - 1)*5, 5, reader.ReaderID);

            int i = 0;
            foreach (var book in books)
            {
                if (book == null)
                {
                    break;
                }

                string info = getBookInfo(authors[i], book);

                audioBooksListBox.Items.Add(info);

                i++;
            }
        }

        private void prevReaderBooksBtn_Click(object sender, EventArgs e)
        {
            if (readerBookPage == 1)
            {
                MessageBox.Show("Это первая страница");
                return;
            }

            readerBookPage--;
            readerBooksListBox.Items.Clear();
            (books, authors) = admin.GetListOfReaderBooks((readerBookPage - 1) * 5, 5, reader.ReaderID);

            int i = 0;
            foreach (var book in books)
            {
                if (book == null)
                {
                    break;
                }

                string info = getBookInfo(authors[i], book);

                readerBooksListBox.Items.Add(info);

                i++;
            }
        }

        private void PayBookFromListBtn_Click(object sender, EventArgs e)
        {
            Librarian systemLibr = admin.SearchLibrarian("Система", 8575); // admin pswd^9512
            book = books[booksListBox.SelectedIndex];
            PayAudioBook(systemLibr);
        }

        private void listenBookBtn_Click(object sender, EventArgs e)
        {   
            if (!canListen)
            {
                MessageBox.Show("Оплатите данную услугу у библиотекаря");
            }
            else
            {
                if (Directory.Exists(path + $"{book.BookID}"))
                {
                    audioBookpath = path + $"{book.BookID}";

                    // get access to file
                    string adminUserName = Environment.UserName;// getting your adminUserName
                    DirectorySecurity dirSecurity = Directory.GetAccessControl(audioBookpath);

                    FileSystemAccessRule rule1 = new FileSystemAccessRule(adminUserName,
                    FileSystemRights.FullControl, AccessControlType.Deny);
                    dirSecurity.RemoveAccessRule(rule1);

                    Directory.SetAccessControl(audioBookpath, dirSecurity);

                    paths = Directory.GetFiles(audioBookpath);

                    listBoxChapters.Items.Clear();
                    int i = 0;
                    foreach (string p in paths)
                    {
                        FileInfo file = new FileInfo(p);
                        paths[i] = file.FullName;
                        listBoxChapters.Items.Add(file.Name);
                        i++;
                    }
                }
                else
                {
                    MessageBox.Show("Нет такой аудиокниги");
                }
            }
        }

        private void booksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = booksListBox.SelectedIndex;

            book = books[index];

            string message = $"Название: {book.Title}\nАвтор: {authors[index][0].Surname} {authors[index][0].Name}";
            foreach(var author in authors[index].Skip(1))
            {
                message += $", {author.Surname} {author.Name}";
            }
            message += $"\nЖанр: {book.Genre}\nЗалоговая стоимость: {book.CollateralValue}\nАрендная стоимость: " +
                $"{book.RentalCoast}\nКоличество: {book.Amount}";

            MessageBox.Show(message);

            canListen = admin.AudioBookIsPaidByReader(reader, book);

            string adminUserName = Environment.UserName;// getting your adminUserName
            DirectorySecurity dirSecurity = Directory.GetAccessControl(audioBookpath);

            FileSystemAccessRule rule1 = new FileSystemAccessRule(adminUserName,
            FileSystemRights.FullControl, AccessControlType.Deny);
            dirSecurity.AddAccessRule(rule1);

            Directory.SetAccessControl(audioBookpath, dirSecurity);
        }

        private void PayAudioBook(Librarian systemLibr)
        {
            if (!Directory.Exists(path + $"{book.BookID}"))
            {
                MessageBox.Show("Эта аудиокнига еще не добавлена.");
                return;
            }

            if (admin.AudioBookIsPaidByReader(reader, book))
            {
                MessageBox.Show("Данная аудиокнига уже оплачена Вами.");
                return;
            }

            string goal = "Оплата аудиокниги";
            (int, int, string, DateTime) libCall = (reader.ReaderID, systemLibr.LibID, goal, DateTime.Now);
            if (!systemLibr.CreateLibCall(libCall))
            {
                MessageBox.Show("Не удалось зафиксировать обращение в библиотеку.");
                return;
            }

            if (!systemLibr.PayAudioBook(reader.ReaderID, book.BookID))
            {
                MessageBox.Show("Не удалось зафиксировать оплату.");
                return;
            }

            admin.cash += book.CollateralValue;
            MessageBox.Show("Документ создан.");
            canListen = true;
        }

        private string getBookInfo(Author[] authors, Book book)
        {
            string info = $"{authors[0].Surname} {authors[0].Name}";
            foreach (var author in authors.Skip(1))
            {
                info += $", {author.Surname} {author.Name}";
            }
            info += $" \"{book.Title}\"";

            return info;
        }
    }
}
