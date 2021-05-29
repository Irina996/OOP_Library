using System;
using System.Windows.Forms;
using System.IO;
using People;
using Books;
using System.Security.AccessControl;

namespace Library
{
    public partial class ReaderForm : Form
    {
        Reader reader;
        Book book = null;
        bool canListen = false;
        string path = @"..\..\..\AudioBooks\";
        string audioBookpath = @"..\..\..\AudioBooks\2 2";
        string[] paths;

        public ReaderForm()
        {
            InitializeComponent();
        }

        public ReaderForm(Reader rdr)
        {
            InitializeComponent();
            reader = rdr;
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

        private void getPayBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(reader.Pay));
        }

        private void searchBookBtn_Click(object sender, EventArgs e)
        {
            Admin admin = Admin.getInstance();
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

        private void listBoxChapters_SelectedIndexChanged(object sender, EventArgs e)
        {
            // play audio book
            axWindowsMediaPlayerBooks.URL = paths[listBoxChapters.SelectedIndex];
        }

        private void listenBookBtn_Click(object sender, EventArgs e)
        {   
            if (!canListen)
            {
                MessageBox.Show("Оплатите данную услугу у библиотекаря");
            }
            else
            {
                if (Directory.Exists(path + $"{book.AuthorID} {book.BookID}"))
                {
                    audioBookpath = path + $"{book.AuthorID} {book.BookID}";

                    // get access to file
                    string adminUserName = Environment.UserName;// getting your adminUserName
                    DirectorySecurity dirSecurity = Directory.GetAccessControl(audioBookpath);

                    FileSystemAccessRule rule1 = new FileSystemAccessRule(adminUserName,
                    FileSystemRights.FullControl, AccessControlType.Deny);
                    dirSecurity.RemoveAccessRule(rule1);

                    Directory.SetAccessControl(audioBookpath, dirSecurity);

                    paths = Directory.GetFiles(audioBookpath);

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
    }
}
